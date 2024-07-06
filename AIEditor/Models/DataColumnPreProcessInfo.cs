using Microsoft.Data.Analysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace AIEditor.Models
{
    public class DataColumnPreProcessInfo
    {
        [ReadOnly(true)]
        public string ColumnName { set; get; }
        public bool IsFeature { set; get; }
        public bool IsLabel { set; get; }
        public bool IsNormalize { set; get; }
        public bool IsEncode { set; get; }
    }
}
