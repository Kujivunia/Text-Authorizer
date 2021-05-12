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
            this.queue.Enqueue(step);
        }

        public void Execute(IAlgorithmData data)
        {
            while (this.queue.Count > 0)
            {
                this.queue.Dequeue().Execute(data);
            }
        }

        public void ExecuteWithoutRemoves(IAlgorithmData data)
        {
            for (int i = 0; i < this.queue.Count; i++)
            {
                //this.queue.Peek().Execute(data);
                this.queue.ElementAt(i).Execute(data);
            }
                
            
        }

        public int GetCount()
        {
            return this.queue.Count();
        }

    }
}
