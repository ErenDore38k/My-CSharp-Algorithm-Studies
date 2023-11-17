//Write the algorithm that calculates the factorial of the entered number.

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= number; i++)
{
   factorial *= i;
}
Console.WriteLine(number + "! = " + factorial);

Console.ReadLine();
