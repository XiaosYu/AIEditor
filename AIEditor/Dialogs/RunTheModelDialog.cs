using AIEditor.Models;
using AIEditor.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIEditor.Dialogs
{
    public partial class RunTheModelDialog : Form
    {
        private AlgorithmInfo AlgorithmInfo { get; }
        private DataPreProcessInfo DataPreProcessInfo { get; }
        private List<MetricsInfo> MetricsInfos { get; }
        private List<TrainResult> TrainResults { get; } = new List<TrainResult>();

        public RunTheModelDialog(AlgorithmInfo algorithm, DataPreProcessInfo dataInfo, List<MetricsInfo> metrics)
        {
            InitializeComponent();
            AlgorithmInfo = algorithm;
            DataPreProcessInfo = dataInfo;
            MetricsInfos = metrics;
        }

        private void RunTheModelDialog_Load(object sender, EventArgs e)
        {
            this.estimatorName.Text = AlgorithmInfo.Name;
            MetricsInfos.ForEach(s => this.LoadedMetrics.Items.Add(s.Name));
            this.datasetName.Text = Path.GetFileName(DataPreProcessInfo.Path);
        }

        private void buttonStartTraining_Click(object sender, EventArgs e)
        {
            buttonStartTraining.Enabled = false;
            Task.Factory.StartNew(() => TrainService.Train(AlgorithmInfo, DataPreProcessInfo, MetricsInfos, (int)kFoldSplit.Value));
            Task.Factory.StartNew(async () => await RunAsync());

        }

        public List<TrainResult> GetResults() => TrainResults;

        private async Task RunAsync()
        {
            this.Invoke(() => listBoxConsole.Items.Clear());

         
            var value = await TrainService.ReceiveAsync("127.0.0.1", 6240);
            if (value != null)
            {
                var text = JsonSerializer.Deserialize<JsonObject>(value);
                this.Invoke(() => listBoxConsole.Items.Add(text["message"].Deserialize<string>()));
            }
            else return;

            this.Invoke(() =>
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = (int)kFoldSplit.Value;
                progressBar1.Minimum = 0;
                progressBar1.Step = 1;
            });

            for(int i=0;i<kFoldSplit.Value;++i) 
            {
                value = await TrainService.ReceiveAsync("127.0.0.1", 6240);
                var @cvResult = JsonSerializer.Deserialize<JsonObject>(value);
                var k = cvResult["k"].Deserialize<int>();
                var trainScores = cvResult["train_scores"].Deserialize<Dictionary<string, object>>();
                var testScores = cvResult["test_scores"].Deserialize<Dictionary<string, object>>();
                var textBuilder = new StringBuilder();

                var trainText = string.Join(',', trainScores.Keys.Select(s => $"{s}={trainScores[s]}"));
                var testText = string.Join(',', testScores.Keys.Select(s => $"{s}={testScores[s]}"));

                var text = $"k:[{k}/{kFoldSplit.Value}] train:({trainText}) test:({testText})";

                this.Invoke(() => listBoxConsole.Items.Add(text));
                this.Invoke(() => progressBar1.PerformStep());
                Thread.Sleep(100);
            }
          

            value = await TrainService.ReceiveAsync("127.0.0.1", 6240);
            var result = JsonSerializer.Deserialize<JsonObject>(value);

            var figurePath = result["figure"].Deserialize<string>();
            var estimator = result["estimator"].Deserialize<string>();
            var rootPath = result["root"].Deserialize<string>();

            value = await TrainService.ReceiveAsync("127.0.0.1", 6240);
            var totalMetrics = JsonSerializer.Deserialize<JsonObject>(value);
            var trainMetrics = totalMetrics["train_results"].Deserialize<Dictionary<string, object>>();
            var testMetrics = totalMetrics["test_results"].Deserialize<Dictionary<string, object>>();
            var trainlMetricsText = string.Join(',', trainMetrics.Keys.Select(s => $"{s}={trainMetrics[s]}"));
            var testlMetricsText = string.Join(',', testMetrics.Keys.Select(s => $"{s}={testMetrics[s]}"));
            var builder = new StringBuilder();
            builder.AppendLine($"DateTime:{DateTime.Now}, KFold:{kFoldSplit.Value}");
            builder.AppendLine($"Train Result:({trainlMetricsText})");
            builder.AppendLine($"Test Result:({testlMetricsText})");
            builder.AppendLine();

            this.Invoke(() => pictureBox1.Image = Image.FromFile(figurePath));
            this.Invoke(() => buttonStartTraining.Enabled = true);
            this.Invoke(() => richTextBoxMetrics.AppendText(builder.ToString()));

            TrainResults.Add(new TrainResult
            {
                KFold = (int)kFoldSplit.Value,
                Root = rootPath,
                Text = builder.ToString(),
                AlgorithmInfo = AlgorithmInfo,
                DataPreProcessInfo = DataPreProcessInfo
            });
        }
    }
}
