//Verilen bir klasör yolundaki tüm .txt dosyalarının adlarını (uzantılarıyla birlikte) alfabetik sırada ekrana listeleyen bir program yazınız. Klasör yoksa otomatik olarak oluşturulmalıdır.
/*
class Sinif
{
    public static void Main(string[] args)
    {
        //Klasörün yolunu ver
        //klasör var mı yok mu bir bak
        //varsa
        //klasördeki tüm dosyaları oku
        //Bu dosyalardan .txt olanları listele
        //Yoksa
        //klasörü oluştur
        var directory = "/Users/emirozturk/Desktop/deneme";
        if (Directory.Exists(directory))
        {
            var dizi = Directory.GetFiles(directory, "*.txt");
            dizi = dizi.OrderBy(x=>x).ToArray();
            foreach (var eleman in dizi)
            {
                Console.WriteLine(eleman);
            }
        }
        else
        {
            Directory.CreateDirectory(directory);
        }
    }
}
*/