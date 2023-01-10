using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
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
      public SearchOption SearchOptionUserType;

      // public constants
      private const string vbCrl = "\n";
      private const string backslash = "\\";
      private const string filetypeOffice = ConfigurationManager.AppSettings["filetypeOffice"];
      private const string filetypeOfficex = ConfigurationManager.AppSettings["filetypeOfficex"];
      private const string filetypeImage = ConfigurationManager.AppSettings["filetypeImage"];
      private const string filetypeVideo = ConfigurationManager.AppSettings["filetypeVideo"];
      private const string filetypeText = ConfigurationManager.AppSettings["filetypeText"];

      /// <summary>
      /// reset values from folder and file forms
      /// </summary>
      private void resetFolderAndFiles()
      {
         chkbFilesDocs.Checked = false;
         chkbFilesImg.Checked = false;
         chkbFilesSound.Checked = false;
         chkbFilesVideo.Checked = false;
         chkbFilesOther.Checked = false;
         chkbtext.Checked = false;
         chkbFilesAll.Checked = false;
         chksubfolders.Checked = false;

         txtbFileTypes.Text = string.Empty;
         txtbSelectedFolder.Text = string.Empty;

         globFolder = string.Empty;
         lvFilesFolders.Clear();
      }

      /// <summary>
      /// reset values from what and where forms
      /// </summary>
      private void resetWhatandWhere()
      {
         txtReplaceThis.Text = string.Empty;
         txtReplaceForThis.Text = string.Empty;
         txtRegex.Text = string.Empty;

         rbjustremove.Checked = false;
         rbregex.Checked = false;
         chkOpenFE.Checked = false;

         lvFinalPrev.Clear();

      }

      private void frmMain_Load(object sender, EventArgs e)
      {
         _ = txtbFileTypes.Focus();
      }

      private void chkbFilesOther_CheckedChanged(object sender, EventArgs e)
      {
         // enable the option to enter manually what type of files to read
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

      /// <summary>
      /// Display a preview: of how the files going to be once finished the process
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
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

      /// <summary>
      /// the renaming process
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
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
               File.Move(globFolder + backslash + file, globFolder + backslash + finalName);
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
                  //The system wasn't able to execute the task...
                  Console.WriteLine(w32Exce.Message);
                  MessageBox.Show("Error to open File Explorer: " + vbCrl + w32Exce.Message.ToString(), "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }

            MessageBox.Show("The process renamed " + counter.ToString() + " files!" + vbCrl + "...Everything was like a globe!", "Success: files renamed", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
         catch (IOException ioEx)
         {
            Console.WriteLine(ioEx.Message);
            MessageBox.Show("Error on renaming files: " + vbCrl + ioEx.Message.ToString(), "File system Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
            MessageBox.Show("Error on renaming files: " + vbCrl + ex.Message.ToString(), "Other error type: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         
      }

      /// <summary>
      /// set up whether must use sub folder option (cascade file read) 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void chksubfolders_CheckedChanged(object sender, EventArgs e)
      {
         if (chksubfolders.Enabled)
            SearchOptionUserType = SearchOption.AllDirectories;
         else
            SearchOptionUserType = SearchOption.TopDirectoryOnly;
      }

      private void btnResetFileFolder_Click(object sender, EventArgs e)
      {
         resetFolderAndFiles();
      }

      private void btnResetWhatTo_Click(object sender, EventArgs e)
      {
         resetWhatandWhere();
      }

      private void btnResetAll_Click(object sender, EventArgs e)
      {
         resetFolderAndFiles();
         resetWhatandWhere();

      }

      /// <summary>
      /// main process
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSelectFolder_Click(object sender, EventArgs e)
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

         // select folder to work
         if (fbdFolder.ShowDialog() == DialogResult.OK)
         {
            txtbSelectedFolder.Text = fbdFolder.SelectedPath.ToString();
            globFolder = txtbSelectedFolder.Text;
         }

         // set up folder 
         DirectoryInfo dir = new DirectoryInfo(globFolder);
         // get a file list
         globFileTypes = dir.GetFiles(txtbFileTypes.Text, SearchOptionUserType);

         lvFilesFolders.Scrollable = true;
         lvFilesFolders.View = View.Details;

         lvFilesFolders.Items.Add("Folder: " + globFolder);
         lvFilesFolders.Items.Add("------------------------------");

         // display the folder and files selected
         foreach (FileInfo file in globFileTypes)
         {
            counter += 1;
            Console.WriteLine("File Name : {0}", file.Name);
            lvFilesFolders.Items.Add("N° " + counter.ToString() + " " + file.Name.ToString());
         }

         _ = txtReplaceThis.Focus();
      }
   }
}
