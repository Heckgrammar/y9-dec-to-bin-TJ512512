using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 8; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int
            string MyIntAsString = Convert.ToString(myInt);
            Console.WriteLine(MyIntAsString);
            string concatString = String.Concat("This is a", " concatenated string");
            Console.WriteLine(concatString);

            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine("Enter the denary number");
            numberConversion();


            //static void means the function will not return a value so it does not need a data type 
            //...this function DOES return a value so the method must have a data type
             void numberConversion()
            {
                int[] remainder = { 5656 };
                int denary = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                while (denary > 0)
                {
                    Array.Resize(ref remainder, counter + 1);
                    remainder[counter] = denary % 2;
                    Console.WriteLine(remainder[counter]);
                    denary /= 2;
                    counter++;
                }
                int[] binary = { };
                Array.Resize(ref binary, remainder.Length);
                Array.Reverse(remainder);
                for (int i = 0; i < remainder.Length; i++)
                {
                    binary[i] = remainder[i];
                }
                for (int i = 0; i < binary.Length; i++)
                {
                    Console.Write(binary[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
