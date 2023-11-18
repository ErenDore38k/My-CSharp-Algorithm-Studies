//Write the algorithm that calculates the factorial of the entered number.

Console.WriteLine("Please enter a number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(factorial(number));
static int factorial (int number)
{
    if (number > 1)
        return number * factorial(--number);
    return number;
}
