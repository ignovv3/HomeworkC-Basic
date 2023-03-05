//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second 
//value and the second variable the first value. Please find example below:

Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

int temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("After swapping: \n First number = " + firstNumber + "\n Second number = " + secondNumber);