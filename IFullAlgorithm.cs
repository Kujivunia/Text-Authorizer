using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    interface IFullAlgorithm: IAlgorithmStep
    {
        void AddStep(IAlgorithmStep step);
        void RemoveStepAt(int i);
    }
}
