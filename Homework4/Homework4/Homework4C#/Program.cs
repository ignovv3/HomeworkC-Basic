Console.WriteLine("Please enter a string: ");
string userInput = Console.ReadLine();
if(userInput.Length >= 5)
{
    string lastFive = userInput.Substring(userInput.Length - 5);
    Console.WriteLine("The last five characters of this string are: " + lastFive);
}
else
{
    Console.WriteLine("The input string is less than 5 characters long. ");
}