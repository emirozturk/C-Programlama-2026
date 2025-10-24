using System.Diagnostics;

class Sayi(int Deger)
{
    public int Deger { get; set; } = Deger;
}


class Program
{
    public static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Console.WriteLine("Başladı");
        List<int> liste = new List<int>();
        Sayi sayi = new Sayi(0);
        for (int i = 0; i < 500_000_000; i++)
        {
            sayi.Deger = i*= 10+1; 
            liste.Add(sayi.Deger);
        }
        sw.Stop();
        Console.WriteLine($"Bitti : {sw.ElapsedMilliseconds} ms");
    }
}