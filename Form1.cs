using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brf
{
   public partial class frmMain : Form
   {
      public frmMain()
      {
         InitializeComponent();
      }

      // public vars
      public string globFolder;
      public FileInfo[] globFileTypes;
      public const string vbCrl = "\\n";
      public SearchOption SearchOptionUserType;

      private void pbFolder_Click(object sender, EventArgs e)
      {
         FolderBrowserDialog fbdResult = new FolderBrowserDialog();
         int counter = 0;

         if ((chkbFilesDocs.Checked != true) && 
            (chkbFilesImg.Checked != true) && 
            (chkbFilesSound.Checked != true) && 
            (chkbFilesAll.Checked != true) && 
            (chkbFilesVideo.Checked != true) && 
            (chkbFilesOther.Checked != true))
         {
            if ((chkbFilesOther.Checked == true) &&
               (txtbFileTypes.ReadOnly == false) &&
               (String.IsNullOrEmpty(txtbFileTypes.Text)))
            {
               MessageBox.Show("Write file type!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               _ = txtbFileTypes.Focus();
               return;
            }
            else 
            {
               MessageBox.Show("Select file type (at least one)!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               _ = chkbFilesDocs.Focus();
               return;
            }
         }

         if ((chkbFilesOther.Checked == true) &&
              (txtbFileTypes.ReadOnly == false) &&
              (String.IsNullOrEmpty(txtbFileTypes.Text)))
         {
            MessageBox.Show("Write file type!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _ = txtbFileTypes.Focus();
            return;
         }

         
         if (fbdFolder.ShowDialog() == DialogResult.OK)
         {
            txtbSelectedFolder.Text = fbdFolder.SelectedPath.ToString();
            globFolder = txtbSelectedFolder.Text;
         }

         DirectoryInfo dir = new DirectoryInfo(globFolder);
         globFileTypes = dir.GetFiles(txtbFileTypes.Text, SearchOptionUserType);

         lvFilesFolders.Scrollable = true;
         lvFilesFolders.View = View.Details;

         lvFilesFolders.Items.Add("Folder: " + globFolder);
         lvFilesFolders.Items.Add("------------------------------");

         foreach (FileInfo file in globFileTypes)
         {
            counter += 1;
            Console.WriteLine("File Name : {0}", file.Name);
            lvFilesFolders.Items.Add("N° " + counter.ToString() + " " + file.Name.ToString());
         }

         _ = txtReplaceThis.Focus();

      }

      private void frmMain_Load(object sender, EventArgs e)
      {
         _ = txtbFileTypes.Focus();
      }

      private void chkbFilesOther_CheckedChanged(object sender, EventArgs e)
      {
         if ((chkbFilesOther.Checked) && String.IsNullOrEmpty(txtbFileTypes.Text))
         {
            txtbFileTypes.ReadOnly = false;
            _ = txtbFileTypes.Focus();
         }
         else
         {
            txtbFileTypes.Text = String.Empty;
            txtbFileTypes.ReadOnly = true;
         }

      }

      private void btnPreview_Click(object sender, EventArgs e)
      {
         int counter = 0;
         string finalName = string.Empty;

         lvFinalPrev.Scrollable = true;
         lvFinalPrev.View = View.Details;

         lvFinalPrev.Items.Add("Folder: " + globFolder);
         lvFinalPrev.Items.Add("------------------------------");

         foreach (FileInfo file in globFileTypes)
         {
            counter += 1;
            finalName = file.Name.Replace(txtReplaceThis.Text, txtReplaceForThis.Text);
            Console.WriteLine("File Name : {0}", finalName);
            lvFinalPrev.Items.Add("N° " + counter.ToString() + " " + finalName);
         }

      }

      private void btnSubmit_Click(object sender, EventArgs e)
      {
         int counter = 0;
         string finalName = string.Empty;

         try
         {
            foreach (FileInfo file in globFileTypes)
            {
               counter += 1;
               finalName = file.Name.Replace(txtReplaceThis.Text, txtReplaceForThis.Text);
               File.Move(globFolder + "\\" + file, globFolder + "\\" + finalName);
            }

            if (chkOpenFE.Checked)
            {
               try
               {
                  // open folder in file explorer once the proccess it's done
                  Process.Start(globFolder);
               }
               catch (Win32Exception w32Exce)
               {
                  //The system cannot find the file specified...
                  Console.WriteLine(w32Exce.Message);
                  MessageBox.Show("Error to open File Explorer: " + vbCrl + w32Exce.Message.ToString(), "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }

            MessageBox.Show("The process finished!" + vbCrl + "...everything was like a globe!", "Success: files renamed", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
         catch (IOException ioEx)
         {
            Console.WriteLine(ioEx.Message);
            MessageBox.Show("Error on renaming files: " + vbCrl + ioEx.Message.ToString(), "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         
      }

      private void chksubfolders_CheckedChanged(object sender, EventArgs e)
      {
         if (chksubfolders.Enabled)
            SearchOptionUserType = SearchOption.AllDirectories;
         else
            SearchOptionUserType = SearchOption.TopDirectoryOnly;
      }
   }
}
