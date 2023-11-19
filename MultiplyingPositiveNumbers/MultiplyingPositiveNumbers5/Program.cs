//Write an algorithm to find multiplication of positive numbers using addition.

Console.WriteLine("Please enter the first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");
int number2  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Gather(number1, number2));
static int Gather(int number1,int number2)
{
    if (number2 > 1)
        return number1 + Gather(number1, --number2);
    return number1;
}