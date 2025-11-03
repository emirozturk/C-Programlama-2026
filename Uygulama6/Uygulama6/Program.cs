

using System.Diagnostics;

class Uygulama6
{
    static Semaphore s = new Semaphore(3, 16);

    static int deger = 0;
    static void fonksiyon(object x)
    {
        int no = Convert.ToInt32(x);
        for (int i = 0; i < 100000; i++)
        {
            s.WaitOne();
            deger++;
            s.Release();
        }
        Console.WriteLine("T" + no);
    }
    public static void Main(string[] args)
    {   

        for(int i = 0; i < 10; i++)
        {
            Thread t = new Thread(fonksiyon);
            t.Start(i);
        }

        Console.WriteLine(deger);
        var sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 200000; i++)
            deger++;
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}  


/*
class Uygulama6
{
    static void fonksiyon()
    {
        for(int i = 0; i < 1000; i++)
        {
            Console.Write(i + " ");
        }
    }
    public static void Main(string[] args)
    {
        var thread = new Thread(fonksiyon);
        thread.Start();
        Thread.Sleep(5);
        Console.WriteLine("Buraya thread bittikten sonra gelinmeli");
    }
}


class Uygulama6
{
    static void fonksiyon(object kac)
    {
        int sinir = Convert.ToInt32(kac);
        for(int i = 0; i < sinir*100; i++)
        {
            Console.WriteLine("T"+sinir+ ":" + i + " ");
        }
    }
    public static void Main(string[] args)
    {
        var thread1 = new Thread(fonksiyon);
        var thread2 = new Thread(fonksiyon);
        thread1.Start(1);
        thread2.Start(2);
    }
}
class Uygulama6
{
    static bool kilit = false;
    static int deger = 0;
    static void fonksiyon()
    {
        for(int i = 0; i < 10000; i++)
        {
            while (kilit) ;
            if (!kilit)
            {
                kilit = true;
                deger++;
                kilit = false;
            }
        }
    }
    public static void Main(string[] args)
    {
        var thread1 = new Thread(fonksiyon);
        var thread2 = new Thread(fonksiyon);
        thread1.Start();
        thread2.Start();
        Thread.Sleep(10000);
        Console.WriteLine(deger);
    }
}
using System.Diagnostics;

class Uygulama6
{
    static Mutex m = new Mutex();
    static int deger = 0;
    static void fonksiyon()
    {        
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 100000; i++)
        {
            m.WaitOne();
            deger++;
            m.ReleaseMutex();
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
    public static void Main(string[] args)
    {
        var thread1 = new Thread(fonksiyon);
        var thread2 = new Thread(fonksiyon);
        thread1.Start();
        thread2.Start();
        Thread.Sleep(5000);
        Console.WriteLine(deger);
        var sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 200000; i++)
            deger++;
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}
*/