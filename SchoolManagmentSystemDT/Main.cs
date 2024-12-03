using Skynet.ERP.Domains;
using Skynet.ERP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystemDT
{
    public partial class Main : Form
    {
        private string _saveFilePath = string.Empty;

        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status_Time.Text = DateTime.Now.ToString();
        }

        private void stripNew_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "|*.txt";
            var di = saveFileDialog1.ShowDialog();
            if (di == DialogResult.OK)
            {
                _saveFilePath = saveFileDialog1.FileName;
                if (!File.Exists(_saveFilePath))
                {
                    File.Create(_saveFilePath).Close();
                    status_save.Enabled = true;
                    status_saveas.Enabled = true;
                }
            }
        }

        private void status_save_Click(object sender, EventArgs e)
        {
            var content = richTextBox.Text;

            using StreamWriter writer = new StreamWriter(_saveFilePath);
            writer.WriteLine(content);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var di = MessageBox.Show("Are you sure you want to exit ?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (di == DialogResult.Yes)
            {
                Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            var di = openFileDialog1.ShowDialog();
            if (di == DialogResult.OK)
            {
                using StreamReader reader = new StreamReader(openFileDialog1.FileName);
                richTextBox.Text = reader.ReadToEnd();
                status_save.Enabled = true;
                status_saveas.Enabled = true;
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
