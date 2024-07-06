using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIEditor.Models
{
    public class TrainResult
    {
        public string Root { get; set; }
        public int KFold { get; set; }
        public string Text { get; set; }
        public AlgorithmInfo AlgorithmInfo { get; set; }
        public DataPreProcessInfo DataPreProcessInfo { get; set; }
    }
}
