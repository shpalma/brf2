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

      #region var section
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
      #endregion

      /// <summary>
      /// reset values from folder and file forms
      /// </summary>
      private void ResetFolderAndFiles()
      {
         chkbFilesDocs.Checked = false;
         chkbFilesZipped.Checked = false;
         chkbFilesAudio.Checked = false;
         chkbFilesVideo.Checked = false;
         chkbFilesData.Checked = false;
         chkbFilesDisk.Checked = false;
         chkbFilesExe.Checked = false;
         chkbFilesImg.Checked = false;
         chkbFilesTxt.Checked = false;
         chkbFilesAll.Checked = false;
         chkbFilesOther.Checked = false;
         chksubfolders.Checked = false;

         globFolder = string.Empty;
         lblFolderSelected.Text = "[...]";
         lvFilesFolders.Items.Clear();

      }

      /// <summary>
      /// reset values from what and where forms
      /// </summary>
      private void resetWhatandWhere()
      {
         
         txtReplaceThis.Text = string.Empty;
         txtReplaceForThis.Text = string.Empty;

         rbjustremove.Checked = false;
         rbregexWhatAndWhere.Checked = false;

         chkbFilesRegex.Checked = false;
         chkOpenFE.Checked = false;

         lvFinalPrev.Clear();

      }

      private void frmMain_Load(object sender, EventArgs e)
      {
         _ = txtbFileTypes.Focus();
      }

      /// <summary>
      /// Enable the option to enter manually what type of files to read
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
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

      /// <summary>
      /// Display a preview: of how the files going to be once finished the process
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnPreview_Click(object sender, EventArgs e)
      {
         int counter = 0;
         string finalName = string.Empty;
         string filename = string.Empty;
         string whatToFind = string.Empty;

         lvFinalPrev.Items.Clear();
         lvFinalPrev.Scrollable = true;
         lvFinalPrev.View = View.Details;
         lvFinalPrev.HeaderStyle = ColumnHeaderStyle.None;

         // get file list from supported file types selected
         foreach (var supportedFile in Directory.GetFiles(globFolder, "*.*", SearchOptionUserType).Where(s => supportedFiletype.Contains(Path.GetExtension(s).ToLower())))
         {
            counter += 1;
            filename = string.Empty;
            finalName = string.Empty;

            filename = System.IO.Path.GetFileName(supportedFile).ToLower();
            whatToFind = txtReplaceThis.Text.ToLower();

            //finalName = getBetween(filename, whatToFind, )


         }

         if (counter >= 1)
         {
            lvFinalPrev.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
         }

         SaveLogToFile("", "Component.Testing.CRUD", "Previsualizando", "uno:asdasd;dos:dfgdfgdfg;tres:dfgdfgd");

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
         string filename = string.Empty;

         try
         {
            // look for files
            foreach (var supportedFile in Directory.GetFiles(globFolder, "*.*", SearchOptionUserType).Where(s => supportedFiletype.Contains(Path.GetExtension(s).ToLower())))
            {
               if (supportedFile.ToLower().Contains(txtReplaceThis.Text.ToLower()))
               {
                  counter += 1;
                  filename = string.Empty;
                  finalName = string.Empty;

                  filename = System.IO.Path.GetFileName(supportedFile);
                  statusStrip.Text = "...getting supported files.";

                  finalName = filename.ToLower().Replace(txtReplaceThis.Text.ToLower(), txtReplaceForThis.Text.ToLower());
                  statusStrip.Text = "...getting file name.";

                  Console.WriteLine("File Name : {0}", finalName);

                  // rename (move) file!!!
                  string originalFileName = string.Empty;
                  string newFileName = string.Empty;

                  // determine path and file name: original
                  originalFileName = globFolder + backslash + filename;
                  // determine path and file name: new
                  newFileName = globFolder + backslash + finalName;

                  // exist file?
                  if (File.Exists(originalFileName))
                  {
                     // jusp procces if the file has the same name
                     if (originalFileName != newFileName)
                     {
                        File.Move(originalFileName, newFileName);
                        statusStrip.Text = "...renaming file.";
                     }
                  }
               }               
            }

            // do it open file explorer?
            if (chkOpenFE.Checked)
            {
               // open folder in file explorer once the proccess it's done
               Process.Start(globFolder);               
            }

            MessageBox.Show("The process renamed " + counter.ToString() + " files!" + vbCrl + "...Everything was like a globe!", "Success: files renamed", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
         catch (IOException ioEx)
         {
            // exception for Directory.GetFiles and File.move objects
            Console.WriteLine(ioEx.Message);
            MessageBox.Show("Error on renaming files: " + vbCrl + ioEx.Message.ToString(), "File system Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         catch (Win32Exception w32Exce)
         {
            // exception for Process.Start
            Console.WriteLine(w32Exce.Message);
            MessageBox.Show("Error to open File Explorer: " + vbCrl + w32Exce.Message.ToString(), "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         catch (Exception ex)
         {
            // all other type of exceptions
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
         ResetFolderAndFiles();
      }

      private void btnResetWhatTo_Click(object sender, EventArgs e)
      {
         resetWhatandWhere();
      }

      private void btnResetAll_Click(object sender, EventArgs e)
      {
         ResetFolderAndFiles();
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

         supportedFiletype = string.Empty;

         #region What type of files must be included?
         if (chkbFilesDocs.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeOffice + ", " + filetypeOfficex;
            else
               supportedFiletype += ", " + filetypeOffice + ", " + filetypeOfficex;

         if (chkbFilesZipped.Checked)
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

         if (chkbFilesData.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeData; // 
            else
               supportedFiletype += ", " + filetypeVideo;

         if (chkbFilesDisk.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeDisk; // 
            else
               supportedFiletype += ", " + filetypeDisk;

         if (chkbFilesExe.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype += filetypeExecutable; // 
            else
               supportedFiletype += ", " + filetypeExecutable;

         if (chkbFilesImg.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeImage;
            else
               supportedFiletype += ", " + filetypeImage;

         if (chkbFilesTxt.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeText;
            else
               supportedFiletype += ", " + filetypeText;

         if (chkbFilesAll.Checked)
            if (string.IsNullOrEmpty(supportedFiletype))
               supportedFiletype = filetypeEverythin;
            else
               supportedFiletype += ", " + filetypeEverythin;
         #endregion

         #region evaluate if there's some selected, related to file type
         // check if have any file type to read
         if (string.IsNullOrEmpty(supportedFiletype))
         {
            MessageBox.Show("Select or Write some file type!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _ = chkbFilesDocs.Focus();
            return;
         }

         // This section: gathers information about what file types must look for
         if ((chkbFilesOther.Checked == true) &&
              (txtbFileTypes.ReadOnly == false) &&
              (String.IsNullOrEmpty(txtbFileTypes.Text)))
         {
            MessageBox.Show("Write some file type!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _ = txtbFileTypes.Focus();
            return;
         }
         #endregion

         // select folder to work
         if (fbdFolder.ShowDialog() == DialogResult.OK)
         {
            lblFolderSelected.Text = fbdFolder.SelectedPath.ToString();
            globFolder = fbdFolder.SelectedPath.ToString();
         }
         else
            return;

         lvFilesFolders.Items.Clear();

         // set up folder 
         DirectoryInfo dir = new DirectoryInfo(globFolder);
         lvFilesFolders.Scrollable = true;
         lvFilesFolders.View = View.Details;
         lvFilesFolders.HeaderStyle = ColumnHeaderStyle.None;

         // get file list from supported file types selected
         foreach (var supportedFile in Directory.GetFiles(globFolder, "*.*", SearchOptionUserType).Where(s => supportedFiletype.Contains(Path.GetExtension(s).ToLower())))
         {
            counter += 1;
            Console.WriteLine("File Name : {0}", System.IO.Path.GetFileName(supportedFile));
            lvFilesFolders.Items.Add(System.IO.Path.GetFileName(supportedFile));
         }

         if (counter <= 0)
         {
            MessageBox.Show("No supported files found!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _ = txtbFileTypes.Focus();
            return;
         }
         else
         {
            lblFolderSelected.Text += " (" + counter.ToString() + " files found)";
            lvFilesFolders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            _ = txtReplaceThis.Focus();
         }

         SaveLogToFile("", "NONE", "Acción: Determina carpeta y archivos a buscar.", "param 01: 12345;param 2: 3456456;param 3: 5675675;");
      }

      private void lblwtr_Click(object sender, EventArgs e)
      {

      }

      private void chkbFilesAll_CheckedChanged(object sender, EventArgs e)
      {
         if (chkbFilesAll.Checked)
         {
            chkbFilesDocs.Checked = false;
            chkbFilesZipped.Checked = false;
            chkbFilesAudio.Checked = false;
            chkbFilesVideo.Checked = false;
            chkbFilesData.Checked = false;
            chkbFilesDisk.Checked = false;
            chkbFilesExe.Checked = false;
            chkbFilesImg.Checked = false;
            chkbFilesTxt.Checked = false;
            //chkbFilesAll.Checked = false;
            chkbFilesOther.Checked = false;
         }
      }

      private void toolStripStatusLabel1_Click(object sender, EventArgs e)
      {

      }

      private void chkbFilesDocs_MouseHover(object sender, EventArgs e)
      {
         statusStrip.Text = "docs!";
      }

      private void chkbFilesDocs_MouseLeave(object sender, EventArgs e)
      {
         statusStrip.Text = string.Empty;
      }

      private void rdbReplaceThis_CheckedChanged(object sender, EventArgs e)
      {
         if (rdbReplaceThis.Checked) {
            txtReplaceThis.Enabled = true;
            txtReplaceForThis.Enabled = true;

            rbregexWhatAndWhere.Checked = false;
            rbjustremove.Checked = false;

            txtReplaceThis.Focus();

          }
         else {
            txtReplaceThis.Enabled = false;
            txtReplaceForThis.Enabled = false;
         }
      }

      private void rbregexWhatAndWhere_CheckedChanged(object sender, EventArgs e)
      {
         if (rbregexWhatAndWhere.Checked)
         {
            rdbReplaceThis.Checked = false;
            rbjustremove.Checked = false;

            txtbRegexWAndW.ReadOnly = false;
            rbregexWhatAndWhere.Focus();
         }
         else
         {
            txtbRegexWAndW.Text = string.Empty;
            txtbRegexWAndW.ReadOnly = true;
         }

      }

      private void rbjustremove_CheckedChanged(object sender, EventArgs e)
      {
         if (rbjustremove.Checked)
         {

            rdbReplaceThis.Checked = false;
            rbregexWhatAndWhere.Checked = false;

            txtJustDropIt.Enabled = true;
            txtJustDropIt.Focus();
         }
         else
         {
            txtJustDropIt.Enabled = false;
         }
      }

      
      /// <summary>
      /// 
      /// </summary>
      /// <param name="strSource"></param>
      /// <param name="strStart"></param>
      /// <param name="strEnd"></param>
      /// <returns></returns>
      public static string getBetween(string strSource, string strStart, string strEnd)
      {
         //from Stackoverflow
         // https://stackoverflow.com/questions/10709821/find-text-in-string-with-c-sharp
         if (strSource.Contains(strStart) && strSource.Contains(strEnd))
         {
            int Start, End;
            Start = strSource.IndexOf(strStart, 0) + strStart.Length;
            End = strSource.IndexOf(strEnd, Start);
            return strSource.Substring(Start, End - Start);
         }

         return "";
      }

      /// <summary>
      /// Save log to file
      /// </summary>
      /// <param name="pathAndFileLog">path and file name log</param>
      /// <param name="componentName">Componente name used (Send "NONE" to avoid this parameter)</param>
      /// <param name="isAction">What is doing this action (Describe)</param>
      /// <param name="thisParams">List of what to print with semicolon separator. (param1:value1;param2:value2...)</param>
      public void SaveLogToFile(string pathAndFileLog, string componentName, string isAction, string thisParams)
      {
         System.Text.StringBuilder sb = new System.Text.StringBuilder();
         string[] splitedParams;
         string printToFile = "";
         int counter = 0;

         printToFile += "\r\n";
         printToFile += "\r\n";
         printToFile = DateTime.Now.ToString("yyyyMMddhhmmss") + " ********************************************";
         printToFile += "\r\n";
         
         if (componentName != "NONE" )
         {
            printToFile += DateTime.Now.ToString("yyyyMMddhhmmss") + " * " + componentName;
            printToFile += "\r\n";
         }

         printToFile += DateTime.Now.ToString("yyyyMMddhhmmss") + " ********************************************";
         printToFile += "\r\n";
         printToFile += DateTime.Now.ToString("yyyyMMddhhmmss") + " * " + isAction;
         printToFile += "\r\n";
         printToFile += DateTime.Now.ToString("yyyyMMddhhmmss") + " * " + "Parameters: ";
         printToFile += "\r\n";

         splitedParams = thisParams.Split(';');

         foreach (string valpar in splitedParams)
         {
            counter += 1;
            printToFile += DateTime.Now.ToString("yyyyMMddhhmmss") + " * " + valpar;
            printToFile += "\r\n";
         }

         if (string.IsNullOrEmpty(pathAndFileLog))
         {
            
            FileInfo fileInfo = new FileInfo("c:\\skidata\\logs\\");

            if (!fileInfo.Exists)
               Directory.CreateDirectory(fileInfo.Directory.FullName);
            
            pathAndFileLog += "c:\\skidata\\logs\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            sb.Append(printToFile);
            File.AppendAllText(pathAndFileLog, sb.ToString());
         }
         else
         { 
            File.AppendAllText(pathAndFileLog, printToFile + Environment.NewLine);
         }

         sb.Clear();
      }
   }
}
