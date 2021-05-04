using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAuthorizerNC
{
    class FullAlgorithm : IFullAlgorithm
    {
        private System.Collections.Generic.Queue<IAlgorithmStep> queue = new Queue<IAlgorithmStep>();

        public void DequeueStep()
        {
            this.queue.Dequeue();
        }

        public void DoStep(IAlgorithmData data)
        {
            this.queue.Dequeue().Execute(data);
        }

        public void EnqueueStep(IAlgorithmStep step)
        {
            throw new NotImplementedException();
        }

        public void Execute(IAlgorithmData data)
        {
            while (this.queue.Count > 0)
            {
                this.queue.Dequeue().Execute(data);
            }
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

    }
}
