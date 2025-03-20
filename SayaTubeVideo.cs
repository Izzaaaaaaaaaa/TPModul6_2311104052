using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    // Konstruktor dengan validasi
    public SayaTubeVideo(string title)
    {
        if (title == null)
            throw new ArgumentNullException("Title tidak boleh null");
        if (title.Length > 100)
            throw new ArgumentException("Title maksimal 100 karakter");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    // Method untuk menambah play count dengan batasan
    public void IncreasePlayCount(int count)
    {
        if (count < 0)
            throw new ArgumentException("Play count tidak boleh negatif");
        if (count > 10000000)
            throw new ArgumentOutOfRangeException("Maksimal penambahan play count adalah 10 juta");

        checked
        {
            playCount += count;
        }
    }

    // Method untuk menampilkan detail video
    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}
