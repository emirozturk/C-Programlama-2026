/*
var path = "/Users/emirozturk/Desktop/deneme.txt";
var dosya = new FileStream(path, FileMode.Open);
Console.WriteLine(dosya.CanRead);
if (dosya.CanRead)
{
    dosya.WriteByte(65);
    dosya.WriteByte(65);
    dosya.WriteByte(97);
}
dosya.Close();
var dosya = new FileStream(path, FileMode.Open);
Console.WriteLine(dosya.ReadByte());
Console.WriteLine(dosya.ReadByte());
Console.WriteLine(dosya.ReadByte());
var fs = new FileStream(path, FileMode.Open);
var sw = new StreamWriter(fs);
sw.WriteLine("Bir satır");
sw.Close();
fs.Close();
var fs = new FileStream(path, FileMode.OpenOrCreate);
var br = new BinaryReader(fs);
try
{
    var deger = br.ReadInt16();
    Console.WriteLine(deger);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    br.Close();
    fs.Close();
}
*/