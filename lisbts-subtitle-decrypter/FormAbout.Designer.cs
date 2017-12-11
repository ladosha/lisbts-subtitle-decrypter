namespace lisbts_subtitle_decrypter
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelPython = new System.Windows.Forms.LinkLabel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.linkLabelUpdates = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version: 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subtitle Decrypter lets you view, \r\nedit and export the subtitle files for \r\nBefo" +
    "re the Storm. It was inspired \r\nby flatz\'s";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelPython
            // 
            this.linkLabelPython.AutoSize = true;
            this.linkLabelPython.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelPython.Location = new System.Drawing.Point(181, 91);
            this.linkLabelPython.Name = "linkLabelPython";
            this.linkLabelPython.Size = new System.Drawing.Size(117, 13);
            this.linkLabelPython.TabIndex = 3;
            this.linkLabelPython.TabStop = true;
            this.linkLabelPython.Text = "python decrypter script.";
            this.linkLabelPython.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelPython.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPython_LinkClicked);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(184, 113);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(59, 25);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // linkLabelUpdates
            // 
            this.linkLabelUpdates.AutoSize = true;
            this.linkLabelUpdates.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.linkLabelUpdates.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelUpdates.Location = new System.Drawing.Point(215, 12);
            this.linkLabelUpdates.Name = "linkLabelUpdates";
            this.linkLabelUpdates.Size = new System.Drawing.Size(94, 13);
            this.linkLabelUpdates.TabIndex = 5;
            this.linkLabelUpdates.TabStop = true;
            this.linkLabelUpdates.Text = "Check for updates";
            this.linkLabelUpdates.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdates_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Made by ladosha";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 148);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelUpdates);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.linkLabelPython);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Subtitle Decrypter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelPython;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.LinkLabel linkLabelUpdates;
        private System.Windows.Forms.Label label3;
    }
}