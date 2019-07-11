using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            {
                // Get the values
                Console.WriteLine("Please enter the width of the room: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the length of the room: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room: ");
                double height = Convert.ToDouble(Console.ReadLine());

                // Formulas
                double area = width * length;
                double perim = (width * 2) + (length * 2);
                double volume = width * length * height;

                // Write the results
                Console.WriteLine("The area is " + area);
                Console.WriteLine("The perimeter is " + perim);
                Console.WriteLine("The volume is " + volume);

                Console.WriteLine("Continue? y/n : ");
                string contEnter = Console.ReadLine();

                // Check if they want to continue
                if (contEnter == "y" || contEnter == "Y")
                {
                    cont = true;
                }
                else if (contEnter == "n" || contEnter == "N")
                {
                    cont = false;
                }


            }
           
        }
    }
}
