using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

      public string globFolder;
      public string globFileTypes;

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
         FileInfo[] files = dir.GetFiles(txtbFileTypes.Text);

         lvFilesFolders.Scrollable = true;
         lvFilesFolders.View = View.Details;

         lvFilesFolders.Items.Add("Folder: " + globFolder);
         lvFilesFolders.Items.Add("------------------------------");

         foreach (FileInfo file in files)
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
         lvFinalPrev.Items.Add("Folder: " + globFolder);
         lvFinalPrev.Items.Add("------------------------------");

      }
   }
}
