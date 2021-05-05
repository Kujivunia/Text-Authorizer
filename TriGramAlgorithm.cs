using System;
using System.Linq;

namespace TextAuthorizerNC
{
    class TriGramAlgorithm: IAlgorithm
    {
        public void Execute(IAlgorithmData data)
        {
            NGramData dt = (NGramData)data;

            //Создаю таблицу всех триграмм
            foreach (var x in dt.ABC[dt.Settings["Current ABC"]])
            {
                foreach (var y in dt.ABC[dt.Settings["Current ABC"]])
                {
                    foreach (var z in dt.ABC[dt.Settings["Current ABC"]])
                    {
                        dt.NGramFrequencyDistribution.TryAdd(string.Concat(x, y, z), 0);
                    }
                }
            }
            //Заполняю таблицу триграмм по данным из текста
            for (int i = 0; i < dt.NormalizedText.Length-2; i++)
            {
                string key = string.Concat(dt.NormalizedText[i], dt.NormalizedText[i + 1], dt.NormalizedText[i + 2]);
                if (dt.NGramFrequencyDistribution.ContainsKey(key))
                {
                    dt.NGramFrequencyDistribution[key] += 1;
                }
                
            }
            // Очищаю таблицу от пустых н-грамм и превращаю в таблицу частотного распределния триграмм. 
            foreach (var x in dt.ABC[dt.Settings["Current ABC"]])
            {
                foreach (var y in dt.ABC[dt.Settings["Current ABC"]])
                {
                    foreach (var z in dt.ABC[dt.Settings["Current ABC"]])
                    {
                        if (dt.NGramFrequencyDistribution[string.Concat(x, y, z)] < int.Parse(dt.Settings["Trigram at least"]))
                        {
                            dt.NGramFrequencyDistribution.Remove(string.Concat(x, y, z));
                        }
                        else
                        {
                            dt.NGramFrequencyDistribution[string.Concat(x, y, z)] /= dt.NormalizedText.Length-2;
                        }
                        
                    }
                }
            }


        }
    }
}
