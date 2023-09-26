using System;

class Program
{
    private static void Main(string[] args)
    {
        int testCases = Convert.ToInt32(Console.ReadLine());

        for (int t = 0; t < testCases; t++)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            for (int k = 0; k < inputArray.Length; k++)
            {
                if (int.TryParse(inputArray[k], out int value))
                {
                    array[k] = value;
                }
                else
                {
                    Console.WriteLine($"Invalid input: '{inputArray[k]}' is not a valid integer.");
                    return;
                }
            }

            for (int i = 0; i < size; i++) // { 1, 6, 3, 7 }
            {
                int max = array[i]; // The maximum value in the subarray=[i]=1
                for (int j = i; j < size; j++) // j=i=1
                {                // 1   array[j=i]=1
                    max = Math.Max(max, array[j]);
                    Console.Write($"{max} ");
                }
            }

            Console.WriteLine(); // Print a newline to separate the output for each test case.
        }
    }
}
