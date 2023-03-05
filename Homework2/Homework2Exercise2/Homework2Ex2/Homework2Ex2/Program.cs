//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the fourth number: ");
int fourthNumber = int.Parse(Console.ReadLine());

int avgNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
Console.WriteLine("The average of " + firstNumber + " " + secondNumber + " " + thirdNumber + " and " + fourthNumber + " is: " + avgNumber);