using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIEditor.Models
{
    public class ParameterInfo
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public Type? Type { get; set; }
    }
}
