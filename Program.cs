using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 
            //    are divisible by 3 with no remainder.
            //    Display the count on the console.
            //var count = 0;
            //for (var i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //2 - Write a program and continuously ask the user to 
            //    enter a number or "ok" to exit. Calculate the sum of 
            //    all the previously entered numbers and display it on the console.
            //int sumOfNum = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number, or type \"ok\" to exit with the sum of entered numbers. ");
            //    var input = Console.ReadLine();
            //    int userNum;
            //    bool isNum = int.TryParse(input, out userNum);

            //    if (isNum)
            //    {
            //        sumOfNum += userNum;
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your sum is: " + sumOfNum);
            //        break;
            //    }
            //}

            //3 - Write a program and ask the user to enter a number. Compute the 
            //    factorial of the number and print it on the console. For example, 
            //    if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            //    and display it as 5! = 120.

            //Console.Write("Enter a number: ");
            //var input = Int32.Parse(Console.ReadLine());
            //var factorial = input;
            //for (var i = (input - 1); i >= 1; i--)
            //{
            //    input *= i;
            //}
            //Console.WriteLine("Your factorial is: " + factorial + "! = " + input);

            //4 - Write a program that picks a random number between 1 and 10.
            //    Give the user 4 chances to guess the number.If the user guesses 
            //    the number, display “You won"; otherwise, display “You lost". 
            //    (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //var random = new Random();
            //var numToGuess = random.Next(1, 10);
            //var chances = 4;
            //Console.WriteLine(numToGuess);

            //while (chances > 0)
            //{
            //    Console.Write("Guess a number between 1 and 10. You have " + chances + " guesses. ");
            //    var input = Int32.Parse(Console.ReadLine());
            //    if (input == numToGuess)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    else
            //    {
            //        chances--;
            //        continue;
            //    }

            //}
            //if (chances == 0)
            //{
            //    Console.WriteLine("You Lost");
            //}

            //5 - Write a program and ask the user to enter a series of numbers 
            //    separated by comma.Find the maximum of the numbers and display it 
            //    on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.Write("Enter a series of numbers: ");
            var input = Console.ReadLine();
            var numArray = input.Split(',');
            var newArray = Array.ConvertAll(numArray, int.Parse);
            var maxNum = newArray.Max();
            Console.WriteLine("Your max number is: " + maxNum);

        }
    }
}
