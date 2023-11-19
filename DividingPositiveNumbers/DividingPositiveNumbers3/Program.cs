//Write an algorithm that performs division of positive numbers using subtraction.

//counter = sayaç
//counclusion = sonuc

Console.WriteLine("Please enter the divisor number.");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the partition value.");
int number2 = Convert.ToInt32(Console.ReadLine());

int _number1 = number1;
int counclusion = 0, remainder = 0;

do
{
    number1 -= number2;
    counclusion++;
    if (number1 < number2)
    {
        remainder = number1;
        break;

    }
} while (true);

Console.WriteLine($"{_number1} / {number2} = {counclusion} | remainder = {remainder}");