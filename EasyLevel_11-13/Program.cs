class Program
{
    public static void Main()
    {
        #region 11. Question

        //// Program that computes the GCD (greatest common divisor) of two entered numbers.
        //// Program that computes the LCM (least common multiple) of two entered numbers.

        //Console.Write("Enter the first number: ");
        //int number1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter the second number: ");
        //int number2 = Convert.ToInt32(Console.ReadLine());

        //int ebob = 1;
        //int ekok = 1;

        //int startPoint = Math.Min(number1, number2);

        //for (int i = startPoint; i > 0; i--)
        //{
        //    if (number1 % i == 0 && number2 % i == 0)
        //    {
        //        ebob = i;
        //        break;
        //    }
        //}

        //ekok = (number1 * number2) / ebob;

        //Console.WriteLine($"\nGCD (EBOB) of {number1} and {number2} is {ebob}");
        //Console.WriteLine($"LCM (EKOK) of {number1} and {number2} is {ekok}");

        #endregion

        #region 12. Question

        //// Print the Fibonacci sequence up to a given number.

        //Console.Write("Enter the limit number for the Fibonacci sequence: ");
        //int limit = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"\nFibonacci sequence up to {limit}:");

        //int a = 0;
        //int b = 1;

        //while (a <= limit)
        //{
        //    Console.Write(a + " ");

        //    int temp = a; 
        //    a = b;        
        //    b = temp + b; 
        //}

        //Console.WriteLine(); 


        #endregion

        #region 13. Question

        //// Program that lists all prime numbers between 1 and 100.

        //Console.WriteLine("Prime numbers between 1 and 100:");

        //for (int number = 2; number <= 100; number++)
        //{
        //    bool isPrime = true;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }

        //    if (isPrime)
        //        Console.Write(number + " ");
        //}


        #endregion

        #region

        //// Program that calculates the sum of cubes of numbers from 1 to n.

        //Console.Write("Enter a number: ");
        //int number=Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < number; i++)
        //{
        //    Console.WriteLine(Math.Pow(i,3));
        //}

        #endregion

        Console.ReadLine();
    }
}
