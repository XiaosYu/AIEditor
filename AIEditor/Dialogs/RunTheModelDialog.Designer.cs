namespace AIEditor.Dialogs
{
    partial class RunTheModelDialog
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
            label1 = new Label();
            kFoldSplit = new NumericUpDown();
            label2 = new Label();
            estimatorName = new TextBox();
            label3 = new Label();
            datasetName = new TextBox();
            buttonStartTraining = new Button();
            LoadedMetrics = new ListBox();
            label4 = new Label();
            listBoxConsole = new ListBox();
            label5 = new Label();
            richTextBoxMetrics = new RichTextBox();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)kFoldSplit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 125);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "KFoldSplit";
            // 
            // kFoldSplit
            // 
            kFoldSplit.Location = new Point(21, 148);
            kFoldSplit.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            kFoldSplit.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            kFoldSplit.Name = "kFoldSplit";
            kFoldSplit.Size = new Size(205, 27);
            kFoldSplit.TabIndex = 1;
            kFoldSplit.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 19);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Estimator";
            // 
            // estimatorName
            // 
            estimatorName.Location = new Point(21, 42);
            estimatorName.Name = "estimatorName";
            estimatorName.ReadOnly = true;
            estimatorName.Size = new Size(205, 27);
            estimatorName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 72);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Dataset";
            // 
            // datasetName
            // 
            datasetName.Location = new Point(21, 95);
            datasetName.Name = "datasetName";
            datasetName.ReadOnly = true;
            datasetName.Size = new Size(205, 27);
            datasetName.TabIndex = 5;
            // 
            // buttonStartTraining
            // 
            buttonStartTraining.Location = new Point(21, 584);
            buttonStartTraining.Name = "buttonStartTraining";
            buttonStartTraining.Size = new Size(205, 75);
            buttonStartTraining.TabIndex = 6;
            buttonStartTraining.Text = "StartTraining";
            buttonStartTraining.UseVisualStyleBackColor = true;
            buttonStartTraining.Click += buttonStartTraining_Click;
            // 
            // LoadedMetrics
            // 
            LoadedMetrics.FormattingEnabled = true;
            LoadedMetrics.Location = new Point(21, 265);
            LoadedMetrics.Name = "LoadedMetrics";
            LoadedMetrics.Size = new Size(205, 304);
            LoadedMetrics.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 237);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 8;
            label4.Text = "LoadedMetrics";
            // 
            // listBoxConsole
            // 
            listBoxConsole.FormattingEnabled = true;
            listBoxConsole.Location = new Point(256, 42);
            listBoxConsole.Name = "listBoxConsole";
            listBoxConsole.ScrollAlwaysVisible = true;
            listBoxConsole.Size = new Size(761, 184);
            listBoxConsole.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 19);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "Console";
            // 
            // richTextBoxMetrics
            // 
            richTextBoxMetrics.Location = new Point(256, 265);
            richTextBoxMetrics.Name = "richTextBoxMetrics";
            richTextBoxMetrics.Size = new Size(340, 368);
            richTextBoxMetrics.TabIndex = 11;
            richTextBoxMetrics.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(602, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(256, 639);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(761, 20);
            progressBar1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 237);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 14;
            label6.Text = "MetricsResult";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(602, 237);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 15;
            label7.Text = "ConfusionMatrix";
            // 
            // RunTheModelDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 671);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBoxMetrics);
            Controls.Add(label5);
            Controls.Add(listBoxConsole);
            Controls.Add(label4);
            Controls.Add(LoadedMetrics);
            Controls.Add(buttonStartTraining);
            Controls.Add(datasetName);
            Controls.Add(label3);
            Controls.Add(estimatorName);
            Controls.Add(label2);
            Controls.Add(kFoldSplit);
            Controls.Add(label1);
            Name = "RunTheModelDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RunTheModel";
            Load += RunTheModelDialog_Load;
            ((System.ComponentModel.ISupportInitialize)kFoldSplit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown kFoldSplit;
        private Label label2;
        private TextBox estimatorName;
        private Label label3;
        private TextBox datasetName;
        private Button buttonStartTraining;
        private ListBox LoadedMetrics;
        private Label label4;
        private ListBox listBoxConsole;
        private Label label5;
        private RichTextBox richTextBoxMetrics;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label6;
        private Label label7;
    }
}