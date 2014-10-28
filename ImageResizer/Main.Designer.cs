namespace ImageResizer
{
    partial class Main
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
            this.buttonChooseImagePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxImages = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.textBoxTargetImagePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChooseTargetImagePath = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChooseImagePath
            // 
            this.buttonChooseImagePath.Location = new System.Drawing.Point(12, 31);
            this.buttonChooseImagePath.Name = "buttonChooseImagePath";
            this.buttonChooseImagePath.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseImagePath.TabIndex = 0;
            this.buttonChooseImagePath.Text = "انتخاب";
            this.buttonChooseImagePath.UseVisualStyleBackColor = true;
            this.buttonChooseImagePath.Click += new System.EventHandler(this.buttonChooseImagePath_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "مسیر تصاویر:";
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImagePath.Location = new System.Drawing.Point(93, 33);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxImagePath.Size = new System.Drawing.Size(604, 21);
            this.textBoxImagePath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "تصاویر:";
            // 
            // checkedListBoxImages
            // 
            this.checkedListBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxImages.FormattingEnabled = true;
            this.checkedListBoxImages.Location = new System.Drawing.Point(12, 92);
            this.checkedListBoxImages.MultiColumn = true;
            this.checkedListBoxImages.Name = "checkedListBoxImages";
            this.checkedListBoxImages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBoxImages.Size = new System.Drawing.Size(757, 228);
            this.checkedListBoxImages.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "کیفیت:";
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200"});
            this.comboBoxResolution.Location = new System.Drawing.Point(605, 333);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxResolution.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResolution.TabIndex = 7;
            // 
            // textBoxTargetImagePath
            // 
            this.textBoxTargetImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTargetImagePath.Location = new System.Drawing.Point(93, 360);
            this.textBoxTargetImagePath.Name = "textBoxTargetImagePath";
            this.textBoxTargetImagePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTargetImagePath.Size = new System.Drawing.Size(566, 21);
            this.textBoxTargetImagePath.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "مسیر تصاویر خروجی:";
            // 
            // buttonChooseTargetImagePath
            // 
            this.buttonChooseTargetImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChooseTargetImagePath.Location = new System.Drawing.Point(12, 358);
            this.buttonChooseTargetImagePath.Name = "buttonChooseTargetImagePath";
            this.buttonChooseTargetImagePath.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseTargetImagePath.TabIndex = 8;
            this.buttonChooseTargetImagePath.Text = "انتخاب";
            this.buttonChooseTargetImagePath.UseVisualStyleBackColor = true;
            this.buttonChooseTargetImagePath.Click += new System.EventHandler(this.buttonChooseTargetImagePath_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Location = new System.Drawing.Point(12, 403);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "شروع";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(93, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(676, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 66);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "بارگذاری";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxTargetImagePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonChooseTargetImagePath);
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxImages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChooseImagePath);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Image Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.TextBox textBoxTargetImagePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChooseTargetImagePath;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonLoad;
    }
}

