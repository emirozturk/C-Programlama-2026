//Kullanıcıdan alınan bir metindeki en çok tekrarlanan kelimeyi bulan bir program yazınız.
/*
class Soru2
{
    public static void Main(string[] args)
    {
        //bir metin tanımla
        var metin = "“Büyük Defter  ̴ Kanıt  ̴ Üçüncü Yalan” yeterince anlaşıldı mı, emin değilim. Savaş ve çocukluk, savaşın tüm kötülüklerin anası oluşu üstüne daha çok düşünmek, okumak ve yazmak gerekir. Nitekim ben de kitabı bitirdikten sonra savaşlar ve savaş sonrası üstüne yazan birçok yazar ve yapıtı okuma gereği duydum. Ve. O Hiçbir Şey Demedi (Heinrich Böll), Cesaret Ana ve Çocukları (Bertolt Brecht) Geçen Salı (Wolfrang Borchert)… Savaşlar bitmez, ruhlarda sürüp gider. Zor Bir Hayatın Hikâyesi’nde, “Savaş biteli elli yıldan çok oldu.";
        //metni boşluğa göre böl
        metin = metin.ToLower();
        var yeniMetin = "";
        foreach (var c in metin)
            if (!char.IsPunctuation(c))
                yeniMetin += c;
        var kelimeler = yeniMetin.Split(" ");
        //temizleme?
        var sozluk = new Dictionary<string, int>();
        //her kelime için
        foreach (var kelime in kelimeler)
        {
            //var mı kontrol et
            if (sozluk.ContainsKey(kelime))
                //varsa bir frekansını bir arttır 
                sozluk[kelime]++;
            else
                //yoksa ekle
                sozluk.Add(kelime, 1);
        }
        var enCokTekrarlanan = "";
        int maxValue = -1;
        foreach (var eleman in sozluk)
            if (eleman.Value > maxValue)
            {
                maxValue = eleman.Value;
                enCokTekrarlanan = eleman.Key;
            }
        Console.WriteLine($"En çok geçen kelime: '{enCokTekrarlanan}' '{maxValue}'");
    }
}
*/