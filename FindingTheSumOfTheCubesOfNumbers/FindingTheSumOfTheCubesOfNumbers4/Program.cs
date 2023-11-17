//Write an application that finds the sum of the cubes of the numbers 1 to 10.

//Solution with Ternary Operator
 
            
int i = 1;
double conclusion = 0;

while (i <= 10)
{
    conclusion += Math.Pow(i, 3);
    Console.Write(i == 10 ? $"{i}³ = {conclusion}" : $"{i}³ + ");
    i++;
}
