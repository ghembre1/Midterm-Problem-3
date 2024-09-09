using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hiddennumber = 57; // makes the hidden number a set number
            Console.WriteLine("Input a number"); //prompts user to input a number
            double input = 0; //makes the users input a variable

            while (input != hiddennumber) //while input doesn't equal the hidden number
            {
                input = Convert.ToDouble(Console.ReadLine());
                if (input > hiddennumber) // input greater than the hiddennumber
                {
                    Console.WriteLine("Too high!"); // prompts user too high
                }
                else if (input < hiddennumber) // input is less than hiddennumber
                {
                    Console.WriteLine("Too low!"); // prompts user too low
                }
                else  // if it is not greater than or less than
                { 
                    Console.WriteLine("Correct!"); // prompts user correct
                    break; // exits the loop
                }
               
            }
            Console.Read();
        }
    }
}
