//Write an application that finds the sum of the cubes of the numbers 1 to 10.

int i = 1;
double totalresult = 0;
string result = " ";

while (i<=10)
{
    totalresult += Math.Pow(i, 3);

    if (i != 10)
        result += $"{i}³ +";
    else
        result += $"{i}³ = {totalresult}";

    i++;
}
Console.WriteLine(totalresult);