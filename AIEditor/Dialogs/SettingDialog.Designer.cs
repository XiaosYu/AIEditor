namespace AIEditor.Dialogs
{
    partial class SettingDialog
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
            ExchangeExec = new LinkLabel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            ExchangeDLLs = new LinkLabel();
            SuspendLayout();
            // 
            // ExchangeExec
            // 
            ExchangeExec.AutoSize = true;
            ExchangeExec.Location = new Point(399, 39);
            ExchangeExec.Name = "ExchangeExec";
            ExchangeExec.Size = new Size(78, 20);
            ExchangeExec.TabIndex = 0;
            ExchangeExec.TabStop = true;
            ExchangeExec.Text = "Exchange";
            ExchangeExec.LinkClicked += ExchangeExec_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 1;
            label1.Text = "CurrentExecutionLibrary";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 3;
            label2.Text = "CurrentDynamicLibrary";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 107);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(381, 27);
            textBox2.TabIndex = 4;
            // 
            // ExchangeDLLs
            // 
            ExchangeDLLs.AutoSize = true;
            ExchangeDLLs.Location = new Point(399, 110);
            ExchangeDLLs.Name = "ExchangeDLLs";
            ExchangeDLLs.Size = new Size(78, 20);
            ExchangeDLLs.TabIndex = 5;
            ExchangeDLLs.TabStop = true;
            ExchangeDLLs.Text = "Exchange";
            ExchangeDLLs.LinkClicked += ExchangeDLLs_LinkClicked;
            // 
            // SettingDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 157);
            Controls.Add(ExchangeDLLs);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(ExchangeExec);
            Name = "SettingDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SettingDialog";
            Load += SettingDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel ExchangeExec;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private LinkLabel ExchangeDLLs;
    }
}