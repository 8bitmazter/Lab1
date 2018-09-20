using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers with the same amount of digits(ex. 1234, 1234)");
            DigitAdder(Console.ReadLine(), Console.ReadLine());
            Console.ReadKey();
            
        }

        public static void DigitAdder(string number1, string number2)
        {
            if( number1.Length != number2.Length)
            {
                //if the digits don't match this code will run
                Console.WriteLine("Please choose two numbers with the same amount of digits.");
            }
            else
            {
                //Created the variables for the digits with i & y
                int i = 0, y = 1;

                while (i < number1.Length && y < number1.Length)
                {

                    char digits1 = number1[i];
                    char digits2 = number2[i];
                    char digits3 = number1[y];
                    char digits4 = number2[y];

                    int digitNum1 = (int)char.GetNumericValue(digits1);
                    int digitNum2 = (int)char.GetNumericValue(digits2);
                    int digitNum3 = (int)char.GetNumericValue(digits3);
                    int digitNum4 = (int)char.GetNumericValue(digits4);
                    i = i + 1;
                    y = y + 1;
                    //created a new int for easier read
                    int sum1 = digitNum1 + digitNum2;
                    int sum2 = digitNum3 + digitNum4;

                    if (sum1 == sum2)
                    {
                        if (i == number1.Length - 1)
                        {
                            bool results = true;
                            Console.WriteLine(results);
                        }

                    }
                    else
                    {
                        bool results = false;
                        Console.WriteLine(results);
                        break;
                    }
                    }
                }
            }
        }
    }
