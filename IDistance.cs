using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    interface IDistance
    {
        double Distance(IAlgorithmData data1, IAlgorithmData data2);
    }
}
