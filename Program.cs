using System;

namespace TextAuthorizerNC
{

    class Program
    {

        static void Main(string[] args)
        {
            DataTEST data = new DataTEST();
            data.data = "Шла Саша по шоссе и сосала сушку.";
            NormalTEST nt = new NormalTEST();
            TokenTEST tt = new TokenTEST();
            AlgTEST at = new AlgTEST();
            FullAlgorithm fa = new FullAlgorithm();
            fa.EnqueueStep(nt);
            fa.EnqueueStep(tt);
            fa.EnqueueStep(at);
            fa.Execute(data);
        }
    }
}
