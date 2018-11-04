using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
    {
        class Multiplication
        {

            //Main method used and begins execution of C# app
            /*The difference between integr type variables, and a double 
             * variable is that double variables deal with decimal points*/
            /*To read the value of an instance variable, we create method calles a get accessor.
             * To assign a value to an instance variable, we use a method call a set Accessor
             * Objects a bitd of reusable software componets, they are divided into class,
             * and yes it is possible to  have multiple classes
             */
            static void Main()
            {
                Console.WriteLine("Hello World\nFrom Mindy Klem");
                Console.WriteLine("Press Enter To Start Multiplication Program");
                Console.ReadLine();

                int number1; //declare first number to multiply
                int number2; //declare second number to multiply
                int product; //declare product of number1 and number2

                Console.Write("Enter First Integer:"); //propmt user
                                                       //read first number from user
                number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Second Integr:"); // prompt user
                                                       //read second number from user
                number2 = int.Parse(Console.ReadLine());

                product = number1 * number2; // multiply numbers
                Console.WriteLine("The Product is...");
                Console.WriteLine(number1 * number2); // display product
                Console.WriteLine("Hello World         From Mindy Klem");
                Console.Write("Press any key to cotinue...");

                Console.ReadKey(true);
            }// end Main
        }// end claas Multiplication 
    } 
