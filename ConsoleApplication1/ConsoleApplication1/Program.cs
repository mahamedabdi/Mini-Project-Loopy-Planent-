using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // My Variables
            int menuChoice;
            Double Weight;
            Double Weight2;
            String planet;



            // Displaying options

            Console.WriteLine("Menu of Planets");
            Console.WriteLine("===============");
            Console.WriteLine("1 Jupiter 2 Mars 3 Mercury");
            Console.WriteLine("4 Neptune 5 Pluto 6 Saturn");
            Console.WriteLine("7 Uranus 8 Venus 9<Quit>");
            Console.WriteLine("          ");

            Console.Write("Enter your menu choice: ");

            // converts menuchoice into integer so it could accept it
            menuChoice = int.Parse(Console.ReadLine());

            //if my variable menuchoice is 9 then quit and say goodbye
            if (menuChoice == 9)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                // if menuchoice is between 1 and 8 then continue with program
                while (!((menuChoice >= 1) || (menuChoice <= 8))) ;
                do
                {
                    Console.Write("Enter your weight on earth: ");

                    Weight = double.Parse(Console.ReadLine());

                } while (Weight < 0);

                switch (menuChoice)
                {
                    case 1:
                        //Rounds the calculated result by 1
                        Weight2 = Math.Round(Weight * 2.64, 1);
                        //Console.WriteLine(Weight2);
                        planet = "Jupiter";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");

                        

                       break;

                    case 2:

                        Weight2 = Math.Round(Weight * 0.38, 1);

                        planet = "Mars";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");


                        break;

                    case 3:

                        Weight2 = Math.Round(Weight * 0.37, 1);

                        planet = "Mercury";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");


                        break;

                    case 4:

                        Weight2 = Math.Round(Weight * 1.12, 1);

                        planet = "Neptune";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");


                        break;

                    case 5:

                        Weight2 = Math.Round(Weight * 0.04, 1);

                        planet = "Pluto";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");


                        break;

                    case 6:

                        Weight2 = Math.Round(Weight * 1.15, 1);

                        planet = "Saturn";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");


                        break;

                    case 7:

                        Weight2 = Math.Round(Weight * 1.15, 1);

                        planet = "Uranus";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");

                        break;

                    case 8:

                        Weight2 = Math.Round(Weight * 0.88, 1);

                        planet = "Venus";

                        Console.WriteLine("\n Your weight of " + Weight + " pounds on Earth would be " + Weight2 + " pounds on " + planet + ".");

                        break;
                }
            }
                    Console.ReadLine();
                }

            


        }
            






        }
    
