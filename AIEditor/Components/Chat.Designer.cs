namespace AIEditor.Components
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            richTextBoxContent = new RichTextBox();
            role = new Label();
            SuspendLayout();
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.Location = new Point(7, 23);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(522, 256);
            richTextBoxContent.TabIndex = 0;
            richTextBoxContent.Text = resources.GetString("richTextBoxContent.Text");
            // 
            // role
            // 
            role.AutoSize = true;
            role.ForeColor = SystemColors.ActiveCaption;
            role.Location = new Point(3, 0);
            role.Name = "role";
            role.Size = new Size(53, 20);
            role.TabIndex = 1;
            role.Text = "label1";
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(role);
            Controls.Add(richTextBoxContent);
            Name = "Chat";
            Size = new Size(529, 105);
            Load += Chat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxContent;
        private Label role;
    }
}
