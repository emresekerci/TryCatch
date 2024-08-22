try
{
    Console.Write("Bir sayı girin: ");
    string input = Console.ReadLine();

    // Kullanıcının girdiği değeri double türüne dönüştürmeye çalışıyoruz
    double sayi = Convert.ToDouble(input);

    // Sayının karesini hesaplıyoruz
    double kare = sayi * sayi;

    // Karesini ekrana yazdırıyoruz
    Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
}
catch (FormatException)
{
    // Geçersiz giriş yapılırsa hata mesajı gösteriyoruz
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
}
catch (Exception ex)
{
    // Diğer olası istisnalar için genel bir hata mesajı
    Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
}