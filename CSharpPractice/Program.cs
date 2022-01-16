using System;

namespace CSharpPractice
{
    public class MiniPrograms
    {
        public void Fibonacci()
        {
            int firstNumber=0, secondNumber=1, sum, inputNumber;
            Console.WriteLine("Fibonacci Series");
            Console.Write("Enter Number of Elements: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstNumber + " " + secondNumber + " ");

            for(var i=2; i < inputNumber; i++)
            {
                sum = firstNumber + secondNumber;
                Console.Write(sum + " ");
                firstNumber = secondNumber;
                secondNumber = sum;
            }
        }

        public void PrimeCheck()
        {
            int flag = 0;
            Console.Write("Enter your Number to check Prime: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            
            for(var i=2; i <= inputNumber / 2; i++)
            {
                if(inputNumber%i == 0)
                {
                    Console.WriteLine("Not Prime");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
        }

        public void PalindromeNumberCheck()
        {
            int temp, reminder, sum = 0;
            Console.Write("Enter your Number to Check Palindrome: ");
            int inputNumnber = Convert.ToInt32(Console.ReadLine());
            temp = inputNumnber;
            while (inputNumnber > 0)
            {
                reminder = inputNumnber % 10;
                sum = (sum * 10) + reminder;
                inputNumnber = inputNumnber / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }

        public void TakeInputInArray()
        {
            Console.Write("Enter Size of an Array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            for(var i=0; i<array.Length; i++)
            {
                Console.Write("Enter Array Index " + i + ": ");
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Your Array: ");
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
            
        }

        public void Factorial()
        {
            int result = 1;
            Console.Write("Enter Number for Factorial: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            for(var i=1; i<=inputNumber; i++)
            {
                result *= i;
            }
            Console.WriteLine("Factorial of " + inputNumber + " is: " + result);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Exercises for Programmers");
            Console.WriteLine("1- Fibonacci Series");
            Console.WriteLine("2- Prime Checker");
            Console.WriteLine("3- Palindrome Checker for Numbers");
            Console.WriteLine("4- Take Input in Array");
            Console.WriteLine("5- Factorial");
            Console.WriteLine("0- Close Program");
           
            Console.Write("Enter your Number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            MiniPrograms program = new MiniPrograms();

            if (userInput == 1)
            {
                program.Fibonacci();
            }
            else if (userInput == 2)
            {
                program.PrimeCheck();
            }
            else if (userInput == 3)
            {
                program.PalindromeNumberCheck();
            }
            else if (userInput == 4)
            {
                program.TakeInputInArray();
            }
            else if (userInput == 5)
            {
                program.Factorial();
            }
            else if(userInput == 0)
            {
                Environment.Exit(0);
            }
            Console.WriteLine("\n\n");
            Main();
            
        }
    }
}
