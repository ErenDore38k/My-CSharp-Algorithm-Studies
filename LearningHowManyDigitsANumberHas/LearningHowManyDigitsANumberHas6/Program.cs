//Write an application that tells you how many digits the entered positive number has.

//conclusion = sonuç

Console.WriteLine("Please enter the number you want to know the number of digits.");
int number = int.Parse(Console.ReadLine());
int conclusion = NumberOfDigits(number);
NumberOfDigits(number);
if (number < 10)
    Console.WriteLine($"{number}  = {conclusion}");
else Console.WriteLine($"{number} number of digits of the number = {++conclusion}");

static int NumberOfDigits(int number)
{

    number /= 10;
    if (number >= 10)
        return 1 + NumberOfDigits(number);
    return 1;
}
