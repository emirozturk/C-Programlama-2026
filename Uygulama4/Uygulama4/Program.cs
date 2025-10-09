using System.Runtime.Intrinsics.Arm;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

class Uygulama4
{
    static List<Song> songList;
    public static void Main(string[] args)
    {
        var jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true
        };
        var songRepository = new SongRepository("/Users/emirozturk/Desktop/Songs.json", jsonOptions);
        songList = songRepository.ReadFromFile();
        Menu();
        songRepository.WriteToFile(songList);
    }
    public static void Menu()
    {
        string input = "";
        do
        {
            Console.WriteLine($"{songList.Count} songs read");
            Console.WriteLine("1. Add Song");
            Console.WriteLine("2. Vote a Song");
            Console.WriteLine("3. Info");
            Console.WriteLine("4. Exit");
            Console.Write("Selection: ");
            input = Console.ReadLine();
            if (input == "1") AddSong();
            else if (input == "2") VoteSong();
            else if (input == "3") Info();
            else if (input == "4") break;
        }
        while (input != "4");
    }

    private static void Info()
    {
        foreach (var element in songList)
            Console.WriteLine(element.ToString());

        Console.WriteLine("Songs of last 5 years");
        var last5years = songList
                            .Where(x => x.Year > DateTime.Now.Year - 5)
                            .OrderByDescending(x => x.Year);
        foreach (var element in last5years)
            Console.WriteLine(element.ToString());

        Console.WriteLine("Most voted songs");
        var mostVoted = songList.OrderByDescending(x => x.Vote);
        foreach (var element in mostVoted)
            Console.WriteLine(element.ToString());

        Console.WriteLine("Songs by years");
        var sortedByYear = songList.OrderBy(x => x.Year);
        foreach (var element in sortedByYear)
            Console.WriteLine(element.ToString());

        Console.WriteLine("Most voted 2 songs in last year");
        var result = songList.Where(x => x.Year == DateTime.Now.Year)
                                .OrderByDescending(x => x.Vote)
                                .Take(2);
        foreach (var element in result)
            Console.WriteLine(element.ToString());
    }

    private static void VoteSong()
    {
        Console.Write("Name     :");
        var name = Console.ReadLine();
        var found = songList.FirstOrDefault(x => x.Name == name);
        if (found != null)
        {
            found.Vote++;
            Console.WriteLine("Voted.");
        }
        else
        {
            Console.Write("Song not found");
        }
    }

    private static void AddSong()
    {
        Console.Write("Name     :");
        var name = Console.ReadLine();
        Console.Write("Artist   :");
        var artist = Console.ReadLine();
        Console.Write("Year     :");
        var year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Genre    :");
        var genre = Console.ReadLine();
        var song = new Song(artist, name, year, genre, 0);
        songList.Add(song);
    }
}