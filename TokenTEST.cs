using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class TokenTEST : ITokenizer
    {
        public void Execute(IAlgorithmData data)
        {
            DataTEST dt = (DataTEST)data;
            for (int i = 0; i < dt.normalized.Length - 1; i++)
            {
                dt.tokens.Add(dt.normalized[i].ToString() + dt.normalized[i + 1].ToString());
            }
            Console.Write("Tokens: ");
            foreach (var item in dt.tokens)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
