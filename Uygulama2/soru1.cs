//1.	Kullanıcıdan ürün adı ve fiyatı alarak “çıkış” yazılana kadar ürün ekleyen, en sonunda ürünlerin listesini ve toplam fiyatı yazdıran bir program yazınız.

//ürün sınıfı lazım
//isim
//fiyat
//yapıcı
/*
class Urun(string Isim, float Fiyat)
{
    public string Isim { get; set; } = Isim;
    public float Fiyat { get; set; } = Fiyat;
}

class Soru1
{
    public static void Main(string[] args)
    {
        //bir ürün listesi açalım
        var urunListesi = new List<Urun>();
        //döngü içerisinde
        do
        {
            //ekrandan isim alırım fiyat alırım
            Console.WriteLine("İsim giriniz ya da çıkmak için \"çıkış\" yazınız");
            var isim = Console.ReadLine();
            //isim çıkışsa çıkarım
            if (isim.ToLower() == "çıkış") break;
            Console.WriteLine("Fiyat giriniz");
            var fiyat = Convert.ToSingle(Console.ReadLine());
            //ürün oluştururum ürün listesine atarım
            var yeniUrun = new Urun(isim, fiyat);
            urunListesi.Add(yeniUrun);
        } while (true);
        //ürünlerin listesini gösteririm
        foreach (var urun in urunListesi)
            Console.WriteLine($"{urun.Isim} - {urun.Fiyat}");
        //toplam fiyatı gösteririm
        var toplamFiyat = urunListesi.Select(x => x.Fiyat).Sum();
        Console.WriteLine($"Toplam Fiyat {toplamFiyat}");
    }
}
*/