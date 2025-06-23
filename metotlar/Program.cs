using System;

class Program
{
    static void Main()
    {
        // 1. Değer döndürmeyen bir metodu çağırma (ekrana sevdiğimiz bir şarkı sözünü yazdıracak)
        PrintSongLyric();

        // 2. Tamsayı döndüren bir metot çağırma (rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürecek)
        int remainder = GetRandomRemainder();
        Console.WriteLine($"Rastgele üretilen sayının 2'ye bölümden kalan: {remainder}");

        // 3. Parametre alan ve geriye değer döndüren bir metot çağırma (parametre olarak aldığı iki sayının çarpımını geriye döndürecek).
        int result = Multiply(1, 8);
        Console.WriteLine($"Çarpım sonucu: {result}");

        // 4. Parametre alan ve geriye değer döndürmeyen bir metot (Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana basacak)
        HelloUser("Selin", "Özlük");

    }

    //1. Değer döndürmeden şarkı sözünü yazdıracak
    static void PrintSongLyric()
    {
        Console.WriteLine("I feel more and more like I was made for you");
    }

    //2. Parametresiz çalışacak, rastgele sayı üretip 2’ye bölümünden kalan değeri döndürecek

    static int GetRandomRemainder()
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 101);
        return num % 2;

    }

    // 3. Dışarıdan iki sayı alıp çarpım sonucunu döndüren metot

    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // 4. Ad ve soyad bilgisini alarak kişiyi selamlayan geri dönüşsüz metot
    static void HelloUser(string firstName, string lastName)
    {
        Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}!!!");

    }


}