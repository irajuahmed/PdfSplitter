namespace PdfSplitter
{
    partial class PDFSplitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFSplitter));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnBrowsedFile = new System.Windows.Forms.Button();
            this.btnSplitPdf = new System.Windows.Forms.Button();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnSelectedFilePath = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSplitType = new System.Windows.Forms.Label();
            this.radioButtonSelectedIntoOne = new System.Windows.Forms.RadioButton();
            this.radioButtonSinglePageSplit = new System.Windows.Forms.RadioButton();
            this.checkBoxGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFinalMessage = new System.Windows.Forms.TextBox();
            this.lblLastModifyDate = new System.Windows.Forms.Label();
            this.txtLastModifyDate = new System.Windows.Forms.TextBox();
            this.txtSelectedFileSize = new System.Windows.Forms.TextBox();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.lblSelectedFileSize = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblCreator = new System.Windows.Forms.Label();
            this.txtSelectedFileToatlPage = new System.Windows.Forms.TextBox();
            this.lblSelectedFileToatlPage = new System.Windows.Forms.Label();
            this.txtSelectedFileTitle = new System.Windows.Forms.TextBox();
            this.lblSelectedFileTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelCheckBoxContainer = new System.Windows.Forms.Panel();
            this.radioButtonOddPages = new System.Windows.Forms.RadioButton();
            this.radioButtonEvenPages = new System.Windows.Forms.RadioButton();
            this.txtSelectedFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelCheckBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(708, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 32);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse PDF";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBrowsedFile
            // 
            this.btnBrowsedFile.AllowDrop = true;
            this.btnBrowsedFile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBrowsedFile.Location = new System.Drawing.Point(8, 22);
            this.btnBrowsedFile.Name = "btnBrowsedFile";
            this.btnBrowsedFile.Size = new System.Drawing.Size(694, 32);
            this.btnBrowsedFile.TabIndex = 0;
            this.btnBrowsedFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowsedFile.UseVisualStyleBackColor = true;
            // 
            // btnSplitPdf
            // 
            this.btnSplitPdf.Enabled = false;
            this.btnSplitPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitPdf.Location = new System.Drawing.Point(19, 94);
            this.btnSplitPdf.Name = "btnSplitPdf";
            this.btnSplitPdf.Size = new System.Drawing.Size(374, 42);
            this.btnSplitPdf.TabIndex = 2;
            this.btnSplitPdf.Text = "Split";
            this.btnSplitPdf.UseVisualStyleBackColor = true;
            this.btnSplitPdf.Click += new System.EventHandler(this.btnSplitPdf_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Enabled = false;
            this.btnSaveLocation.Location = new System.Drawing.Point(288, 41);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(105, 42);
            this.btnSaveLocation.TabIndex = 4;
            this.btnSaveLocation.Text = "PDF Saving Path";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // btnSelectedFilePath
            // 
            this.btnSelectedFilePath.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSelectedFilePath.Location = new System.Drawing.Point(19, 41);
            this.btnSelectedFilePath.Name = "btnSelectedFilePath";
            this.btnSelectedFilePath.Size = new System.Drawing.Size(269, 42);
            this.btnSelectedFilePath.TabIndex = 3;
            this.btnSelectedFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectedFilePath.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 147);
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 42);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSelectedFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonEvenPages);
            this.groupBox1.Controls.Add(this.radioButtonOddPages);
            this.groupBox1.Controls.Add(this.panelCheckBoxContainer);
            this.groupBox1.Controls.Add(this.lblSplitType);
            this.groupBox1.Controls.Add(this.radioButtonSelectedIntoOne);
            this.groupBox1.Controls.Add(this.radioButtonSinglePageSplit);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblLastModifyDate);
            this.groupBox1.Controls.Add(this.txtLastModifyDate);
            this.groupBox1.Controls.Add(this.txtSelectedFileSize);
            this.groupBox1.Controls.Add(this.txtCreationDate);
            this.groupBox1.Controls.Add(this.lblSelectedFileSize);
            this.groupBox1.Controls.Add(this.lblCreationDate);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.btnBrowsedFile);
            this.groupBox1.Controls.Add(this.lblCreator);
            this.groupBox1.Controls.Add(this.txtSelectedFileToatlPage);
            this.groupBox1.Controls.Add(this.lblSelectedFileToatlPage);
            this.groupBox1.Controls.Add(this.txtSelectedFileTitle);
            this.groupBox1.Controls.Add(this.lblSelectedFileTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 722);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browse File";
            // 
            // lblSplitType
            // 
            this.lblSplitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplitType.Location = new System.Drawing.Point(8, 253);
            this.lblSplitType.Name = "lblSplitType";
            this.lblSplitType.Size = new System.Drawing.Size(83, 36);
            this.lblSplitType.TabIndex = 16;
            this.lblSplitType.Text = "Split Type";
            this.lblSplitType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonSelectedIntoOne
            // 
            this.radioButtonSelectedIntoOne.AutoSize = true;
            this.radioButtonSelectedIntoOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSelectedIntoOne.Location = new System.Drawing.Point(537, 263);
            this.radioButtonSelectedIntoOne.Name = "radioButtonSelectedIntoOne";
            this.radioButtonSelectedIntoOne.Size = new System.Drawing.Size(152, 17);
            this.radioButtonSelectedIntoOne.TabIndex = 15;
            this.radioButtonSelectedIntoOne.TabStop = true;
            this.radioButtonSelectedIntoOne.Text = "Selected Into One File";
            this.radioButtonSelectedIntoOne.UseVisualStyleBackColor = true;
            this.radioButtonSelectedIntoOne.CheckedChanged += new System.EventHandler(this.radioButtonSelectedIntoOne_CheckedChanged);
            // 
            // radioButtonSinglePageSplit
            // 
            this.radioButtonSinglePageSplit.AutoSize = true;
            this.radioButtonSinglePageSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSinglePageSplit.Location = new System.Drawing.Point(98, 263);
            this.radioButtonSinglePageSplit.Name = "radioButtonSinglePageSplit";
            this.radioButtonSinglePageSplit.Size = new System.Drawing.Size(126, 17);
            this.radioButtonSinglePageSplit.TabIndex = 14;
            this.radioButtonSinglePageSplit.TabStop = true;
            this.radioButtonSinglePageSplit.Text = "Each Single Page";
            this.radioButtonSinglePageSplit.UseVisualStyleBackColor = true;
            this.radioButtonSinglePageSplit.CheckedChanged += new System.EventHandler(this.radioButtonSinglePageSplit_CheckedChanged);
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.Location = new System.Drawing.Point(3, 5);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(810, 148);
            this.checkBoxGroup.TabIndex = 13;
            this.checkBoxGroup.TabStop = false;
            this.checkBoxGroup.Text = "Pages";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFinalMessage);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnSelectedFilePath);
            this.groupBox2.Controls.Add(this.btnSaveLocation);
            this.groupBox2.Controls.Add(this.btnSplitPdf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 213);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Saving Info";
            // 
            // txtFinalMessage
            // 
            this.txtFinalMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtFinalMessage.Enabled = false;
            this.txtFinalMessage.Location = new System.Drawing.Point(401, 43);
            this.txtFinalMessage.Multiline = true;
            this.txtFinalMessage.Name = "txtFinalMessage";
            this.txtFinalMessage.Size = new System.Drawing.Size(378, 146);
            this.txtFinalMessage.TabIndex = 6;
            // 
            // lblLastModifyDate
            // 
            this.lblLastModifyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastModifyDate.Location = new System.Drawing.Point(548, 209);
            this.lblLastModifyDate.Name = "lblLastModifyDate";
            this.lblLastModifyDate.Size = new System.Drawing.Size(106, 36);
            this.lblLastModifyDate.TabIndex = 11;
            this.lblLastModifyDate.Text = "Last Modify Date";
            this.lblLastModifyDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastModifyDate
            // 
            this.txtLastModifyDate.Location = new System.Drawing.Point(658, 209);
            this.txtLastModifyDate.Multiline = true;
            this.txtLastModifyDate.Name = "txtLastModifyDate";
            this.txtLastModifyDate.ReadOnly = true;
            this.txtLastModifyDate.Size = new System.Drawing.Size(155, 36);
            this.txtLastModifyDate.TabIndex = 9;
            // 
            // txtSelectedFileSize
            // 
            this.txtSelectedFileSize.Location = new System.Drawing.Point(98, 209);
            this.txtSelectedFileSize.Multiline = true;
            this.txtSelectedFileSize.Name = "txtSelectedFileSize";
            this.txtSelectedFileSize.ReadOnly = true;
            this.txtSelectedFileSize.Size = new System.Drawing.Size(178, 36);
            this.txtSelectedFileSize.TabIndex = 7;
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.Location = new System.Drawing.Point(366, 209);
            this.txtCreationDate.Multiline = true;
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(178, 36);
            this.txtCreationDate.TabIndex = 7;
            // 
            // lblSelectedFileSize
            // 
            this.lblSelectedFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFileSize.Location = new System.Drawing.Point(8, 209);
            this.lblSelectedFileSize.Name = "lblSelectedFileSize";
            this.lblSelectedFileSize.Size = new System.Drawing.Size(83, 36);
            this.lblSelectedFileSize.TabIndex = 6;
            this.lblSelectedFileSize.Text = "File Size";
            this.lblSelectedFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(280, 209);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(83, 36);
            this.lblCreationDate.TabIndex = 6;
            this.lblCreationDate.Text = "Create Date";
            this.lblCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(98, 162);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(474, 36);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(4, 161);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(58, 36);
            this.lblCreator.TabIndex = 4;
            this.lblCreator.Text = "Author";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSelectedFileToatlPage
            // 
            this.txtSelectedFileToatlPage.Location = new System.Drawing.Point(656, 161);
            this.txtSelectedFileToatlPage.Multiline = true;
            this.txtSelectedFileToatlPage.Name = "txtSelectedFileToatlPage";
            this.txtSelectedFileToatlPage.ReadOnly = true;
            this.txtSelectedFileToatlPage.Size = new System.Drawing.Size(157, 36);
            this.txtSelectedFileToatlPage.TabIndex = 3;
            // 
            // lblSelectedFileToatlPage
            // 
            this.lblSelectedFileToatlPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFileToatlPage.Location = new System.Drawing.Point(570, 161);
            this.lblSelectedFileToatlPage.Name = "lblSelectedFileToatlPage";
            this.lblSelectedFileToatlPage.Size = new System.Drawing.Size(87, 36);
            this.lblSelectedFileToatlPage.TabIndex = 2;
            this.lblSelectedFileToatlPage.Text = "Total Page";
            this.lblSelectedFileToatlPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSelectedFileTitle
            // 
            this.txtSelectedFileTitle.CausesValidation = false;
            this.txtSelectedFileTitle.Location = new System.Drawing.Point(98, 117);
            this.txtSelectedFileTitle.Multiline = true;
            this.txtSelectedFileTitle.Name = "txtSelectedFileTitle";
            this.txtSelectedFileTitle.ReadOnly = true;
            this.txtSelectedFileTitle.Size = new System.Drawing.Size(715, 36);
            this.txtSelectedFileTitle.TabIndex = 1;
            // 
            // lblSelectedFileTitle
            // 
            this.lblSelectedFileTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFileTitle.Location = new System.Drawing.Point(7, 117);
            this.lblSelectedFileTitle.Name = "lblSelectedFileTitle";
            this.lblSelectedFileTitle.Size = new System.Drawing.Size(58, 36);
            this.lblSelectedFileTitle.TabIndex = 0;
            this.lblSelectedFileTitle.Text = "File Title";
            this.lblSelectedFileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCheckBoxContainer
            // 
            this.panelCheckBoxContainer.AutoScroll = true;
            this.panelCheckBoxContainer.Controls.Add(this.checkBoxGroup);
            this.panelCheckBoxContainer.Location = new System.Drawing.Point(9, 331);
            this.panelCheckBoxContainer.Name = "panelCheckBoxContainer";
            this.panelCheckBoxContainer.Size = new System.Drawing.Size(816, 159);
            this.panelCheckBoxContainer.TabIndex = 17;
            // 
            // radioButtonOddPages
            // 
            this.radioButtonOddPages.AutoSize = true;
            this.radioButtonOddPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOddPages.Location = new System.Drawing.Point(249, 263);
            this.radioButtonOddPages.Name = "radioButtonOddPages";
            this.radioButtonOddPages.Size = new System.Drawing.Size(116, 17);
            this.radioButtonOddPages.TabIndex = 18;
            this.radioButtonOddPages.TabStop = true;
            this.radioButtonOddPages.Text = "Only Odd Pages";
            this.radioButtonOddPages.UseVisualStyleBackColor = true;
            this.radioButtonOddPages.CheckedChanged += new System.EventHandler(this.radioButtonOddPages_CheckedChanged);
            // 
            // radioButtonEvenPages
            // 
            this.radioButtonEvenPages.AutoSize = true;
            this.radioButtonEvenPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEvenPages.Location = new System.Drawing.Point(390, 263);
            this.radioButtonEvenPages.Name = "radioButtonEvenPages";
            this.radioButtonEvenPages.Size = new System.Drawing.Size(122, 17);
            this.radioButtonEvenPages.TabIndex = 19;
            this.radioButtonEvenPages.TabStop = true;
            this.radioButtonEvenPages.Text = "Only Even Pages";
            this.radioButtonEvenPages.UseVisualStyleBackColor = true;
            this.radioButtonEvenPages.CheckedChanged += new System.EventHandler(this.radioButtonEvenPages_CheckedChanged);
            // 
            // txtSelectedFileName
            // 
            this.txtSelectedFileName.CausesValidation = false;
            this.txtSelectedFileName.Location = new System.Drawing.Point(98, 64);
            this.txtSelectedFileName.Multiline = true;
            this.txtSelectedFileName.Name = "txtSelectedFileName";
            this.txtSelectedFileName.ReadOnly = true;
            this.txtSelectedFileName.Size = new System.Drawing.Size(715, 36);
            this.txtSelectedFileName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "File Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PDFSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 761);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PDFSplitter";
            this.Text = "PDF Splitter";
            this.Load += new System.EventHandler(this.PDFSplitter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelCheckBoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnBrowsedFile;
        private System.Windows.Forms.Button btnSplitPdf;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Button btnSelectedFilePath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtSelectedFileTitle;
        private System.Windows.Forms.Label lblSelectedFileTitle;
        private System.Windows.Forms.TextBox txtSelectedFileToatlPage;
        private System.Windows.Forms.Label lblSelectedFileToatlPage;
        private System.Windows.Forms.TextBox txtCreationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.TextBox txtLastModifyDate;
        private System.Windows.Forms.Label lblLastModifyDate;
        private System.Windows.Forms.TextBox txtSelectedFileSize;
        private System.Windows.Forms.Label lblSelectedFileSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFinalMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox checkBoxGroup;
        private System.Windows.Forms.Label lblSplitType;
        private System.Windows.Forms.RadioButton radioButtonSelectedIntoOne;
        private System.Windows.Forms.RadioButton radioButtonSinglePageSplit;
        private System.Windows.Forms.Panel panelCheckBoxContainer;
        private System.Windows.Forms.RadioButton radioButtonEvenPages;
        private System.Windows.Forms.RadioButton radioButtonOddPages;
        private System.Windows.Forms.TextBox txtSelectedFileName;
        private System.Windows.Forms.Label label1;
    }
}

