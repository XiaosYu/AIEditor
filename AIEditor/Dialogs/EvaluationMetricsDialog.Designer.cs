namespace AIEditor.Dialogs
{
    partial class EvaluationMetricsDialog
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
            checkedListBoxMetrics = new CheckedListBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // checkedListBoxMetrics
            // 
            checkedListBoxMetrics.FormattingEnabled = true;
            checkedListBoxMetrics.Location = new Point(12, 12);
            checkedListBoxMetrics.Name = "checkedListBoxMetrics";
            checkedListBoxMetrics.Size = new Size(310, 378);
            checkedListBoxMetrics.TabIndex = 0;
            checkedListBoxMetrics.SelectedIndexChanged += checkedListBoxMetrics_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(332, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(448, 378);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // EvaluationMetricsDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 407);
            Controls.Add(richTextBox1);
            Controls.Add(checkedListBoxMetrics);
            Name = "EvaluationMetricsDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EvaluationMetricsDialog";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBoxMetrics;
        private RichTextBox richTextBox1;
    }
}