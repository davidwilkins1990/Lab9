using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        public static int counter = 0;
        public static void calc( )
        {
            Console.Write("Enter a radius: ");
            try
            {
                double input = double.Parse(Console.ReadLine());

                Circle circle = new Circle(input);
                counter++;
                circle.calculateArea();
                circle.calculateCircumference();

                Console.WriteLine(circle.calculateFormattedCircumference());
                Console.WriteLine(circle.calculateFormattedArea());

                Console.WriteLine("Press 'y' to continue or any other key to quit");
                string input2 = Console.ReadLine();
                again(input2);
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("\n\n****ERROR: Invalid input.*****");
                calc();
                
            }
            
        }


        public static void again (string input2)
        {
            if (input2 == "y")
            {
                calc();
            }
            else
            {
                Console.WriteLine("Goodbye. You made " + counter + " circle object(s)");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {

            

            calc();

            Console.ReadLine();
        }
    }
}
