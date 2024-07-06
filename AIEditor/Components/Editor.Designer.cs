namespace AIEditor.Components
{
    partial class Editor
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textEditor = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = SystemColors.ActiveCaption;
            labelName.Location = new Point(3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(53, 20);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            // 
            // textEditor
            // 
            textEditor.BackColor = SystemColors.HighlightText;
            textEditor.Location = new Point(3, 23);
            textEditor.Name = "textEditor";
            textEditor.Size = new Size(187, 27);
            textEditor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.redo;
            pictureBox1.Location = new Point(196, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Controls.Add(textEditor);
            Controls.Add(labelName);
            ForeColor = Color.Transparent;
            Name = "Editor";
            Size = new Size(232, 58);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textEditor;
        private PictureBox pictureBox1;
    }
}
