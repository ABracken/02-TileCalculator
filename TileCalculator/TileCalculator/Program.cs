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
            while (true)
            {
                try
                {
                    Console.WriteLine(message);

                    string input = Console.ReadLine();

                    decimal response = decimal.Parse(input);

                    return response;
                }
                catch (Exception b)
                {
                    Console.Clear();
                    Console.WriteLine("Error: Answer must be in numerical form.");

                }
            }


        }
        public static string GetShape(string message)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(message);

                    string input = Console.ReadLine();

                    if (input == "Square" || input == "Rectangle" 
                        || input == "Triangle" || input == "Circle")
                    {

                        return input;

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception a)
                {
                    Console.Clear();
                    Console.WriteLine("Error: Answer written incorrectly");
                                     
                }
                
            }
        }
                    
                    
        public static void Main()
        {

            {
                string str = GetShape("Square, Rectangle, Triangle or Circle?");
                
                switch (str)
                    { 
                case "Square":
                case "Rectangle":
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

                    break;

                case "Triangle":
                    decimal height = GetInputDecimal("What is the height? (ft)");

                    decimal tbase = GetInputDecimal("What is the base? (ft)");

                    decimal tilet = GetInputDecimal("What is the size of a tile? (ft2)");

                    decimal dollar = GetInputDecimal("How much per tile? ($)");

                    decimal tarea = height * tbase / 2;

                    decimal tnumber = tarea / tilet;

                    decimal tcost = tnumber * dollar;

                    Console.WriteLine("Area to tile: " + tarea);

                    Console.WriteLine("Required # of tiles: " + tnumber);

                    Console.WriteLine("Total Cost: $" + tcost);

                    Console.ReadLine();

                    break;

                case "Circle":
                    decimal radius = GetInputDecimal("What is the radius? (ft)");

                    decimal tiler = GetInputDecimal("What is the size of a tile? (ft2)");

                    decimal money = GetInputDecimal("How much per tile? ($)");

                    decimal radius2 = radius * radius;

                    decimal pie = 3.14M;

                    decimal rarea = pie * radius2;

                    decimal rnumber = rarea / tiler;

                    decimal rcost = rnumber * money;

                    Console.WriteLine("Area to tile: " + rarea);

                    Console.WriteLine("Required # of tiles: " + rnumber);

                    Console.WriteLine("Total Cost: $" + rcost);

                    Console.ReadLine();
                    break;
                }
            }

        }
    }
}
       
       