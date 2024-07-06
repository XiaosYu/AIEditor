using Microsoft.Data.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace AIEditor.Models
{
    public class DataPreProcessInfo
    {
        public int ColumnLength => Infos.Count();
        public int FeaturesLength => Infos.Count(s => s.IsFeature);
        public int LabelsLength => Infos.Count(s => s.IsLabel);
        public IEnumerable<DataColumnPreProcessInfo> Infos { get; set; }
        public string Path { set; get; }
    }
}
