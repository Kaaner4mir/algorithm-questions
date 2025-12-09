class Program
{
    static void Main()
    {
        #region Question 1
        // 1. Print the sum of the two entered numbers on the screen.

        //Console.Write("Enter first number: ");
        //double number1=Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //double number2=Convert.ToDouble(Console.ReadLine());

        //double sum=number1+number2;

        //Console.WriteLine($"{number1} + {number2} = {sum}");
        #endregion

        #region Question 2
        // 2. Check whether the entered number is odd or even.

        //Console.Write("Enter the number you want to check whether odd or not: ");
        //double number=Convert.ToDouble(Console.ReadLine());

        //if(number%2== 0)
        //    Console.WriteLine($"{number} is an even number.");
        //else
        //    Console.WriteLine($"{number} is an odd number.");
        #endregion

        #region Question 3
        // 3. Find the sum of numbers from 1 to 100.

        //int sum = 0;

        //for (int i = 0; i < 100; i++)
        //{
        //    sum += i;
        //}

        //Console.WriteLine($"The sum of numbers from 1 to 100 is: {sum}");
        #endregion

        #region Question 4
        // 4. Calculate the factorial of the entered number.

        //Console.Write("Enter the number you want to calculate the factorial of: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //int result = 1;

        //for(int i = number; i>0; i--)
        //{
        //    result *= i;
        //}

        //Console.WriteLine($"The factorial of {number} is: {result}");
        #endregion

        #region Question 5
        // 5. Check whether the entered number is prime.

        Console.Write("Enter the number you want to check whether prime or not: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (number < 2)
            isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{number} is a prime number.");
        else
            Console.WriteLine($"{number} is not a prime number.");
        #endregion

        #region Question 6
        // 6. Print the numbers from 1 to 10 on the screen.

        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.Write($"{i} ");
        //}
        #endregion

        #region Question 7
        // 7. Print the even numbers up to the entered number on the screen.

        //Console.Write("Enter the ceiling number: ");
        //int number=Convert.ToInt32(Console.ReadLine());

        //for (int i =0; i <= number; i+=2)
        //{
        //    Console.Write($"{i} ");
        //}
        #endregion

        #region Question 8
        // 8. Print the numbers from 1 to 50 that are divisible by 3 on the screen.

        //for (int i = 3; i <= 50; i += 3)
        //{
        //    Console.Write($"{i} ");
        //}
        #endregion

        #region Question 9
        // 9. Take 5 numbers from the user and find the largest one.

        //List<double> numbers = new List<double>();

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write("Enter a number: ");
        //    double number = Convert.ToDouble(Console.ReadLine());
        //    numbers.Add(number);
        //}

        //Console.WriteLine($"The largest number is: {numbers.Max()}");
        #endregion

        #region Question 10
        // 10. Print the multiplication table of the number obtained from the user on the screen.

        //Console.Write("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i <= number; i++)
        //{
        //    Console.WriteLine($"{number} x {i} = {number * i}");
        //}
        #endregion
    }
}