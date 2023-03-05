//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). 
//Then it returns the result.

Console.WriteLine("Enter first Number: ");
bool flag1 = double.TryParse(Console.ReadLine(), out double firstNumber);
if (!flag1)
{
    Console.WriteLine("The input is not a number.");
}

Console.WriteLine("Enter second Number: ");
bool flag2 = double.TryParse(Console.ReadLine(), out double secondNumber);
if (!flag2)
{
    Console.WriteLine("The input is not a number. ");
}

Console.WriteLine("Enter the operation: ");
char op = char.Parse(Console.ReadLine());

double result = 0;

switch (op)
{
    case '+':
        result = firstNumber + secondNumber;
        Console.WriteLine("The sum of the two numbers is: " + result);
        break;
    case '-':
        result = firstNumber - secondNumber;
        Console.WriteLine("The substraction of the numbers is: " + result);
        break;
    case '*':
        result = firstNumber * secondNumber;
        Console.WriteLine("The multiplication of the numbers is: " + result);
        break;
    case '/':
        result = firstNumber / secondNumber;
        Console.WriteLine("The division of the numbers is: " + result);
        break;
    default:
        Console.WriteLine("You entered a wrong number or operator. Try again! ");
        break;
}