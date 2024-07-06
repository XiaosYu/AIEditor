using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIEditor.Components
{
    public partial class Editor : UserControl
    {
        public Editor(string name, object? defaultValue, bool editable = true)
        {
            InitializeComponent();
            labelName.Text = name;
            textEditor.Enabled = editable;
            textEditor.Text = defaultValue?.ToString();
            DefaultType = defaultValue?.GetType();
            DefalutValue = defaultValue;
        }

        private Type? DefaultType { get; }
        private object? DefalutValue { get; }

        public Models.ParameterInfo GetResult()
            => new Models.ParameterInfo()
            {
                Name = labelName.Text,
                Value = textEditor.Text,
                Type = DefaultType
            };

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textEditor.Text = DefalutValue?.ToString();
        }

        public (string, object?) GetKeyAndValue() => (labelName.Text, textEditor.Text);
        public object? GetValue() => textEditor.Text;
        public string GetKey() => labelName.Text;
    }
}
