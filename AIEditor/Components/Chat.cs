using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIEditor.Components
{
    public partial class Chat : UserControl
    {
        public Chat(string role, string content)
        {
            InitializeComponent();

            this.role.Text = role;
            this.richTextBoxContent.Text = content;
        }

        public Chat()
        {
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }
    }
}
