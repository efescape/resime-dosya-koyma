using System;
using System.IO;

class Program
{
    static void DosyalariBirlestir()
    {
        Console.Write("Resim dosyasının adını girin: ");
        string resimDosyasi = Console.ReadLine();

        Console.Write("RAR dosyasının adını girin: ");
        string rarDosyasi = Console.ReadLine();

        Console.Write("Oluşturulacak dosya adı: ");
        string ciktiDosyasi = Console.ReadLine();

        if (!File.Exists(resimDosyasi))
        {
            Console.WriteLine($"HATA: {resimDosyasi} bulunamadı!");
            return;
        }

        if (!File.Exists(rarDosyasi))
        {
            Console.WriteLine($"HATA: {rarDosyasi} bulunamadı!");
            return;
        }

        using (FileStream fResim = new FileStream(resimDosyasi, FileMode.Open))
        using (FileStream fRar = new FileStream(rarDosyasi, FileMode.Open))
        using (FileStream fCikti = new FileStream(ciktiDosyasi, FileMode.Create))
        {
            fResim.CopyTo(fCikti);
            fRar.CopyTo(fCikti);
        }

        Console.WriteLine("Tamamlandı: " + ciktiDosyasi);
    }

    static void Main()
    {
        DosyalariBirlestir();
    }
}
