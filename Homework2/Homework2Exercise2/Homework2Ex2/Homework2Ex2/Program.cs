//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

Console.WriteLine("Enter the first number: ");
double firstNumber = 0;
double secondNumber = 0;
double thirdNumber = 0;
double fourthNumber = 0;

while (!double.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Please enter a number! ");
}

Console.WriteLine("Enter the second number: ");
while(!double.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Please enter a number! ");
}

Console.WriteLine("Enter the third number: ");
while(!double.TryParse(Console.ReadLine(), out thirdNumber))
{
    Console.WriteLine("Please enter a number! ");
}

Console.WriteLine("Enter the fourth number: ");
while(!double.TryParse(Console.ReadLine(), out fourthNumber))
{
    Console.WriteLine("Please enter a number! ");
}

double avgNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
Console.WriteLine("The average of " + firstNumber + " " + secondNumber + " " + thirdNumber + " and " + fourthNumber + " is: " + avgNumber);