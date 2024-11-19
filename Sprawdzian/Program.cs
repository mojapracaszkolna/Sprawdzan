using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            for (int i = 0; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Kończę zadanie 1");
        }
       
        static void PrintTriangle(int h) // zadanie 2//
        {

            string znak = "$";

            for (int i = 0;i < h;i++) 
            {
                for (int j = 0; j == h; j++) ;
                {
                    Console.Write("");
                }
                Console.WriteLine(znak);
                znak += "$$";

        }
         

        
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;

                // tutaj rozwiązanie zadania 3


            string finalText = "";
                if(today.Hour < 12)
                {
                    finalText = "Dzien dobry,";

                }
                else
                {
                    finalText = "Dobry wieczor";
                }
                finalText += ($"dzisjaj {today.DayOfWeek}, czyli {today.Day} dzien tygodnia");

            Console.WriteLine(finalText);


                        
                   
        }

            static double FindMaxAbsoluteValue(double[] args)
            {
                double max =0;
                foreach(double x in args)
                {if (Math.Abs(x) > max)
                    { max = x; }
                return max;

            }

        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {
                    // tutaj rozwiązanie zadań 5 oraz 6
                    // można modyfikować, zmieniać kolejność itp

                    Console.WriteLine(" podaj numer zadanie ");
                    int number = 0;
                    string input;
                    do
                    {
                        try
                        {
                            number = int.Parse(Console.ReadLine());

                            if (number == 0)
                            {
                                break;
                            }
                            else if (number == 1)
                            {
                                Zadanie_1();
                            }
                           
                            else if (number == 2)
                            {
                                Zadanie_2();
                            }
                            else if (number == 3)
                            {
                                Zadanie_3();
                            }
                            else if (number == 4)
                            {
                                Zadanie_4();
                            }
                            else 
                            {
                                Console.WriteLine("nie ma takiego zadania, wybierz ponownie.");
                            }
                           
                           catch (Exception e)
                            {
                                Console.WriteLine("to nie liczba");
                            }
                        while (number != 0 && number != 2 && number != 3 && number != 4);    
                            




                            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");

            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
            Zadanie_4();

            Console.WriteLine("Kończę pętlę.");
        }

    }
}