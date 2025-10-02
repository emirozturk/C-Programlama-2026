//Kullanıcıdan bir dosya yolu alan ve dosya mevcutsa boyutunu bayt cinsinden, yoksa “dosya bulunamadı” mesajını veren bir C# programı yazınız. Dosya yoksa aynı adla boş bir dosya da oluşturulmalıdır.

//ekrandan bir dosya yolu al ve dosyaYolu değişkenine ata
//Eğer dosya bulunduysa
//bayt cinsinden dosya boyutunu yazdır
//bulunamadıysa
//Dosya bulunamadı yazdır
/*
class Sinif
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dosya yolunu giriniz");
        var dosyaYolu = Console.ReadLine();
        if (File.Exists(dosyaYolu))
        {
            //var fs = new FileStream(dosyaYolu, FileMode.Open);
            //var dosyaBoyutu = fs.Length;
            //fs.Close();
            //var dosyaBoyutu = File.ReadAllBytes(dosyaYolu).Length;
            var dosyaBoyutu = new FileInfo(dosyaYolu).Length;
            Console.WriteLine(dosyaBoyutu);
        }
        else
        {
            Console.WriteLine("Dosya bulunamadı");
        }
    }
}
*/
