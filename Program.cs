public class PrimeAndPalindromeNumbers
{
    public static void PrintPrimeAndPalindromeNumbers(int n, int m)
    {
        Console.WriteLine("Prime Numbers:");
        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i + " ");
            }
        }

        Console.WriteLine("Palindrome Numbers:");
        for (int i = n; i <= m; i++)
        {
            if (IsPalindrome(i))
            {
                Console.WriteLine(i + " ");
            }
        }
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsPalindrome(int num)
    {
        int originalNum = num;
        int reversedNum = 0;
        while (num > 0)
        {
            int remainder = num % 10;
            reversedNum = reversedNum * 10 + remainder;
            num /= 10;
        }
        if (originalNum <= 10)
        {
            return false;
        }
        else
        {
            return originalNum == reversedNum;
        }
    }

    public static void Main(string[] args)
    {
        PrintPrimeAndPalindromeNumbers(1, 100);
    }
}
