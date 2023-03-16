Console.WriteLine("Please enter a sentence: ");
string userInput = Console.ReadLine();

string[] words = userInput.Split(' ');

Console.WriteLine("Words in this sentence are: ");
foreach(string word in words)
{
    Console.WriteLine(word);
}