using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileCalculator
{
    class Program
    {
        public static Decimal GetInputDecimal(string message)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine(message);

                    string input = Console.ReadLine();

                    decimal response = decimal.Parse(input);

                    return response;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Error: Answer must be in numerical form.");
                
                }
            }


        }
        
        public static void Main()
        {
          
                    decimal width = GetInputDecimal("What is the width? (ft)");

                    decimal length = GetInputDecimal("What is the length? (ft)");

                    decimal tiles = GetInputDecimal("What is the size of a tile? (ft2)");

                    decimal price = GetInputDecimal("How much per tile? ($)");

                    decimal area = width * length;

                    decimal number = area / tiles;

                    decimal cost = number * price;

                    Console.WriteLine("Area to tile: " + area);

                    Console.WriteLine("Required # of tiles: " + number);

                    Console.WriteLine("Total Cost: $" + cost);

                    Console.ReadLine();
                }
                                 
                }
            }
       
       