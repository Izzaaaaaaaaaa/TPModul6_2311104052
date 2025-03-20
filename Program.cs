using System;

class Program
{
    static void Main()
    {
        // Membuat objek SayaTubeVideo
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Izzaty Zahara");

        // Menampilkan detail awal
        video.PrintVideoDetails();

        // Menambahkan play count dengan nilai yang valid
        video.IncreasePlayCount(5000000);
        video.PrintVideoDetails();

        // Menguji exception dengan jumlah lebih dari 10 juta
        try
        {
            video.IncreasePlayCount(15000000);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        // Menguji overflow dengan loop (harus menangani exception)
        try
        {
            for (int i = 0; i < 1000000; i++)
                video.IncreasePlayCount(10000000);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Overflow terjadi saat menambahkan play count!");
            Console.ReadLine();
        }
    }
}
