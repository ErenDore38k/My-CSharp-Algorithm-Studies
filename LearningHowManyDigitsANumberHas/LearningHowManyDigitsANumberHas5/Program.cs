//Write an application that tells you how many digits the entered positive number has.
//conclusion = sonuç


Console.WriteLine("Please enter the number you want to know the number of digits.");
int number = Convert.ToInt32(Console.ReadLine());
int _number = number;
int conclusion = 0;

do
{
    number /= 10;
   conclusion++;
        
} while (number>=10);
//conclusion++;
Console.WriteLine($"{_number} the number {++conclusion} place value of number");

#region NOTE
/*
 * Number = 20;
 * ++Number = 
It first increases the number and then prints it.

Number++ =  
It first prints and then increments.


*/
#endregion