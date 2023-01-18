
namespace brf
{
   partial class frmMain
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.gbFiles = new System.Windows.Forms.GroupBox();
         this.lblFolderSelected = new System.Windows.Forms.Label();
         this.chkbFilesRegex = new System.Windows.Forms.CheckBox();
         this.txtRegex = new System.Windows.Forms.TextBox();
         this.chkbFilesExe = new System.Windows.Forms.CheckBox();
         this.chkbFilesData = new System.Windows.Forms.CheckBox();
         this.chkbFilesDisk = new System.Windows.Forms.CheckBox();
         this.chkbFilesZipped = new System.Windows.Forms.CheckBox();
         this.btnSelectFolder = new System.Windows.Forms.Button();
         this.chkbFilesTxt = new System.Windows.Forms.CheckBox();
         this.chksubfolders = new System.Windows.Forms.CheckBox();
         this.btnResetFileFolder = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.txtbFileTypes = new System.Windows.Forms.TextBox();
         this.chkbFilesOther = new System.Windows.Forms.CheckBox();
         this.chkbFilesDocs = new System.Windows.Forms.CheckBox();
         this.chkbFilesAudio = new System.Windows.Forms.CheckBox();
         this.chkbFilesVideo = new System.Windows.Forms.CheckBox();
         this.chkbFilesImg = new System.Windows.Forms.CheckBox();
         this.chkbFilesAll = new System.Windows.Forms.CheckBox();
         this.lblfilefilters = new System.Windows.Forms.Label();
         this.lblFolder = new System.Windows.Forms.Label();
         this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
         this.gbWhattoReplace = new System.Windows.Forms.GroupBox();
         this.rbregexWhatAndWhere = new System.Windows.Forms.RadioButton();
         this.txtbRegexWAndW = new System.Windows.Forms.TextBox();
         this.btnPreview = new System.Windows.Forms.Button();
         this.btnResetWhatTo = new System.Windows.Forms.Button();
         this.rbjustremove = new System.Windows.Forms.RadioButton();
         this.txtReplaceForThis = new System.Windows.Forms.TextBox();
         this.lblwtrf = new System.Windows.Forms.Label();
         this.txtReplaceThis = new System.Windows.Forms.TextBox();
         this.grpbpreviewFileFolders = new System.Windows.Forms.GroupBox();
         this.lvFilesFolders = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.grpbFinalpreview = new System.Windows.Forms.GroupBox();
         this.chkOpenFE = new System.Windows.Forms.CheckBox();
         this.btnResetAll = new System.Windows.Forms.Button();
         this.btnSubmit = new System.Windows.Forms.Button();
         this.lvFinalPrev = new System.Windows.Forms.ListView();
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.toolStrip = new System.Windows.Forms.ToolStripStatusLabel();
         this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
         this.rdbReplaceThis = new System.Windows.Forms.RadioButton();
         this.txtJustDropIt = new System.Windows.Forms.TextBox();
         this.gbFiles.SuspendLayout();
         this.gbWhattoReplace.SuspendLayout();
         this.grpbpreviewFileFolders.SuspendLayout();
         this.grpbFinalpreview.SuspendLayout();
         this.statusStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbFiles
         // 
         this.gbFiles.Controls.Add(this.lblFolderSelected);
         this.gbFiles.Controls.Add(this.chkbFilesRegex);
         this.gbFiles.Controls.Add(this.txtRegex);
         this.gbFiles.Controls.Add(this.chkbFilesExe);
         this.gbFiles.Controls.Add(this.chkbFilesData);
         this.gbFiles.Controls.Add(this.chkbFilesDisk);
         this.gbFiles.Controls.Add(this.chkbFilesZipped);
         this.gbFiles.Controls.Add(this.btnSelectFolder);
         this.gbFiles.Controls.Add(this.chkbFilesTxt);
         this.gbFiles.Controls.Add(this.chksubfolders);
         this.gbFiles.Controls.Add(this.btnResetFileFolder);
         this.gbFiles.Controls.Add(this.label2);
         this.gbFiles.Controls.Add(this.txtbFileTypes);
         this.gbFiles.Controls.Add(this.chkbFilesOther);
         this.gbFiles.Controls.Add(this.chkbFilesDocs);
         this.gbFiles.Controls.Add(this.chkbFilesAudio);
         this.gbFiles.Controls.Add(this.chkbFilesVideo);
         this.gbFiles.Controls.Add(this.chkbFilesImg);
         this.gbFiles.Controls.Add(this.chkbFilesAll);
         this.gbFiles.Controls.Add(this.lblfilefilters);
         this.gbFiles.Controls.Add(this.lblFolder);
         this.gbFiles.Location = new System.Drawing.Point(12, 12);
         this.gbFiles.Name = "gbFiles";
         this.gbFiles.Size = new System.Drawing.Size(603, 144);
         this.gbFiles.TabIndex = 0;
         this.gbFiles.TabStop = false;
         this.gbFiles.Text = "Select folder and define file type(s)";
         // 
         // lblFolderSelected
         // 
         this.lblFolderSelected.AutoSize = true;
         this.lblFolderSelected.Location = new System.Drawing.Point(74, 124);
         this.lblFolderSelected.Name = "lblFolderSelected";
         this.lblFolderSelected.Size = new System.Drawing.Size(22, 13);
         this.lblFolderSelected.TabIndex = 2;
         this.lblFolderSelected.Text = "[...]";
         // 
         // chkbFilesRegex
         // 
         this.chkbFilesRegex.AutoSize = true;
         this.chkbFilesRegex.Enabled = false;
         this.chkbFilesRegex.Location = new System.Drawing.Point(200, 85);
         this.chkbFilesRegex.Name = "chkbFilesRegex";
         this.chkbFilesRegex.Size = new System.Drawing.Size(57, 17);
         this.chkbFilesRegex.TabIndex = 70;
         this.chkbFilesRegex.Text = "Regex";
         this.chkbFilesRegex.UseVisualStyleBackColor = true;
         // 
         // txtRegex
         // 
         this.txtRegex.Enabled = false;
         this.txtRegex.Location = new System.Drawing.Point(360, 83);
         this.txtRegex.Name = "txtRegex";
         this.txtRegex.ReadOnly = true;
         this.txtRegex.Size = new System.Drawing.Size(203, 20);
         this.txtRegex.TabIndex = 75;
         // 
         // chkbFilesExe
         // 
         this.chkbFilesExe.AutoSize = true;
         this.chkbFilesExe.Location = new System.Drawing.Point(77, 43);
         this.chkbFilesExe.Name = "chkbFilesExe";
         this.chkbFilesExe.Size = new System.Drawing.Size(79, 17);
         this.chkbFilesExe.TabIndex = 35;
         this.chkbFilesExe.Text = "Executable";
         this.chkbFilesExe.UseVisualStyleBackColor = true;
         // 
         // chkbFilesData
         // 
         this.chkbFilesData.AutoSize = true;
         this.chkbFilesData.Location = new System.Drawing.Point(440, 20);
         this.chkbFilesData.Name = "chkbFilesData";
         this.chkbFilesData.Size = new System.Drawing.Size(49, 17);
         this.chkbFilesData.TabIndex = 25;
         this.chkbFilesData.Text = "Data";
         this.chkbFilesData.UseVisualStyleBackColor = true;
         // 
         // chkbFilesDisk
         // 
         this.chkbFilesDisk.AutoSize = true;
         this.chkbFilesDisk.Location = new System.Drawing.Point(516, 20);
         this.chkbFilesDisk.Name = "chkbFilesDisk";
         this.chkbFilesDisk.Size = new System.Drawing.Size(47, 17);
         this.chkbFilesDisk.TabIndex = 30;
         this.chkbFilesDisk.Text = "Disk";
         this.chkbFilesDisk.UseVisualStyleBackColor = true;
         // 
         // chkbFilesZipped
         // 
         this.chkbFilesZipped.AutoSize = true;
         this.chkbFilesZipped.Location = new System.Drawing.Point(200, 20);
         this.chkbFilesZipped.Name = "chkbFilesZipped";
         this.chkbFilesZipped.Size = new System.Drawing.Size(84, 17);
         this.chkbFilesZipped.TabIndex = 10;
         this.chkbFilesZipped.Text = "Compressed";
         this.chkbFilesZipped.UseVisualStyleBackColor = true;
         // 
         // btnSelectFolder
         // 
         this.btnSelectFolder.Location = new System.Drawing.Point(77, 98);
         this.btnSelectFolder.Name = "btnSelectFolder";
         this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
         this.btnSelectFolder.TabIndex = 90;
         this.btnSelectFolder.Text = "Select folder";
         this.btnSelectFolder.UseVisualStyleBackColor = true;
         this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
         // 
         // chkbFilesTxt
         // 
         this.chkbFilesTxt.AutoSize = true;
         this.chkbFilesTxt.Location = new System.Drawing.Point(290, 43);
         this.chkbFilesTxt.Name = "chkbFilesTxt";
         this.chkbFilesTxt.Size = new System.Drawing.Size(47, 17);
         this.chkbFilesTxt.TabIndex = 45;
         this.chkbFilesTxt.Text = "Text";
         this.chkbFilesTxt.UseVisualStyleBackColor = true;
         // 
         // chksubfolders
         // 
         this.chksubfolders.AutoSize = true;
         this.chksubfolders.Location = new System.Drawing.Point(200, 104);
         this.chksubfolders.Name = "chksubfolders";
         this.chksubfolders.Size = new System.Drawing.Size(82, 17);
         this.chksubfolders.TabIndex = 85;
         this.chksubfolders.Text = "Subfolders?";
         this.chksubfolders.UseVisualStyleBackColor = true;
         this.chksubfolders.CheckedChanged += new System.EventHandler(this.chksubfolders_CheckedChanged);
         // 
         // btnResetFileFolder
         // 
         this.btnResetFileFolder.Location = new System.Drawing.Point(513, 109);
         this.btnResetFileFolder.Name = "btnResetFileFolder";
         this.btnResetFileFolder.Size = new System.Drawing.Size(75, 23);
         this.btnResetFileFolder.TabIndex = 95;
         this.btnResetFileFolder.Text = "Reset this";
         this.btnResetFileFolder.UseVisualStyleBackColor = true;
         this.btnResetFileFolder.Click += new System.EventHandler(this.btnResetFileFolder_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(357, 43);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(180, 13);
         this.label2.TabIndex = 50;
         this.label2.Text = "(separated with comma: *.pdf, *. psd)";
         // 
         // txtbFileTypes
         // 
         this.txtbFileTypes.Location = new System.Drawing.Point(360, 61);
         this.txtbFileTypes.Name = "txtbFileTypes";
         this.txtbFileTypes.ReadOnly = true;
         this.txtbFileTypes.Size = new System.Drawing.Size(203, 20);
         this.txtbFileTypes.TabIndex = 65;
         // 
         // chkbFilesOther
         // 
         this.chkbFilesOther.AutoSize = true;
         this.chkbFilesOther.Location = new System.Drawing.Point(200, 63);
         this.chkbFilesOther.Name = "chkbFilesOther";
         this.chkbFilesOther.Size = new System.Drawing.Size(147, 17);
         this.chkbFilesOther.TabIndex = 60;
         this.chkbFilesOther.Text = "add other/more extension";
         this.chkbFilesOther.UseVisualStyleBackColor = true;
         this.chkbFilesOther.CheckedChanged += new System.EventHandler(this.chkbFilesOther_CheckedChanged);
         // 
         // chkbFilesDocs
         // 
         this.chkbFilesDocs.AutoSize = true;
         this.chkbFilesDocs.Location = new System.Drawing.Point(77, 20);
         this.chkbFilesDocs.Name = "chkbFilesDocs";
         this.chkbFilesDocs.Size = new System.Drawing.Size(117, 17);
         this.chkbFilesDocs.TabIndex = 5;
         this.chkbFilesDocs.Text = "Office (Documents)";
         this.chkbFilesDocs.UseVisualStyleBackColor = true;
         this.chkbFilesDocs.MouseLeave += new System.EventHandler(this.chkbFilesDocs_MouseLeave);
         this.chkbFilesDocs.MouseHover += new System.EventHandler(this.chkbFilesDocs_MouseHover);
         // 
         // chkbFilesAudio
         // 
         this.chkbFilesAudio.AutoSize = true;
         this.chkbFilesAudio.Location = new System.Drawing.Point(290, 20);
         this.chkbFilesAudio.Name = "chkbFilesAudio";
         this.chkbFilesAudio.Size = new System.Drawing.Size(53, 17);
         this.chkbFilesAudio.TabIndex = 15;
         this.chkbFilesAudio.Text = "Audio";
         this.chkbFilesAudio.UseVisualStyleBackColor = true;
         // 
         // chkbFilesVideo
         // 
         this.chkbFilesVideo.AutoSize = true;
         this.chkbFilesVideo.Location = new System.Drawing.Point(360, 20);
         this.chkbFilesVideo.Name = "chkbFilesVideo";
         this.chkbFilesVideo.Size = new System.Drawing.Size(53, 17);
         this.chkbFilesVideo.TabIndex = 20;
         this.chkbFilesVideo.Text = "Video";
         this.chkbFilesVideo.UseVisualStyleBackColor = true;
         // 
         // chkbFilesImg
         // 
         this.chkbFilesImg.AutoSize = true;
         this.chkbFilesImg.Location = new System.Drawing.Point(200, 43);
         this.chkbFilesImg.Name = "chkbFilesImg";
         this.chkbFilesImg.Size = new System.Drawing.Size(55, 17);
         this.chkbFilesImg.TabIndex = 40;
         this.chkbFilesImg.Text = "Image";
         this.chkbFilesImg.UseVisualStyleBackColor = true;
         // 
         // chkbFilesAll
         // 
         this.chkbFilesAll.AutoSize = true;
         this.chkbFilesAll.Location = new System.Drawing.Point(77, 66);
         this.chkbFilesAll.Name = "chkbFilesAll";
         this.chkbFilesAll.Size = new System.Drawing.Size(99, 17);
         this.chkbFilesAll.TabIndex = 55;
         this.chkbFilesAll.Text = "Everything! (*.*)";
         this.chkbFilesAll.UseVisualStyleBackColor = true;
         this.chkbFilesAll.CheckedChanged += new System.EventHandler(this.chkbFilesAll_CheckedChanged);
         // 
         // lblfilefilters
         // 
         this.lblfilefilters.AutoSize = true;
         this.lblfilefilters.Location = new System.Drawing.Point(7, 20);
         this.lblfilefilters.Name = "lblfilefilters";
         this.lblfilefilters.Size = new System.Drawing.Size(56, 13);
         this.lblfilefilters.TabIndex = 4;
         this.lblfilefilters.Text = "File filters: ";
         // 
         // lblFolder
         // 
         this.lblFolder.AutoSize = true;
         this.lblFolder.Location = new System.Drawing.Point(6, 103);
         this.lblFolder.Name = "lblFolder";
         this.lblFolder.Size = new System.Drawing.Size(72, 13);
         this.lblFolder.TabIndex = 0;
         this.lblFolder.Text = "Select folder: ";
         // 
         // gbWhattoReplace
         // 
         this.gbWhattoReplace.Controls.Add(this.txtJustDropIt);
         this.gbWhattoReplace.Controls.Add(this.rdbReplaceThis);
         this.gbWhattoReplace.Controls.Add(this.rbregexWhatAndWhere);
         this.gbWhattoReplace.Controls.Add(this.txtbRegexWAndW);
         this.gbWhattoReplace.Controls.Add(this.btnPreview);
         this.gbWhattoReplace.Controls.Add(this.btnResetWhatTo);
         this.gbWhattoReplace.Controls.Add(this.rbjustremove);
         this.gbWhattoReplace.Controls.Add(this.txtReplaceForThis);
         this.gbWhattoReplace.Controls.Add(this.lblwtrf);
         this.gbWhattoReplace.Controls.Add(this.txtReplaceThis);
         this.gbWhattoReplace.Location = new System.Drawing.Point(9, 279);
         this.gbWhattoReplace.Name = "gbWhattoReplace";
         this.gbWhattoReplace.Size = new System.Drawing.Size(603, 89);
         this.gbWhattoReplace.TabIndex = 1;
         this.gbWhattoReplace.TabStop = false;
         this.gbWhattoReplace.Text = "What and (but not less important) where to replace it.";
         // 
         // rbregexWhatAndWhere
         // 
         this.rbregexWhatAndWhere.AutoSize = true;
         this.rbregexWhatAndWhere.Enabled = false;
         this.rbregexWhatAndWhere.Location = new System.Drawing.Point(204, 22);
         this.rbregexWhatAndWhere.Name = "rbregexWhatAndWhere";
         this.rbregexWhatAndWhere.Size = new System.Drawing.Size(56, 17);
         this.rbregexWhatAndWhere.TabIndex = 123;
         this.rbregexWhatAndWhere.TabStop = true;
         this.rbregexWhatAndWhere.Text = "Regex";
         this.rbregexWhatAndWhere.UseVisualStyleBackColor = true;
         this.rbregexWhatAndWhere.CheckedChanged += new System.EventHandler(this.rbregexWhatAndWhere_CheckedChanged);
         // 
         // txtbRegexWAndW
         // 
         this.txtbRegexWAndW.Location = new System.Drawing.Point(293, 20);
         this.txtbRegexWAndW.Name = "txtbRegexWAndW";
         this.txtbRegexWAndW.ReadOnly = true;
         this.txtbRegexWAndW.Size = new System.Drawing.Size(81, 20);
         this.txtbRegexWAndW.TabIndex = 122;
         // 
         // btnPreview
         // 
         this.btnPreview.Location = new System.Drawing.Point(516, 13);
         this.btnPreview.Name = "btnPreview";
         this.btnPreview.Size = new System.Drawing.Size(75, 23);
         this.btnPreview.TabIndex = 115;
         this.btnPreview.Text = "Preview";
         this.btnPreview.UseVisualStyleBackColor = true;
         this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
         // 
         // btnResetWhatTo
         // 
         this.btnResetWhatTo.Location = new System.Drawing.Point(516, 60);
         this.btnResetWhatTo.Name = "btnResetWhatTo";
         this.btnResetWhatTo.Size = new System.Drawing.Size(75, 23);
         this.btnResetWhatTo.TabIndex = 120;
         this.btnResetWhatTo.Text = "Reset this";
         this.btnResetWhatTo.UseVisualStyleBackColor = true;
         this.btnResetWhatTo.Click += new System.EventHandler(this.btnResetWhatTo_Click);
         // 
         // rbjustremove
         // 
         this.rbjustremove.AutoSize = true;
         this.rbjustremove.Location = new System.Drawing.Point(203, 44);
         this.rbjustremove.Name = "rbjustremove";
         this.rbjustremove.Size = new System.Drawing.Size(79, 17);
         this.rbjustremove.TabIndex = 110;
         this.rbjustremove.TabStop = true;
         this.rbjustremove.Text = "Just drop it!";
         this.rbjustremove.UseVisualStyleBackColor = true;
         this.rbjustremove.CheckedChanged += new System.EventHandler(this.rbjustremove_CheckedChanged);
         // 
         // txtReplaceForThis
         // 
         this.txtReplaceForThis.Enabled = false;
         this.txtReplaceForThis.Location = new System.Drawing.Point(102, 41);
         this.txtReplaceForThis.Name = "txtReplaceForThis";
         this.txtReplaceForThis.Size = new System.Drawing.Size(69, 20);
         this.txtReplaceForThis.TabIndex = 105;
         // 
         // lblwtrf
         // 
         this.lblwtrf.AutoSize = true;
         this.lblwtrf.Location = new System.Drawing.Point(46, 40);
         this.lblwtrf.Name = "lblwtrf";
         this.lblwtrf.Size = new System.Drawing.Size(50, 13);
         this.lblwtrf.TabIndex = 2;
         this.lblwtrf.Text = "...for this:";
         // 
         // txtReplaceThis
         // 
         this.txtReplaceThis.Enabled = false;
         this.txtReplaceThis.Location = new System.Drawing.Point(102, 19);
         this.txtReplaceThis.Name = "txtReplaceThis";
         this.txtReplaceThis.Size = new System.Drawing.Size(69, 20);
         this.txtReplaceThis.TabIndex = 100;
         // 
         // grpbpreviewFileFolders
         // 
         this.grpbpreviewFileFolders.Controls.Add(this.lvFilesFolders);
         this.grpbpreviewFileFolders.Location = new System.Drawing.Point(12, 162);
         this.grpbpreviewFileFolders.Name = "grpbpreviewFileFolders";
         this.grpbpreviewFileFolders.Size = new System.Drawing.Size(603, 111);
         this.grpbpreviewFileFolders.TabIndex = 2;
         this.grpbpreviewFileFolders.TabStop = false;
         this.grpbpreviewFileFolders.Text = "Preview selected folder and files";
         // 
         // lvFilesFolders
         // 
         this.lvFilesFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
         this.lvFilesFolders.FullRowSelect = true;
         this.lvFilesFolders.GridLines = true;
         this.lvFilesFolders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
         this.lvFilesFolders.HideSelection = false;
         this.lvFilesFolders.Location = new System.Drawing.Point(7, 19);
         this.lvFilesFolders.MultiSelect = false;
         this.lvFilesFolders.Name = "lvFilesFolders";
         this.lvFilesFolders.Size = new System.Drawing.Size(585, 82);
         this.lvFilesFolders.TabIndex = 0;
         this.lvFilesFolders.UseCompatibleStateImageBehavior = false;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "";
         this.columnHeader1.Width = 200;
         // 
         // grpbFinalpreview
         // 
         this.grpbFinalpreview.Controls.Add(this.chkOpenFE);
         this.grpbFinalpreview.Controls.Add(this.btnResetAll);
         this.grpbFinalpreview.Controls.Add(this.btnSubmit);
         this.grpbFinalpreview.Controls.Add(this.lvFinalPrev);
         this.grpbFinalpreview.Location = new System.Drawing.Point(10, 374);
         this.grpbFinalpreview.Name = "grpbFinalpreview";
         this.grpbFinalpreview.Size = new System.Drawing.Size(602, 139);
         this.grpbFinalpreview.TabIndex = 3;
         this.grpbFinalpreview.TabStop = false;
         this.grpbFinalpreview.Text = "How it gonna look? (...this is the final preview)";
         // 
         // chkOpenFE
         // 
         this.chkOpenFE.AutoSize = true;
         this.chkOpenFE.Location = new System.Drawing.Point(6, 107);
         this.chkOpenFE.Name = "chkOpenFE";
         this.chkOpenFE.Size = new System.Drawing.Size(171, 17);
         this.chkOpenFE.TabIndex = 125;
         this.chkOpenFE.Text = "Open File Explorer when done!";
         this.chkOpenFE.UseVisualStyleBackColor = true;
         // 
         // btnResetAll
         // 
         this.btnResetAll.Location = new System.Drawing.Point(478, 107);
         this.btnResetAll.Name = "btnResetAll";
         this.btnResetAll.Size = new System.Drawing.Size(113, 23);
         this.btnResetAll.TabIndex = 135;
         this.btnResetAll.Text = "Reset everything!";
         this.btnResetAll.UseVisualStyleBackColor = true;
         this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
         // 
         // btnSubmit
         // 
         this.btnSubmit.Location = new System.Drawing.Point(397, 107);
         this.btnSubmit.Name = "btnSubmit";
         this.btnSubmit.Size = new System.Drawing.Size(75, 23);
         this.btnSubmit.TabIndex = 130;
         this.btnSubmit.Text = "Apply?";
         this.btnSubmit.UseVisualStyleBackColor = true;
         this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
         // 
         // lvFinalPrev
         // 
         this.lvFinalPrev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
         this.lvFinalPrev.FullRowSelect = true;
         this.lvFinalPrev.GridLines = true;
         this.lvFinalPrev.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
         this.lvFinalPrev.HideSelection = false;
         this.lvFinalPrev.Location = new System.Drawing.Point(6, 19);
         this.lvFinalPrev.MultiSelect = false;
         this.lvFinalPrev.Name = "lvFinalPrev";
         this.lvFinalPrev.Size = new System.Drawing.Size(585, 82);
         this.lvFinalPrev.TabIndex = 0;
         this.lvFinalPrev.UseCompatibleStateImageBehavior = false;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "";
         this.columnHeader2.Width = 200;
         // 
         // statusStrip
         // 
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip,
            this.ProgressBar});
         this.statusStrip.Location = new System.Drawing.Point(0, 519);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Size = new System.Drawing.Size(624, 22);
         this.statusStrip.TabIndex = 4;
         this.statusStrip.Text = "ssForm";
         // 
         // toolStrip
         // 
         this.toolStrip.Name = "toolStrip";
         this.toolStrip.Size = new System.Drawing.Size(0, 17);
         // 
         // ProgressBar
         // 
         this.ProgressBar.Name = "ProgressBar";
         this.ProgressBar.Size = new System.Drawing.Size(100, 16);
         // 
         // rdbReplaceThis
         // 
         this.rdbReplaceThis.AutoSize = true;
         this.rdbReplaceThis.Location = new System.Drawing.Point(13, 20);
         this.rdbReplaceThis.Name = "rdbReplaceThis";
         this.rdbReplaceThis.Size = new System.Drawing.Size(84, 17);
         this.rdbReplaceThis.TabIndex = 124;
         this.rdbReplaceThis.TabStop = true;
         this.rdbReplaceThis.Text = "Replace this";
         this.rdbReplaceThis.UseVisualStyleBackColor = true;
         this.rdbReplaceThis.CheckedChanged += new System.EventHandler(this.rdbReplaceThis_CheckedChanged);
         // 
         // txtJustDropIt
         // 
         this.txtJustDropIt.Enabled = false;
         this.txtJustDropIt.Location = new System.Drawing.Point(293, 43);
         this.txtJustDropIt.Name = "txtJustDropIt";
         this.txtJustDropIt.Size = new System.Drawing.Size(81, 20);
         this.txtJustDropIt.TabIndex = 125;
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(624, 541);
         this.Controls.Add(this.statusStrip);
         this.Controls.Add(this.grpbFinalpreview);
         this.Controls.Add(this.grpbpreviewFileFolders);
         this.Controls.Add(this.gbWhattoReplace);
         this.Controls.Add(this.gbFiles);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmMain";
         this.ShowIcon = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "BRF (Bulk rename files!)";
         this.Load += new System.EventHandler(this.frmMain_Load);
         this.gbFiles.ResumeLayout(false);
         this.gbFiles.PerformLayout();
         this.gbWhattoReplace.ResumeLayout(false);
         this.gbWhattoReplace.PerformLayout();
         this.grpbpreviewFileFolders.ResumeLayout(false);
         this.grpbFinalpreview.ResumeLayout(false);
         this.grpbFinalpreview.PerformLayout();
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox gbFiles;
      private System.Windows.Forms.Label lblFolder;
      private System.Windows.Forms.FolderBrowserDialog fbdFolder;
      private System.Windows.Forms.Label lblfilefilters;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtbFileTypes;
      private System.Windows.Forms.CheckBox chkbFilesOther;
      private System.Windows.Forms.CheckBox chkbFilesDocs;
      private System.Windows.Forms.CheckBox chkbFilesAudio;
      private System.Windows.Forms.CheckBox chkbFilesVideo;
      private System.Windows.Forms.CheckBox chkbFilesImg;
      private System.Windows.Forms.CheckBox chkbFilesAll;
      private System.Windows.Forms.GroupBox gbWhattoReplace;
      private System.Windows.Forms.GroupBox grpbpreviewFileFolders;
      private System.Windows.Forms.ListView lvFilesFolders;
      private System.Windows.Forms.RadioButton rbjustremove;
      private System.Windows.Forms.TextBox txtReplaceForThis;
      private System.Windows.Forms.Label lblwtrf;
      private System.Windows.Forms.TextBox txtReplaceThis;
      private System.Windows.Forms.Button btnResetFileFolder;
      private System.Windows.Forms.Button btnResetWhatTo;
      private System.Windows.Forms.GroupBox grpbFinalpreview;
      private System.Windows.Forms.Button btnSubmit;
      private System.Windows.Forms.ListView lvFinalPrev;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.Button btnPreview;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.Button btnResetAll;
      private System.Windows.Forms.TextBox txtRegex;
      private System.Windows.Forms.CheckBox chkOpenFE;
      private System.Windows.Forms.CheckBox chksubfolders;
      private System.Windows.Forms.CheckBox chkbFilesTxt;
      private System.Windows.Forms.Button btnSelectFolder;
      private System.Windows.Forms.CheckBox chkbFilesExe;
      private System.Windows.Forms.CheckBox chkbFilesData;
      private System.Windows.Forms.CheckBox chkbFilesDisk;
      private System.Windows.Forms.CheckBox chkbFilesZipped;
      private System.Windows.Forms.CheckBox chkbFilesRegex;
      private System.Windows.Forms.Label lblFolderSelected;
      private System.Windows.Forms.StatusStrip statusStrip;
      private System.Windows.Forms.RadioButton rbregexWhatAndWhere;
      private System.Windows.Forms.TextBox txtbRegexWAndW;
      private System.Windows.Forms.ToolStripStatusLabel toolStrip;
      private System.Windows.Forms.ToolStripProgressBar ProgressBar;
      private System.Windows.Forms.TextBox txtJustDropIt;
      private System.Windows.Forms.RadioButton rdbReplaceThis;
   }
}

