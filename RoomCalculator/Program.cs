using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - prompt user for length, width, height
            //2 - get user input 2 times and store it
            //3 - try to parse input into doubles
            //4 - calculater area
            //5 - calculate perimeter
            //6 - calculate carpet tiles
            //7 - calculate paint cans (both on walls and on perimeter)
            //8 - figure out if the user wishes to continue
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Welcome to the GC Room Calculator!");
                Console.WriteLine("Please input a length");
                string inputLength = Console.ReadLine();
                Console.WriteLine("Please input a width");
                string inputWidth = Console.ReadLine();
                Console.WriteLine("Please input a height");
                string inputHeight = Console.ReadLine();

                double length = double.Parse(inputLength);
                double width = double.Parse(inputWidth);
                double height = double.Parse(inputHeight);

                double area = length * width;
                double volume = length * width * height;
                double perimeter = 2 * length + 2 * width;

                double carpet = area / 5;
                double paintperimeter = perimeter / 5;
                double paintwalls = (area + 2 * length * height + 2 * width * height) / 5;

                Console.WriteLine($"Length: {length}");
                Console.WriteLine($"Width: {width}");
                Console.WriteLine($"Height: {height}");
                Console.WriteLine();
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine();
                Console.WriteLine($"Carpet Tiles: {carpet}");
                Console.WriteLine($"Paint Perimeter Cans: {paintperimeter}");
                Console.WriteLine($"Paint Cans for Walls: {paintwalls}");
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? Y/N");
                string answer = Console.ReadLine();
                //Three possibilities to check for:
                //1) Y
                //2) N
                //3) anything else

                bool askAgain = true;

                while (askAgain == true)
                {
                    Console.WriteLine("Would you like to continue? Y/N");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "y")
                    {
                        askAgain = false;
                        goOn = true;
                    }
                    else if (answer == "n")
                    {
                        askAgain = false;
                        goOn = false;
                        Console.WriteLine("Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Please try again.");
                    }
                }
            }
        }
    }
}
