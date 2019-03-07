using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("***********TASK 1**************");

            Console.WriteLine("\nPlease enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("The two numbers you entered are equal.");

            else if (num1 > num2)
                Console.WriteLine($"The first number you entered, {num1}, is the larger of the two.");

            else
                Console.WriteLine($"The second number entered, {num2}, is the larger of the two.");

            Console.WriteLine("Task 1 is finished. Please press enter to continue");
            Console.ReadLine();
            


            Console.WriteLine("********TASK 2 - GUESS MY NUMBER*******");
            /*Use this to choose your own number for them to guess
            int myNum = 6;

            /*use random to generate a random number each time
            Random rand = new Random();
            int num2 = rand.Next(1, 11);

            Console.WriteLine("\nIm thinking of a number between 1 and 10, can you guess what it is?");
            int userNum = int.Parse(Console.ReadLine());

            if (userNum == num2)
                Console.WriteLine("Mind reader! You guess right! :-D ");

            else
            {
                if (userNum < num2)
                    Console.WriteLine("Sorry, too high");
                else if (userNum > num2)
                    Console.WriteLine("Oops, too Low");
            }



            Console.WriteLine("\nThanks for playing, please press enter to continue... :)");
            Console.ReadLine();

            */

                        Console.WriteLine("****************TASK 3****************");

            Console.WriteLine("\nHello! Please enter your grade out of 100");
            int mark = int.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("You got an A+");

            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("You got an A");

            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("You got an B+");

            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("You got an B");

            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("You got an C");

            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("You got an D");

            else if (mark >= 0 && mark <= 39)
                Console.WriteLine("You got an F");

            else
                Console.WriteLine("There was a problem with the mark you entered");


            Console.WriteLine("\nThanks, Task 3 is now finished. Press enter to continue..");
            Console.ReadLine();





        }
    }
}
