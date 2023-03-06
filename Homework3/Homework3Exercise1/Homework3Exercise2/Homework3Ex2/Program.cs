//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]

string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
string[] studentsG2 = new string[] {"Nikola", "Ivan", "Petar", "Darko", "Spase"};

Console.WriteLine("Enter Student group (there are 1 and 2): ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed || number > 2)
{
    Console.WriteLine("Please enter a number 1 for G1, or 2 for G2: ");
}

if (number == 1)
{
    Console.WriteLine("The students in G1 are: ");
    for (int i = 0; i<studentsG1.Length; i++)
    {
        Console.WriteLine($"{studentsG1[i]}");
    }
} if(number == 2)
{
    Console.WriteLine("The students in G2 are: ");
    for(int i = 0; i < studentsG2.Length; i++)
    {
        Console.WriteLine($"{studentsG2[i]}");
    }
}
