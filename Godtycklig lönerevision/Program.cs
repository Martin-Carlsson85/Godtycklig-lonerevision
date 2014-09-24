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
           
            int numberOfSalaries = 0;
           
           
            do
            {
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

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tryck tangent för ny beräkning - Escape avslutar.");
                Console.ResetColor();

                numberOfSalaries = 0;

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }


        static void ProcessSalaries(int count)
        {
            
            int countSalaries = 0;
            int totalSalary = 0;
            int medianSalary = 0;
            int averageSalary = 0;
            int maxSalary = 0;
            int minSalary = 0;
            int salarySpred = 0;

            int[] salaries = new int[count];
            int[] salariesSorted = new int[count];

            for (int i = 0; i < count; i++) 
            {
                salaries[i] = ReadInt(String.Format("Ange lön nummer {0}: ", i + 1));

                totalSalary += salaries[i];

                salariesSorted[i] = salaries[i];

            }

            Array.Sort(salariesSorted);

            maxSalary = salariesSorted.Max();
            minSalary = salariesSorted.Min();
            salarySpred = maxSalary - minSalary;
            averageSalary = totalSalary / count;

            countSalaries = salariesSorted.Count();

            int l = salariesSorted.Count() / 2;

            if (countSalaries % 2 == 0)
            {
                medianSalary = (salariesSorted[l - 1] + salariesSorted[l]) / 2;
            }

            else
            {
                medianSalary = salariesSorted[l];
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Medianlön:               {0:c0}", medianSalary);
            Console.WriteLine("Medellön:                {0:c0}", averageSalary);
            Console.WriteLine("Lönespridning:           {0:c0}", salarySpred);
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            for (int i = 1; i <= count; i++)
            {
                Console.Write("{0,5}   ", salaries[i - 1]);

                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }

            }


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
                        Console.Write(prompt);
                        input = Console.ReadLine();
                        ReadInt = int.Parse(input);

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
            
                    
            
                

                return ReadInt;

        }



    }
}


     

