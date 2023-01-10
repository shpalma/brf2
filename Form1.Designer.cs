
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
         this.btnSelectFolder = new System.Windows.Forms.Button();
         this.chkbtext = new System.Windows.Forms.CheckBox();
         this.chksubfolders = new System.Windows.Forms.CheckBox();
         this.btnResetFileFolder = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.txtbFileTypes = new System.Windows.Forms.TextBox();
         this.chkbFilesOther = new System.Windows.Forms.CheckBox();
         this.chkbFilesDocs = new System.Windows.Forms.CheckBox();
         this.chkbFilesSound = new System.Windows.Forms.CheckBox();
         this.chkbFilesVideo = new System.Windows.Forms.CheckBox();
         this.chkbFilesImg = new System.Windows.Forms.CheckBox();
         this.chkbFilesAll = new System.Windows.Forms.CheckBox();
         this.lblfilefilters = new System.Windows.Forms.Label();
         this.txtbSelectedFolder = new System.Windows.Forms.TextBox();
         this.lblFolder = new System.Windows.Forms.Label();
         this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
         this.gbWhattoReplace = new System.Windows.Forms.GroupBox();
         this.lblregex = new System.Windows.Forms.Label();
         this.txtRegex = new System.Windows.Forms.TextBox();
         this.rbregex = new System.Windows.Forms.RadioButton();
         this.btnPreview = new System.Windows.Forms.Button();
         this.btnResetWhatTo = new System.Windows.Forms.Button();
         this.rbjustremove = new System.Windows.Forms.RadioButton();
         this.txtReplaceForThis = new System.Windows.Forms.TextBox();
         this.lblwtrf = new System.Windows.Forms.Label();
         this.txtReplaceThis = new System.Windows.Forms.TextBox();
         this.lblwtr = new System.Windows.Forms.Label();
         this.grpbpreviewFileFolders = new System.Windows.Forms.GroupBox();
         this.lvFilesFolders = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.grpbFinalpreview = new System.Windows.Forms.GroupBox();
         this.chkOpenFE = new System.Windows.Forms.CheckBox();
         this.btnResetAll = new System.Windows.Forms.Button();
         this.btnSubmit = new System.Windows.Forms.Button();
         this.lvFinalPrev = new System.Windows.Forms.ListView();
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.gbFiles.SuspendLayout();
         this.gbWhattoReplace.SuspendLayout();
         this.grpbpreviewFileFolders.SuspendLayout();
         this.grpbFinalpreview.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbFiles
         // 
         this.gbFiles.Controls.Add(this.btnSelectFolder);
         this.gbFiles.Controls.Add(this.chkbtext);
         this.gbFiles.Controls.Add(this.chksubfolders);
         this.gbFiles.Controls.Add(this.btnResetFileFolder);
         this.gbFiles.Controls.Add(this.label2);
         this.gbFiles.Controls.Add(this.txtbFileTypes);
         this.gbFiles.Controls.Add(this.chkbFilesOther);
         this.gbFiles.Controls.Add(this.chkbFilesDocs);
         this.gbFiles.Controls.Add(this.chkbFilesSound);
         this.gbFiles.Controls.Add(this.chkbFilesVideo);
         this.gbFiles.Controls.Add(this.chkbFilesImg);
         this.gbFiles.Controls.Add(this.chkbFilesAll);
         this.gbFiles.Controls.Add(this.lblfilefilters);
         this.gbFiles.Controls.Add(this.txtbSelectedFolder);
         this.gbFiles.Controls.Add(this.lblFolder);
         this.gbFiles.Location = new System.Drawing.Point(12, 12);
         this.gbFiles.Name = "gbFiles";
         this.gbFiles.Size = new System.Drawing.Size(603, 100);
         this.gbFiles.TabIndex = 0;
         this.gbFiles.TabStop = false;
         this.gbFiles.Text = "Select folder and define file type(s)";
         // 
         // btnSelectFolder
         // 
         this.btnSelectFolder.Location = new System.Drawing.Point(338, 60);
         this.btnSelectFolder.Name = "btnSelectFolder";
         this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
         this.btnSelectFolder.TabIndex = 19;
         this.btnSelectFolder.Text = "Select folder";
         this.btnSelectFolder.UseVisualStyleBackColor = true;
         this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
         // 
         // chkbtext
         // 
         this.chkbtext.AutoSize = true;
         this.chkbtext.Location = new System.Drawing.Point(110, 34);
         this.chkbtext.Name = "chkbtext";
         this.chkbtext.Size = new System.Drawing.Size(47, 17);
         this.chkbtext.TabIndex = 18;
         this.chkbtext.Text = "Text";
         this.chkbtext.UseVisualStyleBackColor = true;
         // 
         // chksubfolders
         // 
         this.chksubfolders.AutoSize = true;
         this.chksubfolders.Location = new System.Drawing.Point(254, 62);
         this.chksubfolders.Name = "chksubfolders";
         this.chksubfolders.Size = new System.Drawing.Size(85, 17);
         this.chksubfolders.TabIndex = 17;
         this.chksubfolders.Text = "Sub folders?";
         this.chksubfolders.UseVisualStyleBackColor = true;
         this.chksubfolders.CheckedChanged += new System.EventHandler(this.chksubfolders_CheckedChanged);
         // 
         // btnResetFileFolder
         // 
         this.btnResetFileFolder.Location = new System.Drawing.Point(516, 66);
         this.btnResetFileFolder.Name = "btnResetFileFolder";
         this.btnResetFileFolder.Size = new System.Drawing.Size(75, 23);
         this.btnResetFileFolder.TabIndex = 16;
         this.btnResetFileFolder.Text = "Reset this";
         this.btnResetFileFolder.UseVisualStyleBackColor = true;
         this.btnResetFileFolder.Click += new System.EventHandler(this.btnResetFileFolder_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(251, 39);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(215, 13);
         this.label2.TabIndex = 15;
         this.label2.Text = "separate with comma (sample: *.mp3, *.mp4)";
         // 
         // txtbFileTypes
         // 
         this.txtbFileTypes.Location = new System.Drawing.Point(478, 39);
         this.txtbFileTypes.Name = "txtbFileTypes";
         this.txtbFileTypes.ReadOnly = true;
         this.txtbFileTypes.Size = new System.Drawing.Size(113, 20);
         this.txtbFileTypes.TabIndex = 14;
         // 
         // chkbFilesOther
         // 
         this.chkbFilesOther.AutoSize = true;
         this.chkbFilesOther.Location = new System.Drawing.Point(478, 16);
         this.chkbFilesOther.Name = "chkbFilesOther";
         this.chkbFilesOther.Size = new System.Drawing.Size(119, 17);
         this.chkbFilesOther.TabIndex = 13;
         this.chkbFilesOther.Text = "add other extension";
         this.chkbFilesOther.UseVisualStyleBackColor = true;
         this.chkbFilesOther.CheckedChanged += new System.EventHandler(this.chkbFilesOther_CheckedChanged);
         // 
         // chkbFilesDocs
         // 
         this.chkbFilesDocs.AutoSize = true;
         this.chkbFilesDocs.Location = new System.Drawing.Point(110, 16);
         this.chkbFilesDocs.Name = "chkbFilesDocs";
         this.chkbFilesDocs.Size = new System.Drawing.Size(117, 17);
         this.chkbFilesDocs.TabIndex = 12;
         this.chkbFilesDocs.Text = "Office (Documents)";
         this.chkbFilesDocs.UseVisualStyleBackColor = true;
         // 
         // chkbFilesSound
         // 
         this.chkbFilesSound.AutoSize = true;
         this.chkbFilesSound.Location = new System.Drawing.Point(292, 16);
         this.chkbFilesSound.Name = "chkbFilesSound";
         this.chkbFilesSound.Size = new System.Drawing.Size(57, 17);
         this.chkbFilesSound.TabIndex = 11;
         this.chkbFilesSound.Text = "Sound";
         this.chkbFilesSound.UseVisualStyleBackColor = true;
         // 
         // chkbFilesVideo
         // 
         this.chkbFilesVideo.AutoSize = true;
         this.chkbFilesVideo.Location = new System.Drawing.Point(355, 16);
         this.chkbFilesVideo.Name = "chkbFilesVideo";
         this.chkbFilesVideo.Size = new System.Drawing.Size(53, 17);
         this.chkbFilesVideo.TabIndex = 10;
         this.chkbFilesVideo.Text = "Video";
         this.chkbFilesVideo.UseVisualStyleBackColor = true;
         // 
         // chkbFilesImg
         // 
         this.chkbFilesImg.AutoSize = true;
         this.chkbFilesImg.Location = new System.Drawing.Point(233, 16);
         this.chkbFilesImg.Name = "chkbFilesImg";
         this.chkbFilesImg.Size = new System.Drawing.Size(55, 17);
         this.chkbFilesImg.TabIndex = 9;
         this.chkbFilesImg.Text = "Image";
         this.chkbFilesImg.UseVisualStyleBackColor = true;
         // 
         // chkbFilesAll
         // 
         this.chkbFilesAll.AutoSize = true;
         this.chkbFilesAll.Location = new System.Drawing.Point(163, 35);
         this.chkbFilesAll.Name = "chkbFilesAll";
         this.chkbFilesAll.Size = new System.Drawing.Size(77, 17);
         this.chkbFilesAll.TabIndex = 8;
         this.chkbFilesAll.Text = "All of it (*.*)";
         this.chkbFilesAll.UseVisualStyleBackColor = true;
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
         // txtbSelectedFolder
         // 
         this.txtbSelectedFolder.Location = new System.Drawing.Point(110, 62);
         this.txtbSelectedFolder.Name = "txtbSelectedFolder";
         this.txtbSelectedFolder.Size = new System.Drawing.Size(137, 20);
         this.txtbSelectedFolder.TabIndex = 1;
         // 
         // lblFolder
         // 
         this.lblFolder.AutoSize = true;
         this.lblFolder.Location = new System.Drawing.Point(6, 64);
         this.lblFolder.Name = "lblFolder";
         this.lblFolder.Size = new System.Drawing.Size(72, 13);
         this.lblFolder.TabIndex = 0;
         this.lblFolder.Text = "Select folder: ";
         // 
         // gbWhattoReplace
         // 
         this.gbWhattoReplace.Controls.Add(this.lblregex);
         this.gbWhattoReplace.Controls.Add(this.txtRegex);
         this.gbWhattoReplace.Controls.Add(this.rbregex);
         this.gbWhattoReplace.Controls.Add(this.btnPreview);
         this.gbWhattoReplace.Controls.Add(this.btnResetWhatTo);
         this.gbWhattoReplace.Controls.Add(this.rbjustremove);
         this.gbWhattoReplace.Controls.Add(this.txtReplaceForThis);
         this.gbWhattoReplace.Controls.Add(this.lblwtrf);
         this.gbWhattoReplace.Controls.Add(this.txtReplaceThis);
         this.gbWhattoReplace.Controls.Add(this.lblwtr);
         this.gbWhattoReplace.Location = new System.Drawing.Point(12, 235);
         this.gbWhattoReplace.Name = "gbWhattoReplace";
         this.gbWhattoReplace.Size = new System.Drawing.Size(603, 87);
         this.gbWhattoReplace.TabIndex = 1;
         this.gbWhattoReplace.TabStop = false;
         this.gbWhattoReplace.Text = "What and (but not less important) where to replace it.";
         // 
         // lblregex
         // 
         this.lblregex.AutoSize = true;
         this.lblregex.Location = new System.Drawing.Point(179, 52);
         this.lblregex.Name = "lblregex";
         this.lblregex.Size = new System.Drawing.Size(41, 13);
         this.lblregex.TabIndex = 9;
         this.lblregex.Text = "Regex:";
         // 
         // txtRegex
         // 
         this.txtRegex.Location = new System.Drawing.Point(233, 51);
         this.txtRegex.Name = "txtRegex";
         this.txtRegex.Size = new System.Drawing.Size(180, 20);
         this.txtRegex.TabIndex = 8;
         // 
         // rbregex
         // 
         this.rbregex.AutoSize = true;
         this.rbregex.Enabled = false;
         this.rbregex.Location = new System.Drawing.Point(92, 51);
         this.rbregex.Name = "rbregex";
         this.rbregex.Size = new System.Drawing.Size(56, 17);
         this.rbregex.TabIndex = 7;
         this.rbregex.TabStop = true;
         this.rbregex.Text = "Regex";
         this.rbregex.UseVisualStyleBackColor = true;
         // 
         // btnPreview
         // 
         this.btnPreview.Location = new System.Drawing.Point(516, 16);
         this.btnPreview.Name = "btnPreview";
         this.btnPreview.Size = new System.Drawing.Size(75, 23);
         this.btnPreview.TabIndex = 6;
         this.btnPreview.Text = "Preview";
         this.btnPreview.UseVisualStyleBackColor = true;
         this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
         // 
         // btnResetWhatTo
         // 
         this.btnResetWhatTo.Location = new System.Drawing.Point(516, 49);
         this.btnResetWhatTo.Name = "btnResetWhatTo";
         this.btnResetWhatTo.Size = new System.Drawing.Size(75, 23);
         this.btnResetWhatTo.TabIndex = 5;
         this.btnResetWhatTo.Text = "Reset this";
         this.btnResetWhatTo.UseVisualStyleBackColor = true;
         this.btnResetWhatTo.Click += new System.EventHandler(this.btnResetWhatTo_Click);
         // 
         // rbjustremove
         // 
         this.rbjustremove.AutoSize = true;
         this.rbjustremove.Location = new System.Drawing.Point(320, 22);
         this.rbjustremove.Name = "rbjustremove";
         this.rbjustremove.Size = new System.Drawing.Size(93, 17);
         this.rbjustremove.TabIndex = 4;
         this.rbjustremove.TabStop = true;
         this.rbjustremove.Text = "Just remove it!";
         this.rbjustremove.UseVisualStyleBackColor = true;
         // 
         // txtReplaceForThis
         // 
         this.txtReplaceForThis.Location = new System.Drawing.Point(233, 19);
         this.txtReplaceForThis.Name = "txtReplaceForThis";
         this.txtReplaceForThis.Size = new System.Drawing.Size(69, 20);
         this.txtReplaceForThis.TabIndex = 3;
         // 
         // lblwtrf
         // 
         this.lblwtrf.AutoSize = true;
         this.lblwtrf.Location = new System.Drawing.Point(177, 27);
         this.lblwtrf.Name = "lblwtrf";
         this.lblwtrf.Size = new System.Drawing.Size(50, 13);
         this.lblwtrf.TabIndex = 2;
         this.lblwtrf.Text = "...for this:";
         // 
         // txtReplaceThis
         // 
         this.txtReplaceThis.Location = new System.Drawing.Point(92, 20);
         this.txtReplaceThis.Name = "txtReplaceThis";
         this.txtReplaceThis.Size = new System.Drawing.Size(69, 20);
         this.txtReplaceThis.TabIndex = 1;
         // 
         // lblwtr
         // 
         this.lblwtr.AutoSize = true;
         this.lblwtr.Location = new System.Drawing.Point(10, 27);
         this.lblwtr.Name = "lblwtr";
         this.lblwtr.Size = new System.Drawing.Size(76, 13);
         this.lblwtr.TabIndex = 0;
         this.lblwtr.Text = "Replace This: ";
         // 
         // grpbpreviewFileFolders
         // 
         this.grpbpreviewFileFolders.Controls.Add(this.lvFilesFolders);
         this.grpbpreviewFileFolders.Location = new System.Drawing.Point(12, 118);
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
         this.lvFilesFolders.HideSelection = false;
         this.lvFilesFolders.Location = new System.Drawing.Point(7, 20);
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
         this.grpbFinalpreview.Location = new System.Drawing.Point(12, 328);
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
         this.chkOpenFE.Size = new System.Drawing.Size(211, 17);
         this.chkOpenFE.TabIndex = 3;
         this.chkOpenFE.Text = "Open folder in File Explorer when done!";
         this.chkOpenFE.UseVisualStyleBackColor = true;
         // 
         // btnResetAll
         // 
         this.btnResetAll.Location = new System.Drawing.Point(478, 107);
         this.btnResetAll.Name = "btnResetAll";
         this.btnResetAll.Size = new System.Drawing.Size(113, 23);
         this.btnResetAll.TabIndex = 2;
         this.btnResetAll.Text = "Reset everything!";
         this.btnResetAll.UseVisualStyleBackColor = true;
         this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
         // 
         // btnSubmit
         // 
         this.btnSubmit.Location = new System.Drawing.Point(387, 107);
         this.btnSubmit.Name = "btnSubmit";
         this.btnSubmit.Size = new System.Drawing.Size(75, 23);
         this.btnSubmit.TabIndex = 1;
         this.btnSubmit.Text = "Apply?";
         this.btnSubmit.UseVisualStyleBackColor = true;
         this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
         // 
         // lvFinalPrev
         // 
         this.lvFinalPrev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
         this.lvFinalPrev.HideSelection = false;
         this.lvFinalPrev.Location = new System.Drawing.Point(6, 19);
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
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(624, 473);
         this.Controls.Add(this.grpbFinalpreview);
         this.Controls.Add(this.grpbpreviewFileFolders);
         this.Controls.Add(this.gbWhattoReplace);
         this.Controls.Add(this.gbFiles);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmMain";
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
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbFiles;
      private System.Windows.Forms.Label lblFolder;
      private System.Windows.Forms.TextBox txtbSelectedFolder;
      private System.Windows.Forms.FolderBrowserDialog fbdFolder;
      private System.Windows.Forms.Label lblfilefilters;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtbFileTypes;
      private System.Windows.Forms.CheckBox chkbFilesOther;
      private System.Windows.Forms.CheckBox chkbFilesDocs;
      private System.Windows.Forms.CheckBox chkbFilesSound;
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
      private System.Windows.Forms.Label lblwtr;
      private System.Windows.Forms.Button btnResetFileFolder;
      private System.Windows.Forms.Button btnResetWhatTo;
      private System.Windows.Forms.GroupBox grpbFinalpreview;
      private System.Windows.Forms.Button btnSubmit;
      private System.Windows.Forms.ListView lvFinalPrev;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.Button btnPreview;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.Button btnResetAll;
      private System.Windows.Forms.Label lblregex;
      private System.Windows.Forms.TextBox txtRegex;
      private System.Windows.Forms.RadioButton rbregex;
      private System.Windows.Forms.CheckBox chkOpenFE;
      private System.Windows.Forms.CheckBox chksubfolders;
      private System.Windows.Forms.CheckBox chkbtext;
      private System.Windows.Forms.Button btnSelectFolder;
   }
}

