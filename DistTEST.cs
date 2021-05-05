using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class DistTEST : IDistance
    {
        public double Distance(IAlgorithmData data1, IAlgorithmData data2)
        {
            double temp = 0;
            DataTEST dt1 = (DataTEST)data1;
            DataTEST dt2 = (DataTEST)data2;
            foreach (var item in dt1.ngram)
            {
                if (dt2.ngram.ContainsKey(item.Key))
                {
                    temp += Math.Abs(item.Value - dt2.ngram[item.Key]);
                }
                else
                {
                    temp += item.Value;
                }
            }
            Console.WriteLine("Distance from "+dt1.name+" to "+ dt2.name+" = " + temp);
            return temp;
        }
    }
}
