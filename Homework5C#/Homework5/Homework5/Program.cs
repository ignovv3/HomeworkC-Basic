using Homework5.Modules;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your Age: ");
            bool parseAge = int.TryParse(Console.ReadLine(), out int age);
            if (!parseAge)
            {
                Console.WriteLine("Wrong input! Please enter a number! ");
            }

            Human human = new Human()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };

            Console.WriteLine(human.GetHumanDetails());
            
            Console.ReadLine();
        }
    }
}