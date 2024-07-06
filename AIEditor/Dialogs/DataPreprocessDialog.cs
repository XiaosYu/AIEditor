using AIEditor.Models;
using Microsoft.Data.Analysis;
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
    public partial class DataPreprocessDialog : Form
    {
        private readonly DataFrame Frame;
        private readonly string FilePath;


        public DataPreprocessDialog(string filePath)
        {
            InitializeComponent();
            Frame = DataFrame.LoadCsv(filePath);
            labelFrameName.Text = Path.GetFileName(filePath);
            labelFrameLength.Text = Frame.Rows.Count.ToString();
            FilePath = filePath;
        }

        private void DataPreprocessDialog_Load(object sender, EventArgs e)
        {
            var columns = Frame.Columns.Select(s => s.Name);
            dataGridView.DataSource = columns.Select(s => new DataColumnPreProcessInfo()
            {
                ColumnName = s,
                IsEncode = false,
                IsFeature = false,
                IsLabel = false,
                IsNormalize = false
            }).ToList();
            
        }

        public DataPreProcessInfo GetResult()
        {
            return new DataPreProcessInfo()
            {
                Infos = dataGridView.DataSource as IEnumerable<DataColumnPreProcessInfo>,
                Path = FilePath
            };
        }

        private void buttonLoadData_Click(object sender, EventArgs e) => Close();
    }
}
