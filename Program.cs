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
                { 1, "Elma " },
                { 2, "Armut " },
                { 3, "Çilek " },
                { 4, "Muz" },
                { 5, "DiğerBütünMeyveler"}

                
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
            // Geçerli seçim için fiyat bilgisini göster
            switch (secim)
            {
                case 1:
                    // Elma seçildiğinde fiyat 2 TL
                    Console.WriteLine("→Seçtiğiniz Meyvenin fiyati 2 TL'dir. ");
                    break;
                case 2:
                    // Armut seçildiğinde fiyat 3 TL
                    Console.WriteLine("→ Seçtiğiniz Meyvenin fiyati 3 TL'dir.");
                    
                    break;
                case 3:
                    // Çilek seçildiğinde fiyat 2 TL
                    Console.WriteLine("→ Seçtiğiniz Meyvenin fiyati 2 TL'dir.");
                  
                    break;
                case 4:
                    // Muz seçildiğinde fiyat 3 TL
                    Console.WriteLine("→ Seçtiğiniz Meyvenin fiyati 3 TL'dir.");
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