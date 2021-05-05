using System;

namespace TextAuthorizerNC
{

    class Program
    {

        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new("1.txt");
            NGramData data = new();
            //data.OriginalText = new("С тех пор как Незнайка совершил путешествие в Солнечный город, прошло два с половиной года. Хотя для нас с вами это не так уж много, но для маленьких коротышек два с половиной года – срок очень большой. Наслушавшись рассказов Незнайки, Кнопочки и Пачкули Пестренького, многие коротышки тоже совершили поездку в Солнечный город, а когда возвратились, решили и у себя сделать кое-какие усовершенствования. Цветочный город изменился с тех пор так, что теперь его и не узнать. В нем появилось много новых, больших и очень красивых домов. По проекту архитектора Вертибутылкина на улице Колокольчиков было построено даже два вертящихся здания. Одно пятиэтажное, башенного типа, со спиральным спуском и плавательным бассейном вокруг (спустившись по спиральному спуску, можно было нырять прямо в воду), другое шестиэтажное, с качающимися балконами, парашютной вышкой и чертовым колесом на крыше.");
            data.OriginalText = new(sr.ReadToEnd());
            data.Settings["Current ABC"] = "ru";
            data.Settings["Trigram at least"] = "1";
            data.ABC["ru"] = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            
            NGramNormalization normal = new();
            TriGramAlgorithm alg = new();
            FullAlgorithm macro = new();
            macro.EnqueueStep(normal);
            macro.EnqueueStep(alg);
            macro.Execute(data);

            Console.Write("Dictionary: ");
            foreach (var item in data.NGramFrequencyDistribution)
            {
                    Console.Write("|" + item.Key + " " + item.Value.ToString());

            }
            Console.WriteLine();
            Console.Write("Dictionary size: " + data.NGramFrequencyDistribution.Count + " from "+ Math.Pow(33,3));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
