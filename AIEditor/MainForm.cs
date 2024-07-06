using AIEditor.Components;
using AIEditor.Dialogs;
using AIEditor.Models;
using AIEditor.Services;
using Microsoft.Data.Analysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AIEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int LineCount { set; get; }
        private DataPreProcessInfo? DataPreProcessInfo { set; get; }
        private ChatGPTService ChatGPTService { get; } = new ChatGPTService();
        private List<ChatToken> ChatTokens { get; } = new List<ChatToken>();
        private List<MetricsInfo> SelectMetrics { get; set; } = new List<MetricsInfo>();
        private AlgorithmInfo? AlgorithmInfo { get; set; }

        private List<TrainResult> TrainResults { get; } = new List<TrainResult>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV File(*.csv)|*.csv";
            openFileDialog.ShowDialog();
            var file = openFileDialog.FileName;
            if (string.IsNullOrEmpty(file)) return;
            var dataPreProcessDialog = new DataPreprocessDialog(file);
            dataPreProcessDialog.ShowDialog();
            var info = dataPreProcessDialog.GetResult();
            dataGridGroupBox.Text = "DataGrid-Loaded";
            dataGridView.DataSource = null;
            dataGridView.Visible = true;
            dataGridView.DataSource = info.Infos.ToList();
            DataPreProcessInfo = info;
        }

        private async void patternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var patternRecognitionDialog = new PatternRecognitionDialog();
            patternRecognitionDialog.ShowDialog();
            var algorithm = await patternRecognitionDialog.GetResult();
            AlgorithmInfo = algorithm;
            if (algorithm != null)
            {
                parametersPanel.Controls.Clear();
                labelAlgorithm.Text = algorithm.Name;
                int i = 0;
                foreach (var (key, value) in algorithm.Parameters.ToList())
                {
                    var editor = new Editor(key, value);
                    editor.Location = new Point(10, 30 + 60 * (i++));
                    parametersPanel.Controls.Add(editor);
                }
            }


        }

        private async void buttonAsk_Click(object sender, EventArgs e)
        {
            
            void Display(string role, string message)
            {
                var count = chatPanel.Controls.Count;
                var box = new Chat(role, message);
                box.Location = new Point(10, 100 * count + 20 * LineCount);
                box.Height = message.Count(s => s == '\n') * 20 + 100;
                LineCount += message.Count(s => s == '\n');
                this.chatPanel.Controls.Add(box);
            }
            var text = this.richTextBoxMessage.Text;
            this.richTextBoxMessage.Text = "";
            if (text == "") return;
            this.buttonAsk.Enabled = false;

            Display("user", text);
            var result = await ChatGPTService.Chat(text, ChatTokens);
            if (result != null)
            {
                Display("assistant", result.Content);
            }
            this.buttonAsk.Enabled = true;

        }

        private void evaluationMetricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var evaluationMetricsDialognew = new EvaluationMetricsDialog(SelectMetrics);
            evaluationMetricsDialognew.ShowDialog();
            SelectMetrics = evaluationMetricsDialognew.GetResult();
        }

        private void runTheModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectMetrics.Count == 0)
            {
                MessageBox.Show("Raise error when loading the metrics,Please check the metrics", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AlgorithmInfo == null)
            {
                MessageBox.Show("Raise error when loading the algorithm,Please check the algorithm", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataPreProcessInfo == null)
            {
                MessageBox.Show("Raise error when loading the dataset,Please check the dataset", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var edit in parametersPanel.Controls)
            {
                if (edit is Editor editor)
                {
                    var (key, value) = editor.GetKeyAndValue();
                    AlgorithmInfo.Parameters[key] = value;
                }
            }

            var runTheModelDialog = new RunTheModelDialog(AlgorithmInfo, DataPreProcessInfo, SelectMetrics);
            runTheModelDialog.ShowDialog();
            var result = runTheModelDialog.GetResults();
            if (result.Count > 0)
            {
                MessageBox.Show($"At the end of the training session, {result.Count} results are obtained, please check at the results");
                TrainResults.AddRange(result);

                listBoxTrainResult.Items.Clear();
                TrainResults.ForEach(s => listBoxTrainResult.Items.Add(s.Text.Replace("\n", "")));

            }

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (listBoxTrainResult.SelectedIndex == -1)
            {
                MessageBox.Show("Select the true row", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var index = listBoxTrainResult.SelectedIndex;
            var trainResult = TrainResults[index];

            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "Please select a file path"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                File.Copy($"{trainResult.Root}/Eval Confusion Matrix.png", $"{foldPath}/Eval Confusion Matrix.png", true);
                File.Copy($"{trainResult.Root}/Estimator.m", $"{foldPath}/Estimator.m", true);


                File.WriteAllText($"{foldPath}/Result.txt", trainResult.Text);
                File.WriteAllText($"{foldPath}/DataSetConfig.json", JsonSerializer.Serialize(trainResult.DataPreProcessInfo));
                File.WriteAllText($"{foldPath}/Parameter.json", JsonSerializer.Serialize(trainResult.AlgorithmInfo));

                MessageBox.Show("Export Successful");
            }
        }

        private void toolStripMenuItemSetting_Click(object sender, EventArgs e)
        {
            var dialog = new SettingDialog();
            dialog.ShowDialog();
        }
    }
}
