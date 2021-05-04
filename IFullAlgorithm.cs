using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    interface IFullAlgorithm: IAlgorithmStep
    {
        void EnqueueStep(IAlgorithmStep step);
        void DequeueStep();
        int GetCount();
        void DoStep(IAlgorithmData data);

    }
}
