class Program
{
    public static void Main()
    {
        #region Question 1
        // 1. Display the reverse of the entered word on the screen.

        //Console.Write("Enter the text: ");
        //string text = Console.ReadLine();

        //for (int i = text.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(text[i]);
        //}
        #endregion

        #region Question 2
        // 2. Find out how many words the entered sentence contains.

        //Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();

        //int count = 1;

        //for (int i = 0; i < sentence.Length; i++)
        //{
        //    if (sentence[i] == ' ')
        //    {
        //        count++;
        //    }
        //}

        //Console.WriteLine($"\nThe sentence contains {count} words.");
        #endregion

        #region Question 3
        // 3. Check whether the entered word is a palindrome.

        //Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();

        //string reversedSentence = "";

        //for (int i = sentence.Length-1; i>=0; i--)
        //{
        //    reversedSentence+= sentence[i];
        //}

        //if(sentence==reversedSentence)
        //    Console.WriteLine($"{sentence} is a palindrome.");
        //else
        //    Console.WriteLine($"{sentence} is not a palindrome.");

        #endregion

        #region Question 4
        // 4. Find the number of spaces in the entered sentence.

        //Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();

        //int spaceCount = 0;

        //for(int i=0;i<sentence.Length; i++)
        //{
        //    if (sentence[i] == ' ')
        //    {
        //        spaceCount++;
        //    }
        //}

        //Console.WriteLine($"The number of spaces in the sentence is: {spaceCount}");
        #endregion

        #region Question 5
        // 5. Display the first and last letters of the entered word on the screen.

        //Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();

        //char firstLetter = sentence[0];
        //char lastLetter = sentence[sentence.Length - 1];

        //Console.WriteLine($"The first letter is: {firstLetter}\n" +
        //                  $"The last letter is : {lastLetter}");

        #endregion

        #region Question 6
        // 6. Find the largest number in a sequence.

        //int[] numbers= { 45, 23, 67, 12, 89, 5, 34 };

        //int largestNumber = numbers[0];

        //for(int i=1; i<numbers.Length; i++)
        //{
        //    if(numbers[i]> largestNumber)
        //    {
        //        largestNumber = numbers[i];
        //    }
        //}

        //Console.WriteLine($"The largest number is : {largestNumber}.");
        #endregion

        #region Question 7
        // 7. Calculate the average of the numbers in a sequence.

        //int[] numbers = { 45, 23, 67, 12, 89, 5, 34 };

        //int sum = 0;

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}

        //double average = sum/ numbers.Length;

        //Console.WriteLine($"The average is : {average}.");
        #endregion

        #region Question 8
        // 8. Find the repeating elements in a sequence.

        //int[]numbers= { 45, 23, 67, 12, 89, 5, 34, 23, 67, 89 };

        //for(int i=0; i<numbers.Length; i++)
        //{
        //    for(int j=i+1; j<numbers.Length; j++)
        //    {
        //        if(numbers[i]== numbers[j])
        //        {
        //            Console.WriteLine($"Repeating element found: {numbers[i]}");
        //        }
        //    }
        //}

        #endregion

        #region Question 9

        //int[] numbers = { 45, 12, 89, 5, 23, 1 };

        //Array.Sort(numbers);

        //Console.WriteLine("Sorted Series (Smallest to Largest):");

        //foreach (int number in numbers)
        //{
        //    Console.Write(number + " ");
        //}
        #endregion

        #region Question 10
        // 10. Add the 5 words received from the user to a list and print them to the screen.

        //List<string> word = new List<string>();

        //for(int i=0; i<5; i++)
        //{
        //    Console.Write("Enter a word: ");
        //    string inputWord = Console.ReadLine();
        //    word.Add(inputWord);
        //}

        //foreach(string w in word)
        //{
        //    Console.WriteLine(w);
        //}
        #endregion
    }
}