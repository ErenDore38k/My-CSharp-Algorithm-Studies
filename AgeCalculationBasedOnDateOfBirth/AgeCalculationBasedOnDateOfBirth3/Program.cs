//Write the algorithm that calculates the age of the person whose date of birth is entered.

Console.WriteLine("Please enter your date of birth.");
DateTime dateofbirth = DateTime.Parse(Console.ReadLine());

int day = (DateTime.Now - dateofbirth).Days;

int age = day / 365;
int remainder = day / 365;
Console.WriteLine($"age : {age}| {age + 1} Number of days remaining to your age :{365 +(age*1/4) - remainder}");
