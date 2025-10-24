using System.ComponentModel.DataAnnotations;

public class Kisi
{
    public string Ad { get; set; }
    public string Soyad{ get; set; }
    public string Sifre { get; set; }
    public int Yas { get; set; }

    public Kisi(string Ad, string Soyad, string Sifre, int Yas)
    {
        this.Ad = Ad;
        this.Soyad = Soyad;
        this.Sifre = Sifre;
        this.Yas = Yas;
    }
    public Kisi(string Ad, string Soyad, string Sifre)
    {
        this.Ad = Ad;
        this.Soyad = Soyad;
        this.Sifre = Sifre;
    }
}