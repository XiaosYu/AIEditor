using AIEditor.Models;
using AIEditor.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIEditor.Dialogs
{
    public partial class EvaluationMetricsDialog : Form
    {
        private List<MetricsInfo> MetricsInfos { get; } = new List<MetricsInfo>();

        public EvaluationMetricsDialog(List<MetricsInfo> selectInfos)
        {
            MetricsInfos = MetricsService.Metrics;
            InitializeComponent();
            MetricsInfos.ForEach(s => checkedListBoxMetrics.Items.Add(s.Name));
            checkedListBoxMetrics.SelectedIndices.Clear();
            foreach (var selectInfo in selectInfos)
            {
                var index = MetricsInfos.IndexOf(selectInfo);
                checkedListBoxMetrics.SetItemChecked(index, true);
            }
        }

        public List<MetricsInfo> GetResult()
        {
            var result = new List<MetricsInfo>();
            for(int i=0;i<checkedListBoxMetrics.CheckedItems.Count;++i)
            {
                var name = checkedListBoxMetrics.CheckedItems[i] as string;
                result.Add(MetricsInfos.First(s => s.Name == name));
            }

            return result;
        }

        private void checkedListBoxMetrics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxMetrics.SelectedItem == null) return;
            var name = checkedListBoxMetrics.SelectedItem as string;
            var introduction = MetricsInfos.First(s => s.Name == name).Description;
            richTextBox1.Text = introduction;
        }

       
    }
}
