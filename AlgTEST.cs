using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class AlgTEST : IAlgorithm
    {
        public void Execute(IAlgorithmData data)
        {
            DataTEST dt = (DataTEST)data;
            foreach (var item in dt.tokens)
            {
                dt.ngram.TryAdd(item,0);
            }
            foreach (var item in dt.tokens)
            {
                dt.ngram[item] = dt.ngram[item]+1;
            }
            dt.tokens =  dt.tokens.Distinct().ToList<string>();
            foreach (var item in dt.tokens)
            {
                dt.ngram[item] /= dt.ngram.Count();
            }
            Console.Write("Dictionary: ");
            foreach (var item in dt.tokens)
            {
                Console.Write("|"+item+" "+dt.ngram[item].ToString().Substring(0,5)+"|");
            }
            Console.WriteLine();
        }
    }
}
