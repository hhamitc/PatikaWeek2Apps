internal class Program
{
    private static void Main(string[] args)
    {
    // Yol arkadaşım tatil uygulaması; 
    //Bu pratikte bir yardımcı seyehat uygulaması ile kullanıcılarımızın planlayacakları 3 günlük bir tatilde harcayacakları yaklaşık tutarı hesaplamalarına yardımcı oluyoruz.

    #region Giriş ve Lokasyon 
    // Bu bölümde karşılamanın ardından lokasyon seçenekleri sunuluyor, ve seçime göre fiyat belirleniyor.
    Başla:
        Console.WriteLine("***** Yol Arkadaşım Karşılama *****");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Merhaba 'Yol arkadaşım' tatil uygulamamıza hoş geldiniz.\nSize en uygun tatil tercihini yapmak için en doğru yerdesiniz.");
        Console.WriteLine();
        Console.WriteLine("Bu dönemde sizin için önerebleceğimiz 3 ideal lokasyomuz var.");
        Console.WriteLine("\n1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
        Console.WriteLine("\n2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
        Console.WriteLine("\n3 - Cesme (Paket başlangıç fiyatı 5000 TL)");
        Console.WriteLine();
        Console.Write("Lütfen tercih ettiğiniz lokasyon adını giriniz: ");

        string lokasyon;
        int lFiyat = 0;

        while (true) //Lokasyon tercihini alıyoruz. Geçersiz bir seçenek girişinin önüne geçmek için kontrol ekliyoruz.
        {
            lokasyon = Console.ReadLine().ToLower(); //girilen veride büyük küçük harf karmaşası yaşanmaması için hepsini küçük harfe çevirerek alınıyor.

            if (lokasyon == "bodrum" || lokasyon == "marmaris" | lokasyon == "cesme")
            {
                Console.WriteLine($"Tebrikler! {lokasyon} lokasyonunu başarıyla seçtiniz.\n");
                switch (lokasyon)
                {
                    case "bodrum":
                        lFiyat = 4000;
                        break;
                    case "marmaris":
                        lFiyat = 3000;
                        break;
                    case "cesme":
                        lFiyat = 5000;
                        break;
                    default: break;
                }
                break;
            }
            else
            {
                Console.WriteLine("\nGeçersiz bir lokasyon girdiniz, Lütfen şunlardan birini giriniz: \nBodrum\nMarmaris\nCesme");
            }

        }
        #endregion
        #region Kişi Sayısı
        //Kişi sayısını alıyoruz.
        Console.WriteLine("\n Kaç kişi için bir tatil planlıyoruz?");

        int kisiSayisi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Anlaşıldı,{kisiSayisi} kişi için planlıyoruz. Teşekkürler.");
        Console.WriteLine();
        Console.WriteLine($"{lokasyon} konumunu ile çok güzel bir tercih yaptınız. \nAçık büfe kahvaltı ve akşam yemeği tercih ettiğiniz bölgedeki otelimize dahildir. \nAyrıca Spa ve Masaj hizmetlerinden de günde 1 kez yararlanabilirsiniz.\nHem denizin hem de havuzun tadını çıkarabilirsiniz.");
        Console.WriteLine();
        #endregion

        #region Ulaşım
        //Ulaşım tercihleri ile ilgili bilgi verip tercihi alıyoruz.
        Console.WriteLine($"Gelelim ulaşım konusunaa, {lokasyon} bölgesine ne şekilde gitmek istersiniz?  ");
        Console.WriteLine("\n2 Seçeneğimiz var: ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
        Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
        Console.WriteLine("Lütfen ulaşım seçiminizi '1' yada '2' şeklinde yapınız.");



        byte ulasim; //Yalnızca "1" ve "2" girişine izin vereceğimiz için byte tercih ettim.
        int uFiyat = 0;

        while (true)
        {
            ulasim = byte.Parse(Console.ReadLine());

            if (ulasim == 1 || ulasim == 2)
            {
                Console.WriteLine($"Tebrikler! {ulasim} tercihinizi başarıyla yaptınız.\n");
                uFiyat = (ulasim == 1) ? 1500 : 4000; // Ulaşım tercihine göre fiyat belirleniyor.
                break;
            }
            else
            {
                Console.WriteLine("\nGeçersiz bir değer girdiniz, Lütfen ulaşım seçiminizi '1' yada '2' şeklinde yapınız.");
            }

        }
        #endregion

        #region Hesaplama ve Sonuç
        //Tercihler sonucunda belirlenen tutarlar kişi sayısı ile çarpılarak toplam fiyat belirleniyor, ve kullanıcıya bildiriliyor.
        int toplamFiyat = kisiSayisi * (uFiyat + lFiyat);
        Console.WriteLine($"Yaptığınız tercihler sonucunda seyahatinizin toplam tutarı: {toplamFiyat} TL'dir. \n İyi tatiller dileriz.");

        //Yeni bir tatil planı yapmak isteniyorsa evet bilgisi talep ediliyor. Ve başa dönülüyor aksi taktirde, mesaj ile bitiriliyor.
        Console.WriteLine("\nYeni bir tatil planlamak istiyoranız lütfen 'evet' yazın.");
        string evetMi = Console.ReadLine().ToLower();
        if (evetMi == "evet") { Console.Clear(); goto Başla; }
        else { Console.WriteLine("\nİyi günler dileriz."); }
        #endregion

        Console.Read();
    }
}