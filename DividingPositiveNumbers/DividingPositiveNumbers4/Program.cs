/*
static void Main(string[] args)
{

    Console.WriteLine("Please enter the divisor number.");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the partition value.");
    int number2 = Convert.ToInt32(Console.ReadLine());
    
 int divisionresult = Plenty(number1, number2);
    int remainder = remainder(number1, number2);

    Console.WriteLine($"{number1}/{number2} = {divisionresult} | remainder = {remainder}");
}

 static int Plenty(int number1,int number2)
{
    number1-=number2;
    if (number1 >= number2)
        return 1 + Plenty(number1,number2);
    return 1;
}

static int remainder(int number1,int number2)
{
    number1 -= number2;
    if (number1 >= number2)
        return remainder(number1,number2);
    return number1;

}
*/

static void Main(string[] args)
{
    try
    {
        Console.WriteLine("Please enter the divisor number.");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the partition value.");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int divisionresult = Plenty(number1, number2);
        int remainder = Remainder(number1, number2);

        Console.WriteLine($"{number1}/{number2} = {divisionresult} | remainder = {remainder}");

        Console.ReadLine(); // Programın kapatılmaması için bekleme ekledik
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

static int Plenty(int number1, int number2)
{
    number1 -= number2;
    if (number1 >= number2)
        return 1 + Plenty(number1, number2);
    return 1;
}

static int Remainder(int number1, int number2)
{
    number1 -= number2;
    if (number1 >= number2)
        return Remainder(number1, number2);
    return number1 >= 0 ? number1 : 0;
}
