


Console.WriteLine("Please enter a number whose cubed sum is equal to itself: ");
string userLogin = Console.ReadLine();

//Kullanıcı girdisi double türüne dönüştürülebilir mi ve üç basamaklı mı kontrol edilir.
if (double.TryParse(userLogin, out double number) && userLogin.Length == 3)
{
    //Rakamlarının küpleri toplamı hesaplanır.
    double cubeSum = userLogin.Sum(number => Math.Pow(Convert.ToDouble(number.ToString()), 3));

    //Eğer sayı rakamlarının küpü toplamına eşitse "Yes", aksi halde "No" mesajı yazdırılır.
    Console.WriteLine(cubeSum == number ? $"Yes,  {number} The number is equal to the sum of the cube of its digits."
                                           :
                                           $"No, {number} The number is not equal to the sum of the cube of its digits.");
}
else
    Console.WriteLine("Please enter a 3-digit number.");