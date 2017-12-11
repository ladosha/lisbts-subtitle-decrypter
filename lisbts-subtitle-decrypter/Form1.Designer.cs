namespace lisbts_subtitle_decrypter
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInPath = new System.Windows.Forms.Label();
            this.textBoxInPath = new System.Windows.Forms.TextBox();
            this.buttonBrosweInput = new System.Windows.Forms.Button();
            this.buttonShowContent = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSaveEdits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonTxtUnix = new System.Windows.Forms.RadioButton();
            this.radioButtonTxtWin = new System.Windows.Forms.RadioButton();
            this.checkBoxEditMode = new System.Windows.Forms.CheckBox();
            this.radioButtonLSB = new System.Windows.Forms.RadioButton();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewSubtitles = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtitles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelInPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrosweInput, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowContent, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAbout, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSaveEdits, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewSubtitles, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelInPath
            // 
            this.labelInPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInPath.AutoSize = true;
            this.labelInPath.Location = new System.Drawing.Point(3, 0);
            this.labelInPath.Name = "labelInPath";
            this.labelInPath.Size = new System.Drawing.Size(54, 30);
            this.labelInPath.TabIndex = 0;
            this.labelInPath.Text = "Input file:";
            this.labelInPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxInPath
            // 
            this.textBoxInPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInPath.Location = new System.Drawing.Point(63, 5);
            this.textBoxInPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.textBoxInPath.Name = "textBoxInPath";
            this.textBoxInPath.Size = new System.Drawing.Size(568, 20);
            this.textBoxInPath.TabIndex = 2;
            this.textBoxInPath.TextChanged += new System.EventHandler(this.textBoxInPath_TextChanged);
            // 
            // buttonBrosweInput
            // 
            this.buttonBrosweInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrosweInput.Location = new System.Drawing.Point(637, 3);
            this.buttonBrosweInput.Name = "buttonBrosweInput";
            this.buttonBrosweInput.Size = new System.Drawing.Size(69, 24);
            this.buttonBrosweInput.TabIndex = 4;
            this.buttonBrosweInput.Text = "Browse";
            this.buttonBrosweInput.UseVisualStyleBackColor = true;
            this.buttonBrosweInput.Click += new System.EventHandler(this.buttonBrosweInput_Click);
            // 
            // buttonShowContent
            // 
            this.buttonShowContent.Location = new System.Drawing.Point(712, 3);
            this.buttonShowContent.Name = "buttonShowContent";
            this.buttonShowContent.Size = new System.Drawing.Size(94, 24);
            this.buttonShowContent.TabIndex = 6;
            this.buttonShowContent.Text = "Show Content";
            this.buttonShowContent.UseVisualStyleBackColor = true;
            this.buttonShowContent.Click += new System.EventHandler(this.buttonShowContent_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Location = new System.Drawing.Point(637, 33);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(69, 25);
            this.buttonAbout.TabIndex = 11;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSaveEdits
            // 
            this.buttonSaveEdits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveEdits.Location = new System.Drawing.Point(712, 33);
            this.buttonSaveEdits.Name = "buttonSaveEdits";
            this.buttonSaveEdits.Size = new System.Drawing.Size(94, 25);
            this.buttonSaveEdits.TabIndex = 12;
            this.buttonSaveEdits.Text = "Save";
            this.buttonSaveEdits.UseVisualStyleBackColor = true;
            this.buttonSaveEdits.Click += new System.EventHandler(this.buttonSaveEdits_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Save As:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonTxtUnix, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonTxtWin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxEditMode, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonLSB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelInfo, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 25);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // radioButtonTxtUnix
            // 
            this.radioButtonTxtUnix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTxtUnix.AutoSize = true;
            this.radioButtonTxtUnix.Location = new System.Drawing.Point(135, 3);
            this.radioButtonTxtUnix.Name = "radioButtonTxtUnix";
            this.radioButtonTxtUnix.Size = new System.Drawing.Size(76, 19);
            this.radioButtonTxtUnix.TabIndex = 11;
            this.radioButtonTxtUnix.TabStop = true;
            this.radioButtonTxtUnix.Text = "TXT (Unix)";
            this.radioButtonTxtUnix.UseVisualStyleBackColor = true;
            // 
            // radioButtonTxtWin
            // 
            this.radioButtonTxtWin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTxtWin.AutoSize = true;
            this.radioButtonTxtWin.Location = new System.Drawing.Point(55, 3);
            this.radioButtonTxtWin.Name = "radioButtonTxtWin";
            this.radioButtonTxtWin.Size = new System.Drawing.Size(74, 19);
            this.radioButtonTxtWin.TabIndex = 9;
            this.radioButtonTxtWin.TabStop = true;
            this.radioButtonTxtWin.Text = "TXT (Win)";
            this.radioButtonTxtWin.UseVisualStyleBackColor = true;
            // 
            // checkBoxEditMode
            // 
            this.checkBoxEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEditMode.AutoSize = true;
            this.checkBoxEditMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEditMode.Location = new System.Drawing.Point(217, 3);
            this.checkBoxEditMode.Name = "checkBoxEditMode";
            this.checkBoxEditMode.Size = new System.Drawing.Size(74, 19);
            this.checkBoxEditMode.TabIndex = 7;
            this.checkBoxEditMode.Text = "Edit Mode";
            this.checkBoxEditMode.UseVisualStyleBackColor = true;
            this.checkBoxEditMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkBoxEditMode_MouseUp);
            // 
            // radioButtonLSB
            // 
            this.radioButtonLSB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLSB.AutoSize = true;
            this.radioButtonLSB.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLSB.Name = "radioButtonLSB";
            this.radioButtonLSB.Size = new System.Drawing.Size(46, 19);
            this.radioButtonLSB.TabIndex = 8;
            this.radioButtonLSB.TabStop = true;
            this.radioButtonLSB.Text = "LSB";
            this.radioButtonLSB.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(297, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(268, 25);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "Subtitle file changed! Press \"Show Content\" to update.";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInfo.Visible = false;
            // 
            // dataGridViewSubtitles
            // 
            this.dataGridViewSubtitles.AllowUserToAddRows = false;
            this.dataGridViewSubtitles.AllowUserToDeleteRows = false;
            this.dataGridViewSubtitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubtitles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewSubtitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewSubtitles, 4);
            this.dataGridViewSubtitles.Location = new System.Drawing.Point(3, 64);
            this.dataGridViewSubtitles.MultiSelect = false;
            this.dataGridViewSubtitles.Name = "dataGridViewSubtitles";
            this.dataGridViewSubtitles.ReadOnly = true;
            this.dataGridViewSubtitles.RowHeadersVisible = false;
            this.dataGridViewSubtitles.Size = new System.Drawing.Size(803, 394);
            this.dataGridViewSubtitles.TabIndex = 15;
            this.dataGridViewSubtitles.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewSubtitles_CellBeginEdit);
            this.dataGridViewSubtitles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubtitles_CellEndEdit);
            this.dataGridViewSubtitles.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewSubtitles_ColumnWidthChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Subtitle files(*.lsb;*.txt)|*.lsb;*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "LSB file (*.lsb)|*.lsb|Windows text document (*.txt)|*.txt|Unix text document (*." +
    "txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(825, 400);
            this.Name = "Form1";
            this.Text = "LiS BtS Subtitle Decrypter ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtitles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelInPath;
        private System.Windows.Forms.TextBox textBoxInPath;
        private System.Windows.Forms.Button buttonBrosweInput;
        private System.Windows.Forms.Button buttonShowContent;
        private System.Windows.Forms.CheckBox checkBoxEditMode;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSaveEdits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonLSB;
        private System.Windows.Forms.RadioButton radioButtonTxtWin;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewSubtitles;
        private System.Windows.Forms.RadioButton radioButtonTxtUnix;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

