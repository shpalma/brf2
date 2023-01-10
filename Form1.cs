using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
      public const string vbCrl = "\n";
      public const string backslash = "\\";
      // file type files supported
      public string filetypeOffice = ConfigurationManager.AppSettings["filetypeOffice"];
      public string filetypeOfficex = ConfigurationManager.AppSettings["filetypeOfficex"];
      public string filetypeCompressed = ConfigurationManager.AppSettings["filetypeCompressed"];
      public string filetypeAudio = ConfigurationManager.AppSettings["filetypeAudio"];
      public string filetypeVideo = ConfigurationManager.AppSettings["filetypeVideo"];
      public string filetypeData = ConfigurationManager.AppSettings["filetypeData"];
      public string filetypeDisk = ConfigurationManager.AppSettings["filetypeDisk"];
      public string filetypeExecutable = ConfigurationManager.AppSettings["filetypeExecutable"];
      public string filetypeImage = ConfigurationManager.AppSettings["filetypeImage"];
      public string filetypeText = ConfigurationManager.AppSettings["filetypeText"];
      public string filetypeEverythin = ConfigurationManager.AppSettings["filetypeEverythin"];
      public string supportedFiletype;

      /// <summary>
      /// reset values from folder and file forms
      /// </summary>
      private void resetFolderAndFiles()
      {
         chkbFilesDocs.Checked = false;
         chkbFilesImg.Checked = false;
         chkbFilesAudio.Checked = false;
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
         chkbRegex.Checked = false;
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
         txtbSelectedFolder.Text = string.Empty;

         // This section: gathers information about what file types must look for
         if ((chkbFilesOther.Checked == true) &&
              (txtbFileTypes.ReadOnly == false) &&
              (String.IsNullOrEmpty(txtbFileTypes.Text)))
         {
            MessageBox.Show("Write some file type!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _ = txtbFileTypes.Focus();
            return;
         }

         // select folder to work
         if (fbdFolder.ShowDialog() == DialogResult.OK)
         {
            txtbSelectedFolder.Text = fbdFolder.SelectedPath.ToString();
            globFolder = txtbSelectedFolder.Text;
         }

         supportedFiletype = string.Empty;
         // What type of files must be included?
         if (chkbFilesDocs.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeOffice + ", " + filetypeOfficex;
            else
               supportedFiletype += ", " + filetypeOffice + ", " + filetypeOfficex;

         if (chkbCompressed.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeCompressed; // 
            else
               supportedFiletype += ", " + filetypeCompressed;

         if (chkbFilesAudio.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeAudio; // 
            else
               supportedFiletype += ", " + filetypeAudio;

         if (chkbFilesVideo.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeVideo; // 
            else
               supportedFiletype += ", " + filetypeVideo;

         if (chkbData.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeData; // 
            else
               supportedFiletype += ", " + filetypeVideo;

         if (chkbDisk.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeDisk; // 
            else
               supportedFiletype += ", " + filetypeDisk;

         if (chbExecutable.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeExecutable; // 
            else
               supportedFiletype += ", " + filetypeExecutable;

         if (chkbFilesImg.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeImage;
            else
               supportedFiletype += ", " + filetypeImage;

         if (chkbtext.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeText;
            else
               supportedFiletype += ", " + filetypeText;

         if (chkbFilesAll.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeEverythin;
            else
               supportedFiletype += ", " + filetypeEverythin;

         // check if have any file type to read
         if (string.IsNullOrEmpty(supportedFiletype))
         {
            MessageBox.Show("Select or Write some file type!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _ = txtbFileTypes.Focus();
            return;
         }

         // set up folder 
         DirectoryInfo dir = new DirectoryInfo(globFolder);
         lvFilesFolders.Scrollable = true;
         lvFilesFolders.View = View.Details;
         lvFilesFolders.Items.Add("Folder: " + globFolder);
         lvFilesFolders.Items.Add("------------------------------");

         // get file list from supported file types selected
         foreach (string supportedFile in Directory.GetFiles(globFolder, "*.*", SearchOption.AllDirectories).Where(s => supportedFiletype.Contains(Path.GetExtension(s).ToLower())))
         {
            counter += 1;
            Console.WriteLine("File Name : {0}", System.IO.Path.GetFileName(supportedFile));
            lvFilesFolders.Items.Add("N° " + counter.ToString() + " " + System.IO.Path.GetFileName(supportedFile));
         }

         _ = txtReplaceThis.Focus();
      }

      private void lblwtr_Click(object sender, EventArgs e)
      {

      }

      private void chkbFilesAll_CheckedChanged(object sender, EventArgs e)
      {
         if (chkbFilesAll.Checked)
         {
            chkbFilesDocs.Checked = false;
            chkbCompressed.Checked = false;
            chkbFilesAudio.Checked = false;
            chkbFilesVideo.Checked = false;
            chkbData.Checked = false;
            chkbDisk.Checked = false;
            chbExecutable.Checked = false;
            chkbFilesImg.Checked = false;
            chkbtext.Checked = false;
            chkbFilesOther.Checked = false;
         }
      }
   }
}
