using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    class Program
    {

        static int Cube(int x)
        {

            x = Convert.ToInt32(Math.Pow(Convert.ToDouble(x), 3));

            return x;

        }

        static int Square(int x)
        {

            x = Convert.ToInt32(Math.Pow(Convert.ToDouble(x), 2));

            return x;

        }

        static void UnlimitedPower(int x)
        {

            Console.WriteLine($"|{x,-8}|{Square(x),-11}|{Cube(x), -12}");

            return;

        }

        static void Main(string[] args)
        {

            int number;
            char agree = 'y';

            Console.WriteLine("Welcome to the very limited powers program.\n Those without the rank of master should take a seat.");
            Console.WriteLine("Please enter an integer: ");

            while(char.ToLower(agree) == 'y')
            {

                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Number   Squared     Cubed");
                for (int i = 1; i <= number; i++)
                {

                    UnlimitedPower(i);

                }

                Console.WriteLine("Would you like to continue?(Y/N)");
                agree = char.ToLower(char.Parse(Console.ReadLine()));

            }

        }

    }

}
