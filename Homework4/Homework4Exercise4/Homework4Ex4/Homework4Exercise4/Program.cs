namespace Homework4Exercise4
{
    internal class Program
    {
        static int AgeCalculator(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if(birthday > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday date (in format dd/mm/yyyy): ");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);
            int age = AgeCalculator(birthday);

            Console.WriteLine("Your age is: " + age);
        }
    }