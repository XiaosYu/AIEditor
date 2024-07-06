namespace AIEditor.Dialogs
{
    partial class DataPreprocessDialog
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
            dataGridView = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            IsFeature = new DataGridViewCheckBoxColumn();
            IsLabel = new DataGridViewCheckBoxColumn();
            Normalize = new DataGridViewCheckBoxColumn();
            Encode = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            labelFrameName = new Label();
            label2 = new Label();
            labelFrameLength = new Label();
            buttonLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(649, 423);
            dataGridView.TabIndex = 0;
            // 
            // ColumnName
            // 
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // IsFeature
            // 
            IsFeature.MinimumWidth = 6;
            IsFeature.Name = "IsFeature";
            IsFeature.Width = 125;
            // 
            // IsLabel
            // 
            IsLabel.MinimumWidth = 6;
            IsLabel.Name = "IsLabel";
            IsLabel.Width = 125;
            // 
            // Normalize
            // 
            Normalize.MinimumWidth = 6;
            Normalize.Name = "Normalize";
            Normalize.Width = 125;
            // 
            // Encode
            // 
            Encode.MinimumWidth = 6;
            Encode.Name = "Encode";
            Encode.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(667, 12);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "FrameName";
            // 
            // labelFrameName
            // 
            labelFrameName.AutoSize = true;
            labelFrameName.Location = new Point(667, 32);
            labelFrameName.Name = "labelFrameName";
            labelFrameName.Size = new Size(104, 20);
            labelFrameName.TabIndex = 2;
            labelFrameName.Text = "MyFrame.csv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 67);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "FrameLength";
            // 
            // labelFrameLength
            // 
            labelFrameLength.AutoSize = true;
            labelFrameLength.Location = new Point(667, 87);
            labelFrameLength.Name = "labelFrameLength";
            labelFrameLength.Size = new Size(54, 20);
            labelFrameLength.TabIndex = 4;
            labelFrameLength.Text = "50000";
            // 
            // buttonLoadData
            // 
            buttonLoadData.Location = new Point(667, 387);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(126, 48);
            buttonLoadData.TabIndex = 5;
            buttonLoadData.Text = "Load";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonLoadData_Click;
            // 
            // DataPreprocessDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoadData);
            Controls.Add(labelFrameLength);
            Controls.Add(label2);
            Controls.Add(labelFrameName);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Name = "DataPreprocessDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DataPreprocess";
            Load += DataPreprocessDialog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Label labelFrameName;
        private Label label2;
        private Label labelFrameLength;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewCheckBoxColumn IsFeature;
        private DataGridViewCheckBoxColumn IsLabel;
        private DataGridViewCheckBoxColumn Normalize;
        private DataGridViewCheckBoxColumn Encode;
        private Button buttonLoadData;
    }
}