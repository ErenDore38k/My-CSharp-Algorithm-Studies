//Write the algorithm that calculates the factorial of the entered number.

//Our aim is to print the result in the format below.
//5x4x3x2x1 

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int conclusion = 1;
string _conclusion = ""; 
while (number>0)
{
   conclusion *= number;
    if (number != 1)
        _conclusion += $"{number} x ";
    else
        _conclusion += $"{number} = {conclusion}" ;
    number--;
}
Console.WriteLine(_conclusion);
