//Write an application that finds the sum of the cubes of the numbers 1 to 10.

double totalresult = 0;
for (int i = 1; i <=10; i++)
{
    totalresult += Math.Pow(i, 3);
}
Console.WriteLine(totalresult);
