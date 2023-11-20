//Write an application that tells you how many digits the entered positive number has.

Console.WriteLine("Please enter the number you want to know the number of digits.");
int number = Convert.ToInt32(Console.ReadLine());
int _number = number;
int conclusion = 1;

while (true)
{
    number/= 10;
    conclusion++;
    if (number < 10)
        break;
}

Console.WriteLine($"{_number} the number {conclusion} place value of number");