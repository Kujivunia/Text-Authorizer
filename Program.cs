using System;

namespace TextAuthorizerNC
{

    class Program
    {

        static void Main(string[] args)
        {
            DataTEST data = new DataTEST();
            data.data = "Шла Саша по шоссе и сосала сушку.";
            data.name = "First";
            NormalTEST nt = new NormalTEST();
            TokenTEST tt = new TokenTEST();
            AlgTEST at = new AlgTEST();
            FullAlgorithm fa = new FullAlgorithm();
            fa.EnqueueStep(nt);
            fa.EnqueueStep(tt);
            fa.EnqueueStep(at);
            fa.Execute(data);
            Console.WriteLine("*** *** ***");
            DataTEST data2 = new DataTEST();
            //data2.data = "Карл у Клары украл кораллы, а Клара у Карла украла кларнет.";
            //data2.data = "Шла Саша по шоссе, а Карл у Клары украл Кларнет.";
            data2.data = "Шла Саша по шоссе и сосала сушку. Она ещё не знала, что Карл у Клары украл кораллы, а Клара у Карла украла кларнет.";
            data2.name = "Second";
            NormalTEST nt2 = new NormalTEST();
            TokenTEST tt2 = new TokenTEST();
            AlgTEST at2 = new AlgTEST();
            FullAlgorithm fa2 = new FullAlgorithm();
            fa2.EnqueueStep(nt2);
            fa2.EnqueueStep(tt2);
            fa2.EnqueueStep(at2);
            fa2.Execute(data2);
            Console.WriteLine("*** *** ***");
            DistTEST dt = new DistTEST();
            dt.Distance(data, data2);
        }
    }
}
