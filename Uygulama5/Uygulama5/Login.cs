public class Login
{
    private List<Kisi> kisiListesi;
    public Login()
    {
        kisiListesi = new List<Kisi>()
        {
            new Kisi("Emir","Öztürk","123",57),
            new Kisi("Umut","Diler","1234",23),
            new Kisi("Onur","Ayyıldız","12345",22),
        };
    }
    public int CheckLogin(Kisi k)
    {
        var bulunan = kisiListesi.FirstOrDefault(x => x.Ad == k.Ad && x.Soyad == k.Soyad);
        if (bulunan != null)
            if (bulunan.Yas >= 23 && bulunan.Sifre == k.Sifre)  
            return 1;
        return 0;
    }
}