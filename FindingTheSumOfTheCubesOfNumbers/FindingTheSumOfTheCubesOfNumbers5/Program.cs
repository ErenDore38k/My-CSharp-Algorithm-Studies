//Write an application that finds the sum of the cubes of the numbers 1 to 10.

int total = 0;
for (int i = 1; i <= 10; i++)
{

    int a = i * i * i;
    total += a;
}
Console.WriteLine(total);

