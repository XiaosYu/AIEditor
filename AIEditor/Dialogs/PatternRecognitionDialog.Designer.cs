namespace AIEditor.Dialogs
{
    partial class PatternRecognitionDialog
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
            groupBox1 = new GroupBox();
            modelList = new ListBox();
            ModelIntroducation = new RichTextBox();
            buttonLoad = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(modelList);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "The algorithm is loaded";
            // 
            // modelList
            // 
            modelList.FormattingEnabled = true;
            modelList.Location = new Point(13, 32);
            modelList.Name = "modelList";
            modelList.Size = new Size(320, 384);
            modelList.TabIndex = 0;
            modelList.SelectedIndexChanged += modelList_SelectedIndexChanged;
            // 
            // ModelIntroducation
            // 
            ModelIntroducation.BorderStyle = BorderStyle.None;
            ModelIntroducation.Location = new Point(362, 17);
            ModelIntroducation.Name = "ModelIntroducation";
            ModelIntroducation.ReadOnly = true;
            ModelIntroducation.Size = new Size(333, 347);
            ModelIntroducation.TabIndex = 1;
            ModelIntroducation.Text = "";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(366, 370);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(329, 66);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // PatternRecognitionDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 450);
            Controls.Add(buttonLoad);
            Controls.Add(ModelIntroducation);
            Controls.Add(groupBox1);
            Name = "PatternRecognitionDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatternRecognition";
            Load += PatternRecognitionDialog_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox modelList;
        private RichTextBox ModelIntroducation;
        private Button buttonLoad;
    }
}