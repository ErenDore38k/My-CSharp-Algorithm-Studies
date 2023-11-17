//Write the algorithm that calculates the age of the person whose date of birth is entered.


Console.WriteLine("Please write your date of birth.");
DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());

TimeSpan result = DateTime.Now - dateofbirth;
Console.WriteLine(result.Days / 365);



