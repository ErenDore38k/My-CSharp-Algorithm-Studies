//Write an application that tells you how many digits the entered positive number has.

//This time it will be with an infinite loop.
// conclusion = sonuç

Console.WriteLine("Please enter the number you want to know the number of digits.");
int number = Convert.ToInt32(Console.ReadLine());

int conclusion = 0;
int _number = number;
for (; ; )  //In this way, an infinite loop can be created. 
{
    number /= 10;
    conclusion++;
    if (number < 10)
        break;
}
conclusion++;
Console.WriteLine($"{_number} the number {conclusion} place value of number");