using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double principle = 0;
            double years = 0;
            double interest = 0;
            string principleInput, yearsInput, interestInput;

            Console.WriteLine("Enter loan amount in dollars...");
            principleInput = Console.ReadLine();
            principle = double.Parse(principleInput);
            if (principle < 1000)
            {
                Console.WriteLine("You got a mortgage for that much? Please enter a more realistic amount");
                principle = 0;
            }

            // years
            Console.WriteLine("Enter the length of the loan in years...");
            yearsInput = Console.ReadLine();
            years = double.Parse(yearsInput);
            if (years < 1)
            {
                Console.WriteLine("Please enter a valid length");
                years = 0;
            }

            // interest rate
            Console.WriteLine("Enter your interest rate...");
            interestInput = Console.ReadLine();
            interest = double.Parse(interestInput);
            if (interest < 0)
            {
                Console.WriteLine("Dang, how'd you get that rate? Please enter a rate greater than zero...");
                interest = 0;
            }

            // calculate the monthly payment
            double loan = (interest / 1200.0);
            double numMonths = years * 12;
            double negNumMonths = 0 - numMonths;
            double monthlyPymt = principle * loan / (1 - System.Math.Pow((1 + loan), negNumMonths));

            // output
            Console.WriteLine(string.Format("Monthly payment: {0}{1:0.00}", "$", monthlyPymt));
            Console.ReadLine();


        }
    }
}
