using AIEditor.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIEditor.Dialogs
{
    public partial class SettingDialog : Form
    {
        public SettingDialog()
        {
            InitializeComponent();
        }

        private void SettingDialog_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = PythonContext.PythonDLL;
            this.textBox2.Text = PythonContext.PythonHome;
        }

        private void ExchangeExec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DLL File(*.dll)|*.dll";
            openFileDialog.ShowDialog();
            var file = openFileDialog.FileName;
            if (string.IsNullOrEmpty(file)) return;
            this.textBox1.Text = openFileDialog.FileName;
            PythonContext.PythonDLL = this.textBox1.Text;

        }

        private void ExchangeDLLs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "Please select a file path"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                this.textBox2.Text = foldPath;
                PythonContext.PythonHome = this.textBox2.Text;
            }
        }
    }
}
