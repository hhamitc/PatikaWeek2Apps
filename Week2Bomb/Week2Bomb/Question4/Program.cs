internal class Program
{
    private static void Main(string[] args)
    {
        // 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

        Random random = new Random();

        int randomNumber = random.Next(1, 500);

        double kalan3 = randomNumber % 3;

        Console.WriteLine($"Sayi: {randomNumber}, 3'e bölümünden kalan {kalan3}");

        Console.ReadKey();
    }
}