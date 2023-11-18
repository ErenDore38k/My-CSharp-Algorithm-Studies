//Write an algorithm to find multiplication of positive numbers using addition.

Console.WriteLine("Please enter a positive number.");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a positive number.");
int number2  = Convert.ToInt32(Console.ReadLine());

int asaresultofimpact = 0;

for (int i = 0; i < number1; i++)
{
    asaresultofimpact += number2;
}

Console.WriteLine($"{number1}x{number2} = {asaresultofimpact}");