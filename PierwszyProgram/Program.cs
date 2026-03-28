internal class Program
{
    private static void Main(string[] args)
    {
        string szkola = "Szkoła programowania";
        Console.WriteLine($"Hello, World! Witaj w {szkola}!");
        Console.WriteLine("jak masz na imie?");
        string? imie = Console.ReadLine();
        Console.WriteLine($"Cześć buraku, {imie}!");
    }
}