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
            numberConversion();


            //static void means the function will not return a value so it does not need a data type 
            //...this function DOES return a value so the method must have a data type
            void numberConversion()
            {
                bool integer = false;
                string NumEntered = null;
                while (integer == false)
                {
                    int s = 0;
                    NumEntered = null;
                    Console.WriteLine("Enter a whole denary number that is less than 10 digits");
                    NumEntered = Console.ReadLine();
                    integer = int.TryParse(NumEntered, out s);
                }
                int[] remainder = { 5656 };
                int denary = Convert.ToInt32(NumEntered);
                int counter = 0;
                while (denary > 0)
                {
                    Array.Resize(ref remainder, counter + 1);
                    remainder[counter] = denary % 2;
                    //Console.WriteLine(remainder[counter]);
                    denary /= 2;
                    //Console.WriteLine(denary);
                    counter++;
                    //Console.WriteLine(counter);
                }
                if (remainder[0] == 5656)
                {
                    Console.WriteLine(0);
                }
                else
                {


                    int[] binary = { };
                    Array.Resize(ref binary, remainder.Length);
                    Array.Reverse(remainder);
                    for (int i = 0; i < remainder.Length; i++)
                    {
                        binary[i] = remainder[i];
                        //Console.WriteLine(binary[i]);
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
}
