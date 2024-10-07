internal class Program
{
    private static void Main(string[] args)
    {
        //"    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

        string selam = "    Selamlar   ";

        string temizSelam = selam.Trim();
        Console.WriteLine(temizSelam + "+");// sonunda boşluk olmadığını konsolda da görerek emin olmak için + koydum.


        Console.ReadKey();
    }
}