using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class NGramNormalization : INormalization
    {
        public void Execute(IAlgorithmData data)
        {
            NGramData dt = (NGramData)data;
            dt.NormalizedText.Clear();
            foreach (var symbol in dt.OriginalText.ToString())
            {
                if (dt.ABC[dt.Settings["Current ABC"]].Contains(symbol.ToString().ToLower()))
                {
                    dt.NormalizedText.Append(symbol.ToString().ToLower());
                }
            }

        }
    }
}
