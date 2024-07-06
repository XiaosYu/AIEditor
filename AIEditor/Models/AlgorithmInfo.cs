using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace AIEditor.Models
{
    public class AlgorithmInfo
    {
        public string Name { set; get; }
        public Dictionary<string, object> Parameters { get; set; }
    }
}
