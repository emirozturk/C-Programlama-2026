//Verilen bir kök klasörde (alt klasörler dahil) bulunan tüm dosyaları tarayarak toplam boyutu insan okunur formatta (KB/MB/GB) raporlayan bir program yazınız. Erişilemeyen klasörler try/catch ile atlanmalı ve kaç klasörün atlandığı ayrıca belirtilmelidir.
/*
class SonSoru
{
    public static List<string> DosyaListesiDondur(string yol)
    {
        List<string> dosyaListesi = new List<string>();

        var bulunanDosyalar = Directory.GetFiles(yol);
        dosyaListesi.AddRange(bulunanDosyalar);

        var altDizin = Directory.GetDirectories(yol);
        foreach (var dizin in altDizin)
            dosyaListesi.AddRange(DosyaListesiDondur(dizin));
        return dosyaListesi;
    }
    public static void Main(string[] args)
    {
        var rootDirectory = "/Users/emirozturk/Desktop/deneme";
        var dosyalar = DosyaListesiDondur(rootDirectory);
        Console.WriteLine(dosyalar.Count);
        /*
        long toplam = 0;
        foreach (var dosya in dosyalar)
        {
            toplam += new FileInfo(dosya).Length;
        }
        long toplam = dosyalar.Sum(x => new FileInfo(x).Length);
        var mbBoyut = toplam / (1024 * 1024);
        var gbBoyut = mbBoyut / 1024;
if (gbBoyut < 1) Console.WriteLine($"{mbBoyut} MB");
else Console.Write($"{gbBoyut} GB");
    }
}
*/

//Verilen bir kök klasörde (alt klasörler dahil) bulunan tüm dosyaları tarayarak toplam boyutu insan okunur formatta (KB/MB/GB) raporlayan bir program yazınız. Erişilemeyen klasörler try/catch ile atlanmalı ve kaç klasörün atlandığı ayrıca belirtilmelidir.
/*

class SonSoru
{
    public static List<string> DosyaListesiDondur(string yol)
    {
        List<string> dosyaListesi = [.. Directory.GetFiles(yol)];
        var altDizin = Directory.GetDirectories(yol);
        foreach (var dizin in altDizin)
            dosyaListesi.AddRange(DosyaListesiDondur(dizin));
        return dosyaListesi;
    }
    public static void Main(string[] args)
    {
        var rootDirectory = "/Users/emirozturk/Desktop/deneme";
        var dosyalar = DosyaListesiDondur(rootDirectory);
        Console.WriteLine(dosyalar.Count);
        long toplam = dosyalar.Sum(x => new FileInfo(x).Length);
        var mbBoyut = toplam / (1024 * 1024);
        if (mbBoyut / 1024 < 1) Console.WriteLine($"{mbBoyut} MB");
        else Console.Write($"{mbBoyut/1024} GB");
    }
}*/

class SonSoru
{
    private static int atlanilanKlasorSayisi = 0;

    public static List<string> DosyaListesiDondur(string yol)
    {
        var dosyalar = new List<string>();

        try
        {
            dosyalar.AddRange(Directory.GetFiles(yol));
            foreach (var altKlasor in Directory.GetDirectories(yol))
                dosyalar.AddRange(DosyaListesiDondur(altKlasor));
        }
        catch
        {
            atlanilanKlasorSayisi++;
        }

        return dosyalar;
    }

    public static string BoyutuFormatla(long bytes)
    {
        var kb = bytes / 1024.0;
        var mb = kb / 1024.0;
        var gb = mb / 1024.0;

        return gb >= 1 ? $"{gb:F2} GB" :
               mb >= 1 ? $"{mb:F2} MB" :
               $"{kb:F2} KB";
    }

    public static void Main(string[] args)
    {
        var rootDirectory = "/Users/emirozturk/Desktop/deneme";
        var dosyalar = DosyaListesiDondur(rootDirectory);
        var toplamBoyut = dosyalar.Sum(dosya => new FileInfo(dosya).Length);

        Console.WriteLine($"Toplam dosya sayısı: {dosyalar.Count}");
        Console.WriteLine($"Toplam boyut: {BoyutuFormatla(toplamBoyut)}");
        Console.WriteLine($"Atlanan klasör sayısı: {atlanilanKlasorSayisi}");
    }
}