//Write the algorithm that calculates the factorial of the entered number.

Console.Write("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

do
{

    factorial *= number;
    number--;
    if (number == 0)
        break;
}while (true);
Console.WriteLine("factorial = " + factorial);

