
class User(string name)
{
    public string Name { get; set; } = name;
}

class Product(string name)
{
    public string name { get; set; } = name;
}
class Response<T>
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    private Response(bool IsSuccess, string Message, T Data)
    {
        this.IsSuccess = IsSuccess;
        this.Message = Message;
        this.Data = Data;
    }
    public static Response<T> Success(T body)
    {
        return new Response<T>(true, "", body);
    }
    public static Response<T> Fail(string message)
    {
        return new Response<T>(false, message, default(T));
    }
}
class Soru3
{
    public static void Main(string[] args)
    {
        string data = "veri";
        var cevap = Response<string>.Success(data);
        var user = new User("Emir");
        var kullaniciCevabi = Response<User>.Success(user);
        var product = new Product("Ürün");
        var urunCevabi = Response<Product>.Success(product);
        var kullaniciListesi = new List<User>();
        Response<Product>.Fail("Basarisiz");
        Response < List<User>>.Fail("Hatali");
    }
}