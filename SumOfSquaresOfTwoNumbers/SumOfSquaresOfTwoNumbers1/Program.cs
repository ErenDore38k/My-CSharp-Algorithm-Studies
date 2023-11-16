//Write an application that returns the sum of the squares of two numbers entered by the user.

Console.WriteLine("Please enter the first number.");
int number1 = Convert.ToInt32(Console.ReadLine());
number1 = number1 * number1;

Console.WriteLine("Please enter the second number.");
int number2 = Convert.ToInt32(Console.ReadLine());
number2 = number2 * number2;

Console.WriteLine(number1 + number2);