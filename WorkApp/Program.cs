Console.Write("Lütfen bir sayı giriniz: ");
// asking user his information down below:
int num = Convert.ToInt32(Console.ReadLine());
if (num > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür");
}
else if (num == 10)
{
    Console.WriteLine("Girilen sayı 10'a eşittir");
}
else
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür");
}

if (num % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir");
}

else
{
    Console.WriteLine("Girilen sayı tektir");
}