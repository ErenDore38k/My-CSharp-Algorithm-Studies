//Write an algorithm to find multiplication of positive numbers using addition.

//counter = sayaç
//conclusion = sonuç

Console.WriteLine("Please enter the first number.");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number.");
int number2 = Convert.ToInt32(Console.ReadLine());

int counter = number2;
int conclusion = 0;

do
{
    conclusion += number1;
    counter--;
} while (counter > 0);

Console.WriteLine($"{number1}x{number2} = {conclusion}");

