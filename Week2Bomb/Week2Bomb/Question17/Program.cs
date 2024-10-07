internal class Program
{
    private static void Main(string[] args)
    {
        //"Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

        string cumle = "Zaman bir GeRi SayIm";

        string buyukCumle = cumle.ToUpper();
        string kucukCumle = cumle.ToLower();

        Console.WriteLine(buyukCumle + "\n" + kucukCumle);




        Console.ReadKey();
    }
}