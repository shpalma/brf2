
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
         this.lblFolder = new System.Windows.Forms.Label();
         this.txtbSelectedFolder = new System.Windows.Forms.TextBox();
         this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
         this.lblfilefilters = new System.Windows.Forms.Label();
         this.chkbFilesAll = new System.Windows.Forms.CheckBox();
         this.chkbFilesImg = new System.Windows.Forms.CheckBox();
         this.chkbFilesVideo = new System.Windows.Forms.CheckBox();
         this.chkbFilesSound = new System.Windows.Forms.CheckBox();
         this.chkbFilesDocs = new System.Windows.Forms.CheckBox();
         this.chkbFilesOther = new System.Windows.Forms.CheckBox();
         this.txtbFileTypes = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.gbWhattoReplace = new System.Windows.Forms.GroupBox();
         this.grpbpreviewFileFolders = new System.Windows.Forms.GroupBox();
         this.lvFilesFolders = new System.Windows.Forms.ListView();
         this.pbFolder = new System.Windows.Forms.PictureBox();
         this.lblwtr = new System.Windows.Forms.Label();
         this.txtReplaceThis = new System.Windows.Forms.TextBox();
         this.lblwtrf = new System.Windows.Forms.Label();
         this.txtReplaceForThis = new System.Windows.Forms.TextBox();
         this.rbjustremove = new System.Windows.Forms.RadioButton();
         this.btnResetFileFolder = new System.Windows.Forms.Button();
         this.btnResetWhatTo = new System.Windows.Forms.Button();
         this.grpbFinalpreview = new System.Windows.Forms.GroupBox();
         this.lvFinalPrev = new System.Windows.Forms.ListView();
         this.btnSubmit = new System.Windows.Forms.Button();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.btnPreview = new System.Windows.Forms.Button();
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.gbFiles.SuspendLayout();
         this.gbWhattoReplace.SuspendLayout();
         this.grpbpreviewFileFolders.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbFolder)).BeginInit();
         this.grpbFinalpreview.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbFiles
         // 
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
         this.gbFiles.Controls.Add(this.pbFolder);
         this.gbFiles.Controls.Add(this.txtbSelectedFolder);
         this.gbFiles.Controls.Add(this.lblFolder);
         this.gbFiles.Location = new System.Drawing.Point(12, 12);
         this.gbFiles.Name = "gbFiles";
         this.gbFiles.Size = new System.Drawing.Size(603, 100);
         this.gbFiles.TabIndex = 0;
         this.gbFiles.TabStop = false;
         this.gbFiles.Text = "Files types and Folders";
         // 
         // lblFolder
         // 
         this.lblFolder.AutoSize = true;
         this.lblFolder.Location = new System.Drawing.Point(6, 69);
         this.lblFolder.Name = "lblFolder";
         this.lblFolder.Size = new System.Drawing.Size(72, 13);
         this.lblFolder.TabIndex = 0;
         this.lblFolder.Text = "Select folder: ";
         // 
         // txtbSelectedFolder
         // 
         this.txtbSelectedFolder.Location = new System.Drawing.Point(110, 69);
         this.txtbSelectedFolder.Name = "txtbSelectedFolder";
         this.txtbSelectedFolder.Size = new System.Drawing.Size(303, 20);
         this.txtbSelectedFolder.TabIndex = 1;
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
         // chkbFilesAll
         // 
         this.chkbFilesAll.AutoSize = true;
         this.chkbFilesAll.Location = new System.Drawing.Point(355, 16);
         this.chkbFilesAll.Name = "chkbFilesAll";
         this.chkbFilesAll.Size = new System.Drawing.Size(78, 17);
         this.chkbFilesAll.TabIndex = 8;
         this.chkbFilesAll.Text = "All files (*.*)";
         this.chkbFilesAll.UseVisualStyleBackColor = true;
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
         // chkbFilesVideo
         // 
         this.chkbFilesVideo.AutoSize = true;
         this.chkbFilesVideo.Location = new System.Drawing.Point(439, 16);
         this.chkbFilesVideo.Name = "chkbFilesVideo";
         this.chkbFilesVideo.Size = new System.Drawing.Size(53, 17);
         this.chkbFilesVideo.TabIndex = 10;
         this.chkbFilesVideo.Text = "Video";
         this.chkbFilesVideo.UseVisualStyleBackColor = true;
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
         // chkbFilesDocs
         // 
         this.chkbFilesDocs.AutoSize = true;
         this.chkbFilesDocs.Location = new System.Drawing.Point(110, 16);
         this.chkbFilesDocs.Name = "chkbFilesDocs";
         this.chkbFilesDocs.Size = new System.Drawing.Size(117, 17);
         this.chkbFilesDocs.TabIndex = 12;
         this.chkbFilesDocs.Text = "Documents (Office)";
         this.chkbFilesDocs.UseVisualStyleBackColor = true;
         // 
         // chkbFilesOther
         // 
         this.chkbFilesOther.AutoSize = true;
         this.chkbFilesOther.Location = new System.Drawing.Point(498, 16);
         this.chkbFilesOther.Name = "chkbFilesOther";
         this.chkbFilesOther.Size = new System.Drawing.Size(94, 17);
         this.chkbFilesOther.TabIndex = 13;
         this.chkbFilesOther.Text = "Other (specify)";
         this.chkbFilesOther.UseVisualStyleBackColor = true;
         this.chkbFilesOther.CheckedChanged += new System.EventHandler(this.chkbFilesOther_CheckedChanged);
         // 
         // txtbFileTypes
         // 
         this.txtbFileTypes.Location = new System.Drawing.Point(110, 39);
         this.txtbFileTypes.Name = "txtbFileTypes";
         this.txtbFileTypes.ReadOnly = true;
         this.txtbFileTypes.Size = new System.Drawing.Size(239, 20);
         this.txtbFileTypes.TabIndex = 14;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(7, 39);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(83, 13);
         this.label2.TabIndex = 15;
         this.label2.Text = "Other file types: ";
         // 
         // gbWhattoReplace
         // 
         this.gbWhattoReplace.Controls.Add(this.btnPreview);
         this.gbWhattoReplace.Controls.Add(this.btnResetWhatTo);
         this.gbWhattoReplace.Controls.Add(this.rbjustremove);
         this.gbWhattoReplace.Controls.Add(this.txtReplaceForThis);
         this.gbWhattoReplace.Controls.Add(this.lblwtrf);
         this.gbWhattoReplace.Controls.Add(this.txtReplaceThis);
         this.gbWhattoReplace.Controls.Add(this.lblwtr);
         this.gbWhattoReplace.Location = new System.Drawing.Point(12, 260);
         this.gbWhattoReplace.Name = "gbWhattoReplace";
         this.gbWhattoReplace.Size = new System.Drawing.Size(603, 99);
         this.gbWhattoReplace.TabIndex = 1;
         this.gbWhattoReplace.TabStop = false;
         this.gbWhattoReplace.Text = "What and where to replace it!?";
         // 
         // grpbpreviewFileFolders
         // 
         this.grpbpreviewFileFolders.Controls.Add(this.lvFilesFolders);
         this.grpbpreviewFileFolders.Location = new System.Drawing.Point(12, 118);
         this.grpbpreviewFileFolders.Name = "grpbpreviewFileFolders";
         this.grpbpreviewFileFolders.Size = new System.Drawing.Size(603, 136);
         this.grpbpreviewFileFolders.TabIndex = 2;
         this.grpbpreviewFileFolders.TabStop = false;
         this.grpbpreviewFileFolders.Text = "Preview selected files and folders";
         // 
         // lvFilesFolders
         // 
         this.lvFilesFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
         this.lvFilesFolders.HideSelection = false;
         this.lvFilesFolders.Location = new System.Drawing.Point(7, 20);
         this.lvFilesFolders.Name = "lvFilesFolders";
         this.lvFilesFolders.Size = new System.Drawing.Size(585, 110);
         this.lvFilesFolders.TabIndex = 0;
         this.lvFilesFolders.UseCompatibleStateImageBehavior = false;
         // 
         // pbFolder
         // 
         this.pbFolder.Image = global::brf.Properties.Resources.icons8_open_folder_kmg_design_flat_16;
         this.pbFolder.Location = new System.Drawing.Point(419, 69);
         this.pbFolder.Name = "pbFolder";
         this.pbFolder.Padding = new System.Windows.Forms.Padding(1);
         this.pbFolder.Size = new System.Drawing.Size(18, 18);
         this.pbFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pbFolder.TabIndex = 3;
         this.pbFolder.TabStop = false;
         this.pbFolder.Tag = "Open Folder";
         this.pbFolder.Click += new System.EventHandler(this.pbFolder_Click);
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
         // txtReplaceThis
         // 
         this.txtReplaceThis.Location = new System.Drawing.Point(92, 20);
         this.txtReplaceThis.Name = "txtReplaceThis";
         this.txtReplaceThis.Size = new System.Drawing.Size(135, 20);
         this.txtReplaceThis.TabIndex = 1;
         // 
         // lblwtrf
         // 
         this.lblwtrf.AutoSize = true;
         this.lblwtrf.Location = new System.Drawing.Point(261, 27);
         this.lblwtrf.Name = "lblwtrf";
         this.lblwtrf.Size = new System.Drawing.Size(50, 13);
         this.lblwtrf.TabIndex = 2;
         this.lblwtrf.Text = "...for this:";
         // 
         // txtReplaceForThis
         // 
         this.txtReplaceForThis.Location = new System.Drawing.Point(317, 20);
         this.txtReplaceForThis.Name = "txtReplaceForThis";
         this.txtReplaceForThis.Size = new System.Drawing.Size(135, 20);
         this.txtReplaceForThis.TabIndex = 3;
         // 
         // rbjustremove
         // 
         this.rbjustremove.AutoSize = true;
         this.rbjustremove.Location = new System.Drawing.Point(317, 55);
         this.rbjustremove.Name = "rbjustremove";
         this.rbjustremove.Size = new System.Drawing.Size(119, 17);
         this.rbjustremove.TabIndex = 4;
         this.rbjustremove.TabStop = true;
         this.rbjustremove.Text = "(Or... just remove it!)";
         this.rbjustremove.UseVisualStyleBackColor = true;
         // 
         // btnResetFileFolder
         // 
         this.btnResetFileFolder.Location = new System.Drawing.Point(498, 71);
         this.btnResetFileFolder.Name = "btnResetFileFolder";
         this.btnResetFileFolder.Size = new System.Drawing.Size(75, 23);
         this.btnResetFileFolder.TabIndex = 16;
         this.btnResetFileFolder.Text = "Reset this";
         this.btnResetFileFolder.UseVisualStyleBackColor = true;
         // 
         // btnResetWhatTo
         // 
         this.btnResetWhatTo.Location = new System.Drawing.Point(498, 52);
         this.btnResetWhatTo.Name = "btnResetWhatTo";
         this.btnResetWhatTo.Size = new System.Drawing.Size(75, 23);
         this.btnResetWhatTo.TabIndex = 5;
         this.btnResetWhatTo.Text = "Reset this";
         this.btnResetWhatTo.UseVisualStyleBackColor = true;
         // 
         // grpbFinalpreview
         // 
         this.grpbFinalpreview.Controls.Add(this.btnSubmit);
         this.grpbFinalpreview.Controls.Add(this.lvFinalPrev);
         this.grpbFinalpreview.Location = new System.Drawing.Point(13, 365);
         this.grpbFinalpreview.Name = "grpbFinalpreview";
         this.grpbFinalpreview.Size = new System.Drawing.Size(602, 132);
         this.grpbFinalpreview.TabIndex = 3;
         this.grpbFinalpreview.TabStop = false;
         this.grpbFinalpreview.Text = "Final Preview. Do you submit?";
         // 
         // lvFinalPrev
         // 
         this.lvFinalPrev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
         this.lvFinalPrev.HideSelection = false;
         this.lvFinalPrev.Location = new System.Drawing.Point(6, 19);
         this.lvFinalPrev.Name = "lvFinalPrev";
         this.lvFinalPrev.Size = new System.Drawing.Size(485, 106);
         this.lvFinalPrev.TabIndex = 0;
         this.lvFinalPrev.UseCompatibleStateImageBehavior = false;
         // 
         // btnSubmit
         // 
         this.btnSubmit.Location = new System.Drawing.Point(497, 93);
         this.btnSubmit.Name = "btnSubmit";
         this.btnSubmit.Size = new System.Drawing.Size(75, 23);
         this.btnSubmit.TabIndex = 1;
         this.btnSubmit.Text = "Apply?";
         this.btnSubmit.UseVisualStyleBackColor = true;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "";
         this.columnHeader1.Width = 200;
         // 
         // btnPreview
         // 
         this.btnPreview.Location = new System.Drawing.Point(498, 17);
         this.btnPreview.Name = "btnPreview";
         this.btnPreview.Size = new System.Drawing.Size(75, 23);
         this.btnPreview.TabIndex = 6;
         this.btnPreview.Text = "Preview";
         this.btnPreview.UseVisualStyleBackColor = true;
         this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
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
         this.ClientSize = new System.Drawing.Size(624, 509);
         this.Controls.Add(this.grpbFinalpreview);
         this.Controls.Add(this.grpbpreviewFileFolders);
         this.Controls.Add(this.gbWhattoReplace);
         this.Controls.Add(this.gbFiles);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "BRF";
         this.Load += new System.EventHandler(this.frmMain_Load);
         this.gbFiles.ResumeLayout(false);
         this.gbFiles.PerformLayout();
         this.gbWhattoReplace.ResumeLayout(false);
         this.gbWhattoReplace.PerformLayout();
         this.grpbpreviewFileFolders.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pbFolder)).EndInit();
         this.grpbFinalpreview.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbFiles;
      private System.Windows.Forms.Label lblFolder;
      private System.Windows.Forms.PictureBox pbFolder;
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
   }
}

