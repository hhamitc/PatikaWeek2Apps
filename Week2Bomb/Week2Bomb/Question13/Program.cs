internal class Program
{
    private static void Main(string[] args)
    {

        //13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
        Console.Write("1.Adı giriniz: ");
        string ad1 = Console.ReadLine();
        Console.Write("2.Adı giriniz: ");
        string ad2 = Console.ReadLine();

        changeName(ref ad1, ref ad2);

        Console.WriteLine("1.Ad: " + ad1);
        Console.WriteLine("2.Ad: " + ad2);




        static void changeName(ref string name1, ref string name2)
        {
            string geciciAd = name1;
            name1 = name2;
            name2 = geciciAd;
        }




        Console.ReadKey();
    }
}