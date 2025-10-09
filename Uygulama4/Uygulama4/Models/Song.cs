class Song(string Artist, string Name, int Year, string Genre, int Vote)
{
    public string Artist { get; set; } = Artist;
    public string Name { get; set; } = Name;
    public int Year { get; set; } = Year;
    public string Genre { get; set; } = Genre;
    public int Vote { get; set; } = Vote;
    public override string ToString()
    {
        return $"{Artist.PadRight(20)} - {Name.PadRight(20)} - {Year,4} - {Genre.PadRight(10)} - {Vote}";
    }
}