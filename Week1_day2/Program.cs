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
            // Characters or chars are single letters or numbers or symbols

            bool isTired = true;
            // Boolean or bool is true or false
            // Bool defaults to true unless a value is declared

            //Other number data types
            float number = 2.16440330490729484938961932f;
            decimal partialNum = 2.16440330490729484938961932m;
            double someNumber = 2.16440330490729484938961932d;
            // Double - technically don't need to add the 'd'
            // Float 6 places to the right; drops the rest, but does round
            // Decimal many more places to the right
            // Double somewhere between Float and Decimal


            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            // Now let's talk about operators!
            // ARITHMETIC
            // + adds to operands
            // - subtracts the second operand from the first
            // * multiplies both operands
            // / divides the first operand by the second operand
            // % - Modulus - divides and checks remainder
            // ++ increments - increases operand by one and is used for ints
            // -- decrements - decreases value by one

            // RELATIONAL OPERATORS
            // == Checks if the values of two operands are equal
            // and if they are equal, returns bool true
            // != Checks if values of two operands are equal or not
            // and if vaules are NOT equal, returns bool true

            int jarrydAge = 32;
            int danielAge = 29;
            Console.WriteLine(jarrydAge == danielAge);

            /*
             * > Checks if the value of the left operand is
             * greater than the value of the right operand, 
             * and if yes, then condition is true.
             * 
             * < Checks if the value of the left operand is 
             * less than the vaule of the right operand, 
             * and if yes, then condition is true.
             * 
             * >= Checks if the value of the left operand is 
             * greater than or equal to the value of the right operand,
             * and if yes, then condition becomes true.
             * 
             * <= Checks if the value of the left operand is 
             * less than or equal to the value of the right operand,
             * and if yes, then condition becomes true.
             */

            // LOGICAL OPERATORS
            /*
             * && We call AND operator. If both the operands are non-zero,
             * then the condition becomes true.
             * 
             * || We call OR operator. If any of the two operands is non-zero, 
             * then the condition becomes true.
             * 
             * ! We call NOT operator. This is used to reverse 
             * the logical state of the operand. If a condition is true, 
             * then Logical NOT operator will make false.
             */
          

        }
    }
}
