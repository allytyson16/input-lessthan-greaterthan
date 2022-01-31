using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
/* a program that prompts the user for an hourly pay rate. If the value entered is less than $7.50 
         * or greater than $49.00, display an error message, otherwise display a message indicating that the rate is
         * okay*/
		
		Console.WriteLine("What is your hourly pay rate? - ");
		double hpr = double.Parse(Console.ReadLine());
		
		if(hpr < 7.50 || hpr > 49.00)
		{
			Console.WriteLine("Error");
		}
		else
		{
			Console.WriteLine("Okay");
		}
		
        }
    }
}
