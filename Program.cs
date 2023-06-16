namespace prosto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GetLargeArray();

            Array.Sort(numbers);


            numbers = numbers.Where(x => !IsPalindrome(x)).ToArray();


            int sumDivisibleBy3 = numbers.Where(x => x % 3 == 0).Sum();


            int minNumber = numbers.Min();
            int maxNumber = numbers.Max();


            double average = numbers.Average();

            Console.WriteLine("Sum elements divided on 3 without remainder: " + sumDivisibleBy3);
            Console.WriteLine("Min: " + minNumber);
            Console.WriteLine("Max: " + maxNumber);
            Console.WriteLine("Average: " + average);

        }
        static bool IsPalindrome(int number)
        {
            string strNumber = number.ToString();
            int length = strNumber.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (strNumber[i] != strNumber[length - i - 1])
                    return false;
            }
            return true;
        }

        
        static int[] GetLargeArray()
        {
            int N = 1000000;
            int[] numbers = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                numbers[i] = random.Next(1, 1000); 
            }
            return numbers;
        }
    }
}
