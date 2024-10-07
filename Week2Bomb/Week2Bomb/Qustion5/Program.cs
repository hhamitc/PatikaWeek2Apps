internal class Program
{
    private static void Main(string[] args)
    {
        // 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

        Console.Write("Lütfen yaşınızı giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        string çıktı = yas >= 18 ? "+" : "-";

        Console.Write(çıktı);


        Console.ReadKey();
    }
}