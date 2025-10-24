using System.Security.Cryptography;
namespace TestProjesi;

public class Tests
{
    Kisi kisi;
    Kisi kAd;
    Kisi kSoyad;
    Kisi kYas;
    Kisi kSifreYanlis;
    Kisi kSifreBos;
    Login login;
    
    [SetUp]
    public void Setup()
    {
        kisi = new Kisi("Emir", "Öztürk", "123", 57);
        kAd = new Kisi(null, "Öztürk", "123", 57);
        kSoyad = new Kisi("Emir", null, "123", 57);
        kSifreYanlis = new Kisi("Emir", "Öztürk", "1234", 57);
        kSifreBos = new Kisi("Emir", "Öztürk", "", 57);
        kYas = new Kisi("Emir", "Öztürk", "123", 57);
        login = new Login();
    }

    [Test]
    public void BosIsimKontrolu()
    {
        var sonuc = login.CheckLogin(kAd);
        if (sonuc == 1) Assert.Fail("Sonuç sıfır dönmeli");
        else if (sonuc == 0) Assert.Pass();
    }
    [Test]
    public void BosSoyadiKontrolu()
    {
        var sonuc = login.CheckLogin(kSoyad);
        if (sonuc == 1) Assert.Fail("Sonuç sıfır dönmeli");
        else if (sonuc == 0) Assert.Pass();
    }
    [Test]
    public void BosSifreKontrolu()
    {
        var sonuc = login.CheckLogin(kSifreBos);
        if (sonuc == 1) Assert.Fail("Sonuç sıfır dönmeli");
        else if (sonuc == 0) Assert.Pass();
    }
    [Test]
    public void YanlisSifreKontrolu()
    {
        var sonuc = login.CheckLogin(kSifreYanlis);
        if (sonuc == 1) Assert.Fail("Sonuç sıfır dönmeli");
        else if (sonuc == 0) Assert.Pass();
    }
    [Test]
    public void DogruSifreKontrolu()
    {
        var sonuc = login.CheckLogin(kisi);
        if (sonuc == 1) Assert.Pass();
        else if (sonuc == 0) Assert.Fail("Kullanıcı doğru sonuç true dönmeliydi");
    }
    [Test]
    public void YasKontrolu()
    {
        var tutan = new Kisi("Emir", "Öztürk", "123");
        var tutmayan = new Kisi("Onur", "Ayyıldız", "12345");
        var ucuncu = new Kisi("Umut", "Diler", "1234");
        var sonucTutan = login.CheckLogin(tutan);
        var sonucTutmayan = login.CheckLogin(tutmayan);
        var sonucUcuncu = login.CheckLogin(ucuncu);

        if (sonucTutan == 1 &&
            sonucTutmayan == 0 &&
            sonucUcuncu == 1) Assert.Pass();
        else Assert.Fail($"{sonucTutan} - {sonucTutmayan} - {sonucUcuncu}");
    }
}
