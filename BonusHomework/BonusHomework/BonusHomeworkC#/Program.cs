using System.Runtime.CompilerServices;

int balance = 10000;

while (true)
{
    Console.WriteLine("Please select an option: ");
    Console.WriteLine("1. Check balance ");
    Console.WriteLine("2. Withdraw money ");
    bool  canParseUserInput = int.TryParse(Console.ReadLine(), out int userInput);
    if (!canParseUserInput || userInput > 2) 
    {
        Console.WriteLine($"Wrong input! Please write 1 or 2.");
    }

    switch (userInput)
    {
        case 1:
            Console.WriteLine($"You have {balance}$ on your account.");
            break;
        case 2:
            Console.WriteLine("Enter the amount you want to withdraw: ");
            bool canParseAmount = int.TryParse(Console.ReadLine(), out int amount);
            if (!canParseAmount)
            {
                Console.WriteLine("Wrong input! Please enter a number. ");
            }
            
            if(amount > balance)
            {
                Console.WriteLine($"You cannot withdraw {amount} because your balance is: {balance} ");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"You have successfully withdrawn {amount}$. And you have left {balance}$");
            }

            Console.WriteLine("Do you want to take some other action?");
            string userChoice = Console.ReadLine();
            if (userChoice.ToLower() == "y")
            {
                break;
            }

            Console.WriteLine("Thank you for using our ATM. Goodbye");

            break;
    }
}