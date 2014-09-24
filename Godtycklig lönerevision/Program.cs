using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godtycklig_lönerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int numberOfSalaries = 0;
           
            while (numberOfSalaries < 2)
            {
                numberOfSalaries = ReadInt("Ange antal löner att mata in: ");

                if (numberOfSalaries < 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                    Console.ResetColor();
                }

                else
                {
                    break;
                }


            }

            ProcessSalaries(numberOfSalaries);

            Console.WriteLine();

            Console.BackgroundColor = Console.Green;
            Console.WriteLine("Tryck tangent för ny beräkning - Escape avslutar.");
            Console.ResetColor();

            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.Escape)
                {
                    return;
                }

                numberOfSalaries = 0;

                while (!exit) ;
        }


        static void ProcessSalaries(int count)
        {
            
            int countSalaries;
            int totalSalary;
            int medianSalary;
            int averageSalary;
            int maxSalary;
            int minSalary;
            int salarySpred = 0;

            int[] salaries = new int[0];
            int[] salariesSorted = new int[0];


        }
        
        static int ReadInt(string prompt)
        {
            int ReadInt = 0;
            string input = "";

                while (true)
                {

                    try
                    {

                        //Översätter inmatat värde till en int-variabel.
                        Console.Write("Ange antal löner att mata in:");
                        ReadInt = int.Parse(Console.ReadLine());

                        //If-satsen kontrollerar att summan som matas in är högre än noll.
                        if (ReadInt < 1)
                        {
                            Console.WriteLine("Du måste ange ett höre tal än 0.");
                        }

                        else
                        {

                            break;
                        }


                    }


                    catch
                    {

                        //Ifall det inte fungerade så kommer detta att köras istället.
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("FEL! {0} Det du angivet är felaktigt.", input);
                        Console.ResetColor();
                    }

                        
                }
            
                    
            
                for(int i=0; i<ReadInt; i++) 
                {
                    Console.WriteLine("Ange lön nummer {0}:", i);

                }

                return ReadInt;

        }



    }
}


     

