Meyve Fiyat Sorgulama Konsol Uygulaması

Basit bir C# konsol uygulaması ile kullanıcıya meyve listesi sunup seçilen meyvenin fiyatını gösterir.

Özellikler

Meyve Listesi: Elma, Armut, Çilek, Muz ve Diğer tüm meyveler.

Kullanıcı Girdisi: 1–5 arasında bir sayı girerek seçim yapma.

Hata Kontrolü: Geçersiz girişlerde kullanıcı bilgilendirilir ve program sonlanır.

Switch-Case Yapısı: Seçilen meyveye göre farklı fiyat gösterimi.

Gereksinimler

.NET 6.0 veya üzeri

Herhangi bir C# destekleyen IDE veya metin editörü (Visual Studio, VS Code vb.)

Kurulum ve Çalıştırma

Proje dosyalarını indirin veya kopyalayın.

Komut satırında proje klasörüne gidin:

cd ifElseSwitch

Uygulamayı çalıştırın:

dotnet run

Kullanım

Uygulama çalıştığında ekrana meyve listesi ve numaraları yazdırılır:

1. Elma
2. Armut
3. Çilek
4. Muz
5. DiğerBütünMeyveler

Seçiminizi yapmak için 1–5 arasında bir sayı girip Enter tuşuna basın.

Seçtiğiniz meyvenin fiyatı ekrana yazdırılacaktır.

Geçersiz bir sayı veya metin girerseniz uygulama bir uyarı mesajı gösterip sonlanır.

Özelleştirme

Fiyatları switch bloğu içinde kolayca değiştirebilirsiniz.

Yeni meyveler eklemek için Dictionary<int, string> ve switch bloklarına ilgili satırları ekleyin.
