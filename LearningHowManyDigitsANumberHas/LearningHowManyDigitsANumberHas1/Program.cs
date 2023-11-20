//Write an application that tells you how many digits the entered positive number has.

Console.WriteLine("Please enter the number you want to know the number of digits.");
 Double number = Double.Parse(Console.ReadLine());

#region method1
/*

for (double i = 0;number >= 10;)
		{
	number /= 10;
	counter++;
	number++;
}
*/
#endregion

#region method2
/*
for (double i = 0; number>=10; i++)
{
	number /= 10;
}
*/
#endregion

int counter = 0;

for(; number >= 10;)
{
	number/= 10;
	counter++;
}
counter++; //We increase the counter because it does not give the place value one less value.
 

Console.WriteLine($"{number} place value of number {counter}");