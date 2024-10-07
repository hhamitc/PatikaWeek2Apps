internal class Program
{
    private static void Main(string[] args)
    {
        //7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.


        Console.Write("Metin 1'i giriniz: ");
        string string1 = Console.ReadLine();
        Console.Write("Metin 2'yi giriniz: ");
        string string2 = Console.ReadLine();

        ChangeValues(ref string1, ref string2);

        Console.WriteLine("1. " + string1);
        Console.WriteLine("2. " + string2);






        void ChangeValues(ref string a, ref string b)
        {
            string geciciDeger = a;
            a = b;
            b = geciciDeger;
        }

        Console.ReadKey();
    }
}