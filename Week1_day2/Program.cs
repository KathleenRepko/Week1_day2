using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // What data types have we talked about so far?
            // An int is a whole number (no decimals)
            // A string is a collection of characters

            char firstInitial = 'K'; 
            // Charactors or chars are single letters or numbers or symbols

            bool isTired = true;
            // Boolean or bool is true or false
            // Bool defaults to true unless a value is declared

            //Other number data types
            float number = 2.16440330490729484938961932f;
            decimal partialNum = 2.16440330490729484938961932m;
            double someNumber = 2.16440330490729484938961932d;
            // Double - technically don't need to add the 'd'.

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);
        }
    }
}
