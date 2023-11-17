//Write an application that finds the sum of the cubes of the numbers 1 to 10.

double totalresult = 0;
int i = 1;
do
{

    totalresult += Math.Pow(i, 3);
    i++;

} while (i<=10);
Console.WriteLine(totalresult);
