//Write an algorithm that performs division of positive numbers using subtraction.

//remainder = kalan
//conclusion = sonuç 

Console.WriteLine("Please enter the number you want to divide.");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the number you will divide.");
double number2  = Convert.ToDouble(Console.ReadLine());

double _number1  = number1;


double conclusion= 0;
double remainder = 0;


for (int i = 0; i <_number1; i++)
{
    number1 -= number2;
    conclusion++;
    if (number1 < number2)
    {
        remainder = number1;
        break;
    }
        
}
Console.WriteLine($"{_number1}/{number2} = {conclusion} | remainder = {remainder}");

