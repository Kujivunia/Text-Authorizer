using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class NormalTEST : INormalization
    {
        public void Execute(IAlgorithmData data)
        {
            DataTEST dt = (DataTEST)data;
            Console.WriteLine("Original: "+dt.data);
            dt.normalized = dt.data.ToLower();
            dt.normalized = dt.normalized.Replace(" ","");
            dt.normalized = dt.normalized.Replace(".","");
            dt.normalized = dt.normalized.Replace(",", "");
            Console.WriteLine("Normalized: "+dt.normalized);
        }
    }
}
