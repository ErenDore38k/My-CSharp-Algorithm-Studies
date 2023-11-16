//Write an application that returns the sum of the squares of two numbers entered by the user.

Console.WriteLine("Please enter the first number.");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number.");
int number2  = Convert.ToInt32(Console.ReadLine());

//Math.Pow(2,3): 2'nin 3. kuvvetini almak anlamına gelir.

double conclusion = Math.Pow(number1, 2) + Math.Pow(number2, 2);
Console.WriteLine(conclusion);
