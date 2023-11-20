//Write an application that tells you how many digits the entered positive number has.

Console.WriteLine("Please enter the number you want to know the number of digits.");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} place value of number{number.ToString().Length}");