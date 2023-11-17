//Write the algorithm that calculates the age of the person whose date of birth is entered.

Console.WriteLine("Please enter your date of birth.");
DateTime dateofbirth =  DateTime.Parse(Console.ReadLine());
DateTime today = DateTime.Now;

int age = today.Year - dateofbirth.Year;

if (dateofbirth > today.AddYears(-age))
    age--;
Console.WriteLine(age);