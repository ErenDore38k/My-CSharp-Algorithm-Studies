//Write an application that tells you how many digits the entered positive number has.

//solution 4 variation of solution 3

Console.WriteLine("Please enter the number you want to know the number of digits.");
int number = Convert.ToInt32(Console.ReadLine());
int _number = number;
int conclusion = 1;

while (number>=10)
{
    number /= 10;
    conclusion++;
    
        
}

Console.WriteLine($"{_number} the number {conclusion} place value of number");
