using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class NGramData:IAlgorithmData
    {
        public StringBuilder OriginalText = new StringBuilder();

        public StringBuilder NormalizedText = new StringBuilder();

        public Dictionary<string, string> ABC = new Dictionary<string, string>();

        public Dictionary<string, string> Settings = new Dictionary<string, string>();
        //По ключу "Current ABC" требуется хранить ключ текущего алфавита. 
        //Trigram at least если триграма встречена меньше раз, то игнорируется.
        

        public Dictionary<string, double> NGramFrequencyDistribution = new Dictionary<string, double>(); //или distribution function density... 
    }
}
