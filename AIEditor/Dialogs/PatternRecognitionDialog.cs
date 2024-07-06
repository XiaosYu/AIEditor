using AIEditor.Models;
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
    public partial class PatternRecognitionDialog : Form
    {
        private ModelService ModelService { get; } = new ModelService();

        public PatternRecognitionDialog()
        {
            InitializeComponent();
        }

        private Task<string> ParseInfomation(string modelName, Dictionary<string, object?> data)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"ModelName:{modelName}");
            stringBuilder.AppendLine($"ModelArgumentCount:{data.Count}");
            stringBuilder.AppendLine($"");
            foreach (var (key, value) in data.ToList())
            {
                stringBuilder.AppendLine($"KeyName:{key}");
                stringBuilder.AppendLine($"Default:{value}");
                stringBuilder.AppendLine($"");
            }

            return Task.FromResult(stringBuilder.ToString());
        }

        private async void PatternRecognitionDialog_Load(object sender, EventArgs e)
        {
            var modelNames = await ModelService.ListAllModelAsync();
            modelList.Items.Clear();
            modelNames.ForEach(s => modelList.Items.Add(s));
        }

        private async void modelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelList.SelectedItem is string modelName)
            {
                var arguments = await ModelService.QueryModelParameters(modelName);
                var result = await ParseInfomation(modelName, arguments);
                ModelIntroducation.Text = result;
            }
        }

        public async Task<AlgorithmInfo?> GetResult()
        {
            if (modelList.SelectedItem == null) return null;
            else return new AlgorithmInfo()
            {
                Name = modelList.SelectedItem as string,
                Parameters = await ModelService.QueryModelParameters(modelList.SelectedItem as string)
            };
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
