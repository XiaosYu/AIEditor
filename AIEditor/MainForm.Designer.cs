namespace AIEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            algorithmToolStripMenuItem = new ToolStripMenuItem();
            patternToolStripMenuItem = new ToolStripMenuItem();
            trainToolStripMenuItem = new ToolStripMenuItem();
            evaluationMetricsToolStripMenuItem = new ToolStripMenuItem();
            runTheModelToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemSetting = new ToolStripMenuItem();
            dataGridGroupBox = new GroupBox();
            dataGridView = new DataGridView();
            parametersPanel = new Panel();
            labelAlgorithm = new Label();
            tabControl1 = new TabControl();
            tabPageAIChat = new TabPage();
            buttonAsk = new Button();
            richTextBoxMessage = new RichTextBox();
            chatPanel = new Panel();
            tabPage1 = new TabPage();
            buttonExport = new Button();
            listBoxTrainResult = new ListBox();
            menuStrip.SuspendLayout();
            dataGridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            parametersPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageAIChat.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, algorithmToolStripMenuItem, trainToolStripMenuItem, toolStripMenuItemSetting });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1212, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(81, 24);
            fileToolStripMenuItem.Text = "DataFile";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(172, 26);
            openFileToolStripMenuItem.Text = "OpenTable";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // algorithmToolStripMenuItem
            // 
            algorithmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { patternToolStripMenuItem });
            algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            algorithmToolStripMenuItem.Size = new Size(97, 24);
            algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // patternToolStripMenuItem
            // 
            patternToolStripMenuItem.Name = "patternToolStripMenuItem";
            patternToolStripMenuItem.Size = new Size(288, 26);
            patternToolStripMenuItem.Text = "PatternpatternRecognition";
            patternToolStripMenuItem.Click += patternToolStripMenuItem_Click;
            // 
            // trainToolStripMenuItem
            // 
            trainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { evaluationMetricsToolStripMenuItem, runTheModelToolStripMenuItem });
            trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            trainToolStripMenuItem.Size = new Size(59, 24);
            trainToolStripMenuItem.Text = "Train";
            // 
            // evaluationMetricsToolStripMenuItem
            // 
            evaluationMetricsToolStripMenuItem.Name = "evaluationMetricsToolStripMenuItem";
            evaluationMetricsToolStripMenuItem.Size = new Size(221, 26);
            evaluationMetricsToolStripMenuItem.Text = "EvaluationMetrics";
            evaluationMetricsToolStripMenuItem.Click += evaluationMetricsToolStripMenuItem_Click;
            // 
            // runTheModelToolStripMenuItem
            // 
            runTheModelToolStripMenuItem.Name = "runTheModelToolStripMenuItem";
            runTheModelToolStripMenuItem.Size = new Size(221, 26);
            runTheModelToolStripMenuItem.Text = "RunTheModel";
            runTheModelToolStripMenuItem.Click += runTheModelToolStripMenuItem_Click;
            // 
            // toolStripMenuItemSetting
            // 
            toolStripMenuItemSetting.Name = "toolStripMenuItemSetting";
            toolStripMenuItemSetting.Size = new Size(76, 24);
            toolStripMenuItemSetting.Text = "Setting";
            toolStripMenuItemSetting.Click += toolStripMenuItemSetting_Click;
            // 
            // dataGridGroupBox
            // 
            dataGridGroupBox.BackColor = Color.Transparent;
            dataGridGroupBox.Controls.Add(dataGridView);
            dataGridGroupBox.Location = new Point(328, 31);
            dataGridGroupBox.Name = "dataGridGroupBox";
            dataGridGroupBox.Size = new Size(868, 361);
            dataGridGroupBox.TabIndex = 2;
            dataGridGroupBox.TabStop = false;
            dataGridGroupBox.Text = "DataGrid-UnLoaded";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(856, 327);
            dataGridView.TabIndex = 0;
            // 
            // parametersPanel
            // 
            parametersPanel.AutoScroll = true;
            parametersPanel.BackColor = Color.Transparent;
            parametersPanel.BackgroundImage = Properties.Resources.parameterbackground1;
            parametersPanel.BackgroundImageLayout = ImageLayout.Zoom;
            parametersPanel.BorderStyle = BorderStyle.FixedSingle;
            parametersPanel.Controls.Add(labelAlgorithm);
            parametersPanel.Location = new Point(12, 31);
            parametersPanel.Name = "parametersPanel";
            parametersPanel.Size = new Size(310, 786);
            parametersPanel.TabIndex = 3;
            // 
            // labelAlgorithm
            // 
            labelAlgorithm.AutoSize = true;
            labelAlgorithm.BackColor = Color.Transparent;
            labelAlgorithm.ForeColor = SystemColors.ActiveCaption;
            labelAlgorithm.Location = new Point(77, 13);
            labelAlgorithm.Name = "labelAlgorithm";
            labelAlgorithm.Size = new Size(143, 20);
            labelAlgorithm.TabIndex = 0;
            labelAlgorithm.Text = "UnLoad Algorithm";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAIChat);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(333, 401);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(867, 416);
            tabControl1.TabIndex = 4;
            // 
            // tabPageAIChat
            // 
            tabPageAIChat.Controls.Add(buttonAsk);
            tabPageAIChat.Controls.Add(richTextBoxMessage);
            tabPageAIChat.Controls.Add(chatPanel);
            tabPageAIChat.Location = new Point(4, 29);
            tabPageAIChat.Name = "tabPageAIChat";
            tabPageAIChat.Padding = new Padding(3);
            tabPageAIChat.Size = new Size(859, 383);
            tabPageAIChat.TabIndex = 2;
            tabPageAIChat.Text = "AIChat";
            tabPageAIChat.UseVisualStyleBackColor = true;
            // 
            // buttonAsk
            // 
            buttonAsk.Location = new Point(691, 333);
            buttonAsk.Name = "buttonAsk";
            buttonAsk.Size = new Size(160, 44);
            buttonAsk.TabIndex = 2;
            buttonAsk.Text = "Ask";
            buttonAsk.UseVisualStyleBackColor = true;
            buttonAsk.Click += buttonAsk_Click;
            // 
            // richTextBoxMessage
            // 
            richTextBoxMessage.Location = new Point(10, 333);
            richTextBoxMessage.Name = "richTextBoxMessage";
            richTextBoxMessage.Size = new Size(675, 45);
            richTextBoxMessage.TabIndex = 1;
            richTextBoxMessage.Text = "";
            // 
            // chatPanel
            // 
            chatPanel.AutoScroll = true;
            chatPanel.Location = new Point(10, 14);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(841, 313);
            chatPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonExport);
            tabPage1.Controls.Add(listBoxTrainResult);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(859, 383);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "TrainResults";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(711, 11);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(142, 46);
            buttonExport.TabIndex = 1;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // listBoxTrainResult
            // 
            listBoxTrainResult.FormattingEnabled = true;
            listBoxTrainResult.Location = new Point(6, 11);
            listBoxTrainResult.Name = "listBoxTrainResult";
            listBoxTrainResult.Size = new Size(699, 364);
            listBoxTrainResult.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1212, 856);
            Controls.Add(tabControl1);
            Controls.Add(parametersPanel);
            Controls.Add(dataGridGroupBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Opacity = 0.95D;
            Text = "AIEditor";
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            dataGridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            parametersPanel.ResumeLayout(false);
            parametersPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageAIChat.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private GroupBox dataGridGroupBox;
        private DataGridView dataGridView;
        private ToolStripMenuItem algorithmToolStripMenuItem;
        private ToolStripMenuItem patternToolStripMenuItem;
        private Panel parametersPanel;
        private Label labelAlgorithm;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPageAIChat;
        private Button buttonAsk;
        private RichTextBox richTextBoxMessage;
        private Panel chatPanel;
        private ToolStripMenuItem trainToolStripMenuItem;
        private ToolStripMenuItem evaluationMetricsToolStripMenuItem;
        private ToolStripMenuItem runTheModelToolStripMenuItem;
        private TabPage tabPage1;
        private Button buttonExport;
        private ListBox listBoxTrainResult;
        private ToolStripMenuItem toolStripMenuItemSetting;
    }
}
