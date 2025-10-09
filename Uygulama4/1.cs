using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
var liste = new List<int>{3,17,29,33,67,81,77,-17,99,-26,0,333};
var liste2 = new List<int>();
//Console.WriteLine(liste.Max());
//Console.WriteLine(liste.Min());
//Console.WriteLine(liste.First());
//Console.WriteLine(liste2.FirstOrDefault());
//Console.WriteLine(liste.Last());
//foreach(var eleman in liste.Take(5))
//    Console.WriteLine(eleman);
//foreach(var eleman in liste.Skip(5).Take(5).ToList())
//    Console.WriteLine(eleman);

//var onKati = new List<int>();
//foreach (var i in liste)
//    onKati.Add(i * 10);
//var onKati = liste.Select((x)=>x * 10).ToList();
//foreach (var eleman in onKati)
//    Console.Write($"{eleman} ");
/*
bool ellidenBuyukMu(int sayi)
{
    if (sayi > 50) return true;
    else return false;
}
var ellidenBuyuk = liste.Where(ellidenBuyukMu).ToList();
foreach (var eleman in ellidenBuyuk)
    Console.Write($"{eleman} ");

bool ellidenBuyukMu(int sayi)
{
    return sayi > 50;
}
var ellidenBuyuk = liste.Where(ellidenBuyukMu).ToList();
foreach (var eleman in ellidenBuyuk)
    Console.Write($"{eleman} ");
var ellidenBuyuk = liste
                    .Where((sayi) => sayi > 50)
                    .OrderByDescending(x=>x)
                    .ToList();

foreach (var eleman in ellidenBuyuk)
    Console.Write($"{eleman} ");
*/