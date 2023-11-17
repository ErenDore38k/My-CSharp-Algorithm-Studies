//Write an application that finds the sum of the cubes of the numbers 1 to 10.

/*
double totalresult = 0;
int i = 1;
while (i<=10)
{
    totalresult += Math.Pow(i, 3);
    i++;
}
Console.WriteLine(totalresult);
*/



double totalresult = 0;
int i = 1;
while (true)
{
    totalresult += Math.Pow(i, 3);

    if (i == 10)
        break;

    i++;
}
Console.WriteLine(totalresult);