Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");
Console.Write("T.C. Kimlik Numarası:");
// asking user his information down below:
string personID = Console.ReadLine();
Console.Write("Adı:");
string personName = Console.ReadLine();
Console.Write("Soyadı:");
string personLastname = Console.ReadLine();
Console.Write("Telefon Numarası:");
string personPhoneNum = Console.ReadLine(); //defined it string because we won't need it for any calculation.
Console.Write("Yaş:");
int personAge = Convert.ToInt32(Console.ReadLine());
Console.Write("İlk aldığı ürünün fiyatı:");
double firstProductPrice = Convert.ToInt32(Console.ReadLine()); //defined it double to allow point numbers
Console.Write("İkinci aldığı ürünün fiyatı:");
double secondProductPrice = Convert.ToInt32(Console.ReadLine()); //defined it double  to allow point numbers
double patikaPoints = (firstProductPrice + secondProductPrice) * 0.1; //defined patikaPoints as a double variable
Console.WriteLine("------------------------------------------");

//here it writes the information with string interpolation:
Console.WriteLine($"{personID} Tc numaralı {personName} {personLastname} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{firstProductPrice+secondProductPrice} toplam harcama karşılığı kazanılan %10 patika puan miktarı " +
    $"-> {patikaPoints}dur."); // last line   