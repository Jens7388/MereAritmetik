using System;

namespace Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Skriv brevets vægt her, og se prisen:");
                string weightInput = Console.ReadLine();
                int.TryParse(weightInput, out int weight);
                double postage = 0;
                Console.WriteLine("Ønsker du at sende brevet som ekspres? (J/N)");
                string ekspres = Console.ReadLine();
                if(weight > 0 && weight < 20)
                {
                    postage = 5;
                }
                else if(weight >= 20 && weight < 50)
                {
                    postage = 7;
                }
                else if(weight >= 50 && weight < 100)
                {
                    postage = 10;
                }
                else if(weight >= 100 && weight < 150)
                {
                    postage = 15;
                }
                else if(weight >= 150 && weight < 200)
                {
                    postage = 20;
                }
                else if(weight == 0)
                {
                    Console.WriteLine("Ugyldig vægt! Prøv igen");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    postage = 30;
                    if(ekspres == "J" || ekspres == "j")
                    {
                        postage += postage * 0.5;
                    }
                    Console.WriteLine($"En pakke koster {postage} kr at sende.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if(ekspres == "J" || ekspres == "j")
                {
                    postage += postage * 0.5;
                }
                Console.WriteLine($"Dette brev koster {postage} kr at sende.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
