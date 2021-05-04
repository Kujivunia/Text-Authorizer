using System;

namespace TextAuthorizerNC
{
     class Test
    {
        private System.Collections.Generic.Queue<int> queue = new System.Collections.Generic.Queue<int>();
        public void AddX(int x)
        {
            queue.Enqueue(x);
        }
        public void RemoveX()
        {
            queue.Dequeue();
        }
        public void ShowX()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static public void PrintList(int ii, System.Collections.Generic.List<int> list)
        {
            for (int i = 0; i < ii; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Program.PrintList(4, list);
            Console.WriteLine("---------------------------------");
            Test test = new Test();
            test.AddX(4);
            test.AddX(2);

            test.ShowX();
            test.RemoveX();
            test.ShowX();
            Console.ReadKey();
        }
    }
}
