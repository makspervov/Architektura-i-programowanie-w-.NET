using Lab1;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int zad;

        Console.Write("Wybierz zadanie: ");
        zad = Convert.ToInt32(Console.ReadLine());

        switch (zad)
        {
            case 1:
                Program.zad1();
                break;
            case 2:
                Program.zad2();
                break;
            //case 3:
            //    Program.zad3();
            //    break;
            default:
                Console.WriteLine("Nieprawidłowa liczba!!!");
                break;
        }
    }

    public static void zad1()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");

            else if (i % 5 == 0)
                Console.WriteLine("Buzz");

            else if (i % 3 == 0)
                Console.WriteLine("Fizz");

            else
                Console.WriteLine(i);
        }
    }

    public static void zad2()
    {
        var rand = new Random();
        var value = rand.Next(1, 101);
        int guess = 0;
        int trials = 1;

        Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Zgadnij ją!");

        while (guess != value)
        {
            Console.Write("Wprowadź wartość: ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < value)
            {
                Console.WriteLine("Za mało.");
                trials++;
            }
            else if (guess > value)
            {
                Console.WriteLine("Za dużo.");
                trials++;
            }
        }
        Console.WriteLine("Wygrana w " + trials + " próbie!");
        Console.Write("Wpisz swoje imię: ");
        string name = Console.ReadLine();

        var hs = new HighScore { Name = name, Trials = trials };

        List<HighScore> highScores;
        const string FileName = "highscores.json";

        if (File.Exists(FileName))
            highScores = JsonSerializer.Deserialize<List<HighScore>>(File.ReadAllText(FileName));
        else
            highScores = new List<HighScore>();

        highScores.Add(hs);
        File.WriteAllText(FileName, JsonSerializer.Serialize(highScores));
        foreach (var item in highScores)
        {
            Console.WriteLine($"{item.Name} -- {item.Trials} prób");
        }
    }

    //Rusiian Roulette in C# (nie wiem po co to napisałem)
    //public static void zad3()
    //{
    //    var rand = new Random();
    //    var value = rand.Next(1, 6);
    //    int guess = 0;
    //    string subPath = @"C:\Windows\System32";
    //    Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 6. Zgadnij ją!");

    //    if (guess == value)
    //    {
    //        Console.WriteLine("Goodbye!");
    //        Directory.Delete(subPath);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Super!");
    //    }
    //}
}

