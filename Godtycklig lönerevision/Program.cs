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



        }
        
        static int ReadInt(string prompt)
        {
            int total1 = 0;
            int total2 = 0;

            while (true)
            {
                try
                {   
                    
                    //Försöker översätta inmatat värde till en int-variabel.
                    Console.Write("Ange antal löner att mata in:");
                    total1 = int.Parse(Console.ReadLine());

                    break;

                }


                catch( FormatException )
                {   
                    
                    //Ifall det inte fungerade så kommer detta att köras istället.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Det du angivet är felaktigt.");
                    Console.ResetColor();
                }

            for (int i=0; i<1000; i++ )
            {


            }


              while (true)
                {
                
                  try
                    {   
                      
                      
                    //Försöker översätta inmatat värde till en int-variabel.
                    Console.Write("Ange lön nummer 1:");
                    total2 = int.Parse(Console.ReadLine());

                    break;

                    }


                catch( FormatException )
                {   
                    
                    //Ifall det inte fungerade så kommer detta att köras istället.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Det du angivet är felaktigt.");
                    Console.ResetColor();
                }
            
            
            
            
            
            
            
            }

            
        }



    }
}


    }
}
