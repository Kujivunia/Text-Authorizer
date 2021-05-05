using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class DataTEST: IAlgorithmData
    {
        public string data;
        public string normalized;
        public string name;
        public List<string> tokens = new List<string>();
        public System.Collections.Generic.Dictionary<string, double> ngram = new Dictionary<string, double>();
    }
}
