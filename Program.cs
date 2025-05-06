using System;

namespace ifElseSwitch
{
    class Program
    {
        static void Main(string [] args)
        {
            MeyveListesi();
            



        }
        
        
        
        
        static void MeyveListesi() // Meyve Listesini oluşturduk
        {   // Meyve seçeneklerini tutan sözlük (anahtar: sıra numarası, değer: meyve adı)
            var MeyveListesi = new Dictionary<int, string>
            {
                { 1, "Elma = 2 TL " },
                { 2, "Armut =  3 TL " },
                { 3, "Çilek =  2 TL " },
                { 4, "Muz = 3 TL" },
                { 5, "DiğerBütünMeyveler = 2 TL"}

                
            };    
            // Menü başlığı
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz..:"); 

             // Her bir meyve seçeneğini numara ve adı ile ekrana yazdır
            foreach (var kvp in MeyveListesi)
            {
            Console.WriteLine($"{kvp.Key}. {kvp.Value}");
            }

             // Kullanıcıdan seçim numarasını al
            Console.Write("Seçiminiz (1-5): ");
            string giris = Console.ReadLine();

            // Giriş geçerli bir tam sayı mı ve sözlükte tanımlı bir anahtar mı kontrol et
            if (!int.TryParse(giris, out int secim) || !MeyveListesi.ContainsKey(secim))
            {
                // Hatalı giriş: kullanıcı bilgilendirilir ve metot sonlanır
                 Console.WriteLine(" Geçersiz seçim. Program sonlaniyor.");
                return;
            }

        /*
            // Seçime göre if-else yapısıyla fiyat bilgisi göster
        if (secim == 1)
        {
            // Elma
            Console.WriteLine("→ Seçtiğiniz Meyvenin fiyatı 2 TL'dir.");
        }
        else if (secim == 2)
        {
            // Armut
            Console.WriteLine("→ Seçtiğiniz Meyvenin fiyatı 3 TL'dir.");
        }
        else if (secim == 3)
        {
            // Çilek
            Console.WriteLine("→ Seçtiğiniz Meyvenin fiyatı 2 TL'dir.");
        }
        else if (secim == 4)
        {
            // Muz
            Console.WriteLine("→ Seçtiğiniz Meyvenin fiyatı 3 TL'dir.");
        }
        else if (secim == 5)
        {
            // Diğer Bütün Meyveler
            Console.WriteLine("→ Seçtiğiniz Meyvenin fiyatı 2 TL'dir.");
        }
        else
        {
            // Mantıksal olarak buraya girilmez, ama güvenlik için ekledik
            Console.WriteLine("Yanlış bir işlem yaptınız.");
        }
            */
           
        


            // Geçerli seçim için fiyat bilgisini göster
            switch (secim)
            {
                case 1:
                    // Elma seçildiğinde fiyat 2 TL
                    Console.WriteLine("→Elma'nin fiyati 2 TL'dir. ");
                    break;
                case 2:
                    // Armut seçildiğinde fiyat 3 TL
                    Console.WriteLine("→ Armut'un fiyati 3 TL'dir.");
                    
                    break;
                case 3:
                    // Çilek seçildiğinde fiyat 2 TL
                    Console.WriteLine("→ Çilek'in fiyati 2 TL'dir.");
                  
                    break;
                case 4:
                    // Muz seçildiğinde fiyat 3 TL
                    Console.WriteLine("→ Muz'un fiyati 3 TL'dir.");
                    break;

                case 5:
                    // Diğer tüm meyveler seçildiğinde fiyat 2 TL
                    Console.WriteLine("→ Seçtiğiniz Meyvenin fiyati 2 TL'dir.");   
                    break;

                default:
                    
                    Console.WriteLine("Yanliş bir işlem yaptiniz.");
                    break;
            }
        }
    }
    
}

//switch ise tek bir blok içinde bütün “durum–işlem” çiftlerini listeler; yeni bir seçenek eklemek veya sıralamayı görmek çok daha hızlıdır.
//Kodunuzu okuyan veya sonraki bir bakım geliştiricisinden, “diğer tüm durumlar buraya mı geliyor?” gibi sorular gelebilir. switch’te default bloğu net bir “kalan tüm durumlar” belirtisidir; if–else’te ise son bir else bazen eksik veya yanıltıcı olabilir.