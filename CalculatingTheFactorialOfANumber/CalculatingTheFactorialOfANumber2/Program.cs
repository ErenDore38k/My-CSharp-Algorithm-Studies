//Write the algorithm that calculates the factorial of the entered number.

Console.Write("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
while (number > 1)
{
    factorial *= number;
    number--;
}
Console.WriteLine("factorial = " + factorial);