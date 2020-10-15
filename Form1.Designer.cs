namespace cleartools
{
    partial class clearTools
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clearTools));
            this.selectPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelImg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.docBox = new System.Windows.Forms.CheckBox();
            this.docPath = new System.Windows.Forms.Button();
            this.labelDoc = new System.Windows.Forms.Label();
            this.videoBox = new System.Windows.Forms.CheckBox();
            this.videoPath = new System.Windows.Forms.Button();
            this.labelVideo = new System.Windows.Forms.Label();
            this.exeBox = new System.Windows.Forms.CheckBox();
            this.exePath = new System.Windows.Forms.Button();
            this.labelExe = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.CheckBox();
            this.updateBar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(291, 24);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(75, 23);
            this.selectPath.TabIndex = 1;
            this.selectPath.Text = "Выбрать";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Location = new System.Drawing.Point(372, 28);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(88, 15);
            this.labelImg.TabIndex = 3;
            this.labelImg.Text = "Выберите путь";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // docBox
            // 
            this.docBox.AutoSize = true;
            this.docBox.Location = new System.Drawing.Point(12, 68);
            this.docBox.Name = "docBox";
            this.docBox.Size = new System.Drawing.Size(89, 19);
            this.docBox.TabIndex = 7;
            this.docBox.Text = "Документы";
            this.docBox.UseVisualStyleBackColor = true;
            // 
            // docPath
            // 
            this.docPath.Location = new System.Drawing.Point(291, 64);
            this.docPath.Name = "docPath";
            this.docPath.Size = new System.Drawing.Size(75, 23);
            this.docPath.TabIndex = 1;
            this.docPath.Text = "Выбрать";
            this.docPath.UseVisualStyleBackColor = true;
            this.docPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Location = new System.Drawing.Point(372, 68);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(88, 15);
            this.labelDoc.TabIndex = 3;
            this.labelDoc.Text = "Выберите путь";
            // 
            // videoBox
            // 
            this.videoBox.AutoSize = true;
            this.videoBox.Location = new System.Drawing.Point(12, 108);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(59, 19);
            this.videoBox.TabIndex = 7;
            this.videoBox.Text = "Видео";
            this.videoBox.UseVisualStyleBackColor = true;
            // 
            // videoPath
            // 
            this.videoPath.Location = new System.Drawing.Point(291, 104);
            this.videoPath.Name = "videoPath";
            this.videoPath.Size = new System.Drawing.Size(75, 23);
            this.videoPath.TabIndex = 1;
            this.videoPath.Text = "Выбрать";
            this.videoPath.UseVisualStyleBackColor = true;
            this.videoPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Location = new System.Drawing.Point(372, 108);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(88, 15);
            this.labelVideo.TabIndex = 3;
            this.labelVideo.Text = "Выберите путь";
            // 
            // exeBox
            // 
            this.exeBox.AutoSize = true;
            this.exeBox.Location = new System.Drawing.Point(12, 148);
            this.exeBox.Name = "exeBox";
            this.exeBox.Size = new System.Drawing.Size(146, 19);
            this.exeBox.TabIndex = 7;
            this.exeBox.Text = "Исполняемые файлы";
            this.exeBox.UseVisualStyleBackColor = true;
            // 
            // exePath
            // 
            this.exePath.Location = new System.Drawing.Point(291, 144);
            this.exePath.Name = "exePath";
            this.exePath.Size = new System.Drawing.Size(75, 23);
            this.exePath.TabIndex = 1;
            this.exePath.Text = "Выбрать";
            this.exePath.UseVisualStyleBackColor = true;
            this.exePath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // labelExe
            // 
            this.labelExe.AutoSize = true;
            this.labelExe.Location = new System.Drawing.Point(372, 148);
            this.labelExe.Name = "labelExe";
            this.labelExe.Size = new System.Drawing.Size(88, 15);
            this.labelExe.TabIndex = 3;
            this.labelExe.Text = "Выберите путь";
            // 
            // imgBox
            // 
            this.imgBox.AutoSize = true;
            this.imgBox.Location = new System.Drawing.Point(12, 28);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(102, 19);
            this.imgBox.TabIndex = 7;
            this.imgBox.Text = "Изображение";
            this.imgBox.UseVisualStyleBackColor = true;
            // 
            // updateBar
            // 
            this.updateBar.AutoSize = true;
            this.updateBar.Location = new System.Drawing.Point(10, 288);
            this.updateBar.Name = "updateBar";
            this.updateBar.Size = new System.Drawing.Size(61, 15);
            this.updateBar.TabIndex = 8;
            this.updateBar.TabStop = true;
            this.updateBar.Text = "updateBar";
            this.updateBar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // clearTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 312);
            this.Controls.Add(this.updateBar);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.labelExe);
            this.Controls.Add(this.exePath);
            this.Controls.Add(this.exeBox);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.videoPath);
            this.Controls.Add(this.videoBox);
            this.Controls.Add(this.labelDoc);
            this.Controls.Add(this.docPath);
            this.Controls.Add(this.docBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clearTools";
            this.Text = "updateBar";
            this.Load += new System.EventHandler(this.clearTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label path_img;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.CheckBox docBox;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.CheckBox videoBox;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.CheckBox exeBox;
        private System.Windows.Forms.Button exePath;
        private System.Windows.Forms.Label labelExe;
        private System.Windows.Forms.CheckBox imgBox;
        public System.Windows.Forms.Button docPath;
        public System.Windows.Forms.Button videoPath;
        private System.Windows.Forms.LinkLabel updateBar;
    }
}

