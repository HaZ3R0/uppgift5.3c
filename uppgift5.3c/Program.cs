using System;
using System.ComponentModel.Design;

namespace uppgift5._3c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "1.plus", "2.gånger", "3.minus", "4.delat" };
            int[] svaren = { 5, 6, 7, 8 };

            Console.WriteLine("Välj ett av alternativen");
            for (int i = 0; i < frågor.Length; i++)
            {
                Console.WriteLine(frågor[i]);
            }
            string svartext = Console.ReadLine();
            int svar = int.Parse(svartext);
            if (svar == 1)
            {
                int fråga1 = 0;
                while (fråga1 != svaren[0])
                {
                    Console.WriteLine("Vad blir 2 + 3?");
                    string fråga1text = Console.ReadLine();
                    fråga1 = int.Parse(fråga1text);
                    if(fråga1 != svaren[0])
                    {
                        Console.WriteLine("Fel gissa igen");
                    }
                }
                Console.WriteLine("Rätt");
            }
            else if (svar == 2)
            {
                int fråga1 = 0;
                while (fråga1 != svaren[1])
                {
                    Console.WriteLine("Vad blir 2 * 3?");
                    string fråga1text = Console.ReadLine();
                    fråga1 = int.Parse(fråga1text);
                    if (fråga1 != svaren[1])
                    {
                        Console.WriteLine("Fel gissa igen");
                    }
                }
                Console.WriteLine("Rätt");
            }
            else if (svar == 3)
            {
                int fråga1 = 0;
                while (fråga1 != svaren[2])
                {
                    Console.WriteLine("Vad blir 10 - 3?");
                    string fråga1text = Console.ReadLine();
                    fråga1 = int.Parse(fråga1text);
                    if (fråga1 != svaren[2])
                    {
                        Console.WriteLine("Fel gissa igen");
                    }
                }
                Console.WriteLine("Rätt");
            }
            else if (svar == 4)
            {
                int fråga1 = 0;
                while (fråga1 != svaren[3])
                {
                    Console.WriteLine("Vad blir 16 / 2?");
                    string fråga1text = Console.ReadLine();
                    fråga1 = int.Parse(fråga1text);
                    if (fråga1 != svaren[3])
                    {
                        Console.WriteLine("Fel gissa igen");
                    }
                }
                Console.WriteLine("Rätt");
            }
            else
            {
                Console.WriteLine("Du måste välje ett av alternativen");
            }
           
        }   
    }
}