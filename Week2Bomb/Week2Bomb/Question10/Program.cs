internal class Program
{
    private static void Main(string[] args)
    {
        //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

        Console.Write("Lütfen True yada False bir değer giriniz: ");
        bool input = Convert.ToBoolean(Console.ReadLine());

        string output = CheckValue(input);
        Console.WriteLine(output);


        static string CheckValue(bool value)
        {
            if (value)
            {
                return "True değer girildi.";
            }
            else
            {
                return "False değer girildi.";
            }
        }


        Console.ReadKey();
    }
}