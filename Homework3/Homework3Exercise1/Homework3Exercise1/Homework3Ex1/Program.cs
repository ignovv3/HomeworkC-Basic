//Make a console application called SumOfEven. Inside it create an array of 6 integers.
//Get numbers from the input, find and print the sum of the even numbers from the array:

int[] array = new int[6];
int sum = 0;

for(int i = 0; i<array.Length; i++)
{
    Console.WriteLine($"Enter a number {i + 1}: ");

    while (!int.TryParse(Console.ReadLine(), out array[i]))
    {
        Console.WriteLine($"Invalid input. Please enter a integer value for the element {i + 1}");
    }

    if (array[i] % 2 == 0)
    {
        sum += i;
    }
}

Console.WriteLine($"The result is: {sum}");