namespace Homework4Exercise3
{
    internal class Program
    {

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            bool canParseUserInput = int.TryParse(Console.ReadLine(), out int userInput);
            if (!canParseUserInput)
            {
                Console.WriteLine("Wrong input! Please enter a number.");
            }

            int sum = SumOfDigits(userInput);
            Console.WriteLine("Sum of digits in the input number is: " + sum);
        }
    }
}