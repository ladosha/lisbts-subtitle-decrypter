using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace lisbts_subtitle_decrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ValidatePaths();
        }

        SubtitleFile m_Subtitles = new SubtitleFile();
        const string c_locPath = @"Life is Strange - Before the Storm_Data\StreamingAssets\Localization";
        string lastPath = "";

        bool resizeHelpShown = false;

        private void buttonShowContent_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(textBoxInPath.Text) == ".lsb")
            {
                m_Subtitles.Read_Lsbfile(textBoxInPath.Text);
                radioButtonLSB.Checked = true;
            }
            else if (Path.GetExtension(textBoxInPath.Text) == ".txt")
            {
                m_Subtitles.Read_Txtfile(textBoxInPath.Text);
                radioButtonTxtWin.Checked = true;
            }
            
            if (m_Subtitles.subtitles.Count != 0 && !m_Subtitles.badLSB)
            {
                UpdateSubtitleGrid();
                buttonSaveEdits.Enabled = true;
                checkBoxEditMode.Enabled = true;
                radioButtonLSB.Enabled = true;
                radioButtonTxtWin.Enabled = true;
                radioButtonTxtUnix.Enabled = true;
                labelInfo.Visible = false;

                if (!resizeHelpShown)
                {
                    ToolTip tt = new ToolTip();
                    tt.ToolTipIcon = ToolTipIcon.Info;
                    tt.ToolTipTitle = "Tip";

                    tt.Show("Drag here to resize", this, dataGridViewSubtitles.Columns[0].Width - 5, 65, 2000);
                    resizeHelpShown = true;
                }
            }
            else
            {
                MessageBox.Show("The file is empty or corrupted! Please specify a different one.", "Subtitle Decrypter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSaveEdits_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                if (radioButtonLSB.Checked)
                {
                    saveFileDialog1.FilterIndex = 1;
                }
                else if (radioButtonTxtWin.Checked)
                {
                    saveFileDialog1.FilterIndex = 2;
                }
                else if (radioButtonTxtUnix.Checked)
                {
                    saveFileDialog1.FilterIndex = 3;
                }

                saveFileDialog1.FileName = "";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        m_Subtitles.Write_Lsbfile(saveFileDialog1.FileName);
                    }
                    else if (saveFileDialog1.FilterIndex == 2)
                    {
                        m_Subtitles.Write_Txtfile(saveFileDialog1.FileName, false);
                    }
                    else if (saveFileDialog1.FilterIndex == 3)
                    {
                        m_Subtitles.Write_Txtfile(saveFileDialog1.FileName, true);
                    }
                }
                else return;
            }
            else
            {
                if (radioButtonLSB.Checked)
                {
                    m_Subtitles.Write_Lsbfile(textBoxInPath.Text);
                }
                else if (radioButtonTxtWin.Checked)
                {
                    m_Subtitles.Write_Txtfile(textBoxInPath.Text, false);
                }
                else if (radioButtonTxtUnix.Checked)
                {
                    m_Subtitles.Write_Txtfile(textBoxInPath.Text, true);
                }
            }

            if (m_Subtitles.editsSaved)
            {
                MessageBox.Show("Saved successfully!", "Subtitle Decrypter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelInfo.Visible = false;

                for (int i = 0; i < dataGridViewSubtitles.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewSubtitles.ColumnCount; j++)
                    {
                        if (dataGridViewSubtitles.Rows[i].Cells[j].ReadOnly && editModeActive)
                        {
                            dataGridViewSubtitles.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            dataGridViewSubtitles.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.White;
                        }
                    }
                }
            }
        }

        private void textBoxInPath_TextChanged(object sender, EventArgs e)
        {
            ValidatePaths();
        }

        bool editModeActive = false;

        private void checkBoxEditMode_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxEditMode.Checked)
            {
                enableEditMode();
            }
            else
            {
                if (!m_Subtitles.editsSaved)
                {
                    DialogResult answer = MessageBox.Show("There are unsaved edits left!\nExit 'Edit Mode' without saving?", "Subtitle Decrypter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        disableEditMode();
                    }
                    else
                    {
                        checkBoxEditMode.Checked = true;
                    }
                }
                else disableEditMode();
            }
        }

        private void enableEditMode ()
        {
            editModeActive = true;
            dataGridViewSubtitles.ReadOnly = false;
            buttonShowContent.Enabled = false;
            buttonBrosweInput.Enabled = false;
            textBoxInPath.Enabled = false;
            UpdateSubtitleGrid();
        }

        private void disableEditMode()
        {
            editModeActive = false;
            m_Subtitles.editsSaved = true;
            dataGridViewSubtitles.ReadOnly = true;
            buttonShowContent.Enabled = true;
            buttonBrosweInput.Enabled = true;
            textBoxInPath.Enabled = true;
            UpdateSubtitleGrid();
        }

        private void ValidatePaths()
        {
            if (File.Exists(textBoxInPath.Text) && (Path.GetExtension(textBoxInPath.Text) == ".txt" || Path.GetExtension(textBoxInPath.Text) == ".lsb"))
            {
                lastPath = textBoxInPath.Text;
                textBoxInPath.BackColor = SystemColors.Window;
                buttonShowContent.Enabled = true;
                labelInfo.Text = "Subtitle file changed! Press \"Show Content\" to update.";
                labelInfo.Visible = true;
            }
            else
            {
                textBoxInPath.BackColor = Color.Red;
                buttonShowContent.Enabled = false;
                buttonSaveEdits.Enabled = false;
                checkBoxEditMode.Enabled = false;
                radioButtonLSB.Enabled = false;
                radioButtonTxtWin.Enabled = false;
                radioButtonTxtUnix.Enabled = false;
            }

        }

        int visible_row = 0;
        bool lockWidth = false;
        private void UpdateSubtitleGrid()
        {
            if (dataGridViewSubtitles.FirstDisplayedScrollingRowIndex <= 0)
            {
                visible_row = 0;
            }
            else
            {
                visible_row = dataGridViewSubtitles.FirstDisplayedScrollingRowIndex;
            }
            int targetWidth = dataGridViewSubtitles.Width - SystemInformation.VerticalScrollBarWidth;
            int col1width = Convert.ToInt32(targetWidth * 0.11), col2width = Convert.ToInt32(targetWidth * 0.44);

            if(lockWidth)
            try
            {
                col1width = dataGridViewSubtitles.Columns[0].Width;
                col2width = dataGridViewSubtitles.Columns[1].Width;
            }
            catch
            {

            }

            dataGridViewSubtitles.Columns.Clear();
            DataTable table = BuildSubtitlesTable();
            dataGridViewSubtitles.DataSource = table.DefaultView;
            dataGridViewSubtitles.Columns["Key"].ReadOnly = true;
            dataGridViewSubtitles.Columns[1].ReadOnly = true;
            dataGridViewSubtitles.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            for (int i = 0; i < dataGridViewSubtitles.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewSubtitles.ColumnCount; j++)
                {
                    if (dataGridViewSubtitles.Rows[i].Cells[j].ReadOnly && editModeActive)
                    {
                        dataGridViewSubtitles.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightGray;
                    }
                    else
                    {
                        dataGridViewSubtitles.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.White;
                    }
                }
            }

            for (int i = 0; i < dataGridViewSubtitles.ColumnCount; i++)
            {
                dataGridViewSubtitles.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            try
            {
                dataGridViewSubtitles.FirstDisplayedScrollingRowIndex = visible_row;
            }
            catch
            {

            }

            dataGridViewSubtitles.Columns[0].Width = col1width;
            dataGridViewSubtitles.Columns[1].Width = col2width;
            if (editModeActive) dataGridViewSubtitles.Columns[2].Width = col2width;

        }

        private DataTable  BuildSubtitlesTable()
        {
            DataTable t = new DataTable();
            t.Columns.Add("Key");
            t.Columns.Add("Original Value");
            if (editModeActive)
            {
                t.Columns.Add("Modified Value");
            }

            object[] row = new object[t.Columns.Count];
            foreach (var key in m_Subtitles.subtitles.Keys)
            {
                row[0] = key.Replace('_', ' '); //allow word wrapping
                row[1] = m_Subtitles.subtitles[key];
                if (editModeActive)
                {
                    row[2] = m_Subtitles.subtitles[key];
                }
                t.Rows.Add(row);
            }
            
            return t;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cmd_args = Environment.GetCommandLineArgs();
            if (cmd_args.Count() == 1)
            {
                if (!File.Exists("path.txt"))
                {
                    DetectSubtitlePath();
                }
                else
                {
                    lastPath = File.ReadAllText("path.txt");
                    if (String.IsNullOrWhiteSpace(lastPath))
                    {
                        DetectSubtitlePath();
                    }
                    else
                    {
                        Properties.Settings.Default.SubtitlePath = lastPath;
                    }
                }
            }
            else if (cmd_args.Count() == 2)
            {
                lastPath = Path.GetFullPath(cmd_args[1]);
            }
            else if (cmd_args.Count() > 2)
            {
                
                for (int i = 1; i < cmd_args.Count(); i++)
                {
                    if (File.Exists(cmd_args[i]))
                    {
                        if (Path.GetExtension(cmd_args[i]) == ".lsb")
                        {
                            m_Subtitles.Read_Lsbfile(cmd_args[i]);
                            m_Subtitles.Write_Txtfile(cmd_args[i], false);
                        }
                        else if (Path.GetExtension(cmd_args[i]) == ".txt")
                        {
                            m_Subtitles.Read_Txtfile(cmd_args[i]);
                            m_Subtitles.Write_Lsbfile(cmd_args[i]);
                        }
                        else
                        {
                            Console.WriteLine("Unsupported extension: \"" + Path.GetExtension(cmd_args[i]) + "\" !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Could not find the file \"" + cmd_args[i] + "\" !");
                    }
                }
                Application.Exit();
                this.Dispose();
                return;
            }

            textBoxInPath.Text = lastPath;

            labelInfo.Visible = false;

            ToolTip tooltip = new ToolTip();
            tooltip.IsBalloon = true;

            tooltip.SetToolTip(buttonSaveEdits, "Click to save in the input folder.\nCtrl-click to choose save location.");

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dataGridViewSubtitles, new object[] { true });
        }

        string origValue = "", newValue = "";

        private void dataGridViewSubtitles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            origValue = dataGridViewSubtitles[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void dataGridViewSubtitles_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if(dataGridViewSubtitles.Cursor == Cursors.SizeWE)
            lockWidth = true;
        }

        private void buttonBrosweInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInPath.Text = openFileDialog1.FileName;
            }
        }

        private void dataGridViewSubtitles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            newValue = dataGridViewSubtitles[e.ColumnIndex, e.RowIndex].Value.ToString();

            if (newValue != origValue)
            {
                if(!String.IsNullOrWhiteSpace(newValue))
                {
                    string key = dataGridViewSubtitles[0, e.RowIndex].Value.ToString().Replace(' ', '_');
                    if (m_Subtitles.subtitles.ContainsKey(key))
                    {
                        m_Subtitles.subtitles[key] = newValue;
                        dataGridViewSubtitles.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        labelInfo.Text = "Press \"Save\" to write changes to the file.";
                        labelInfo.Visible = true;
                        m_Subtitles.editsSaved = false;
                    }
                    else dataGridViewSubtitles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = origValue;
                }
                else
                {
                    MessageBox.Show("Cell values are not allowed to be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewSubtitles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = origValue;
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(lastPath != Properties.Settings.Default.SubtitlePath)
            {
                File.WriteAllText("path.txt", lastPath);
            }
            if (m_Subtitles != null && !m_Subtitles.editsSaved)
            {
                DialogResult answer = MessageBox.Show("There are unsaved edits left! Exit without saving?", "Subtitle Decrypter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else e.Cancel = false;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.ShowDialog();
        }

        private void DetectSubtitlePath ()
        {
            RegistryKey localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
            localKey = localKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 554620");

            string lang = CultureInfo.InstalledUICulture.Name.ToUpperInvariant().Replace('-', '_');

            string BtsPath = "";
            try
            {
                BtsPath = localKey.GetValue("InstallLocation").ToString();
            }
            catch
            {
                textBoxInPath.Text = "Auto-detection failed! Please select the path manually.";
                return;
            }

            if (!File.Exists(Path.Combine(BtsPath, c_locPath, "\\", lang, @"\\global.lsb"))) 
            {
                lang = "EN";
                
            }
            lastPath = Path.Combine(BtsPath, c_locPath, lang, @"global.lsb");
        }
    }
}
