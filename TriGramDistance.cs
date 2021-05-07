using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class TriGramDistance : IDistance
    {
        public double Distance(IAlgorithmData data1, IAlgorithmData data2)
        {
            NGramData dt1 = (NGramData)data1;
            NGramData dt2 = (NGramData)data2;
            double temp = 0;
            //Создаю таблицу всех триграмм
            foreach (var x in dt1.ABC[dt1.Settings["Current ABC"]])
            {
                foreach (var y in dt1.ABC[dt1.Settings["Current ABC"]])
                {
                    foreach (var z in dt1.ABC[dt1.Settings["Current ABC"]])
                    {
                        if (dt1.NGramFrequencyDistribution.ContainsKey(string.Concat(x, y, z)))
                        {
                            if (dt2.NGramFrequencyDistribution.ContainsKey(string.Concat(x, y, z)))
                            {
                                temp += Math.Abs(dt1.NGramFrequencyDistribution[string.Concat(x, y, z)] - dt2.NGramFrequencyDistribution[string.Concat(x, y, z)]);
                            }
                            else
                            {
                                temp += dt1.NGramFrequencyDistribution[string.Concat(x, y, z)];
                            }
                        }
                        else
                        {
                            if (dt2.NGramFrequencyDistribution.ContainsKey(string.Concat(x, y, z)))
                            {
                                temp += dt2.NGramFrequencyDistribution[string.Concat(x, y, z)];
                            }
                        }
                        
                    }
                }
            }

            return temp;
        }
    }
}
