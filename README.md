# 📦 Resim Dosyası İçine Veri Gizleme (Python / C++ / C#)

Bu proje, bir resim dosyası (jpg, png vb.) ile bir RAR arşivini tek bir dosyada birleştirip gizlemenizi sağlar.

Sonuç:
- Çıktı dosyası normal bir resim gibi açılır.
- WinRAR veya 7-Zip ile açıldığında içine gizlenen dosyalar çıkarılabilir.

Bu yöntem şifreleme değildir, sadece veri gizleme tekniğidir.

---

## 🚀 Nasıl Çalışır?

JPEG/PNG dosyaları fazladan veri eklendiğinde bozulmaz.  
Program şu işlemi yapar:

1. Resim dosyasını binary olarak okur
2. RAR dosyasını arkasına ekler
3. Tek bir dosya olarak kaydeder

CMD’deki şu komut ile aynı işi yapar:

copy /b resim.jpg + arsiv.rar cikti.jpg

---

## 📁 Dosya Hazırlığı

Aynı klasörde aşağıdakiler bulunmalıdır:

- Kod dosyası (Python, C++ veya C#)
- Bir resim dosyası → `deneme.jpg`
- Bir rar dosyası → `videolar.rar`

---

## ▶️ Kullanım

### Python:

python gizle.py

### C++:

g++ gizle.cpp -o gizle ./gizle

### C# (.NET CLI):

dotnet build dotnet run

Program dosya adlarını soracaktır:

Resim dosyasının adını girin: deneme.jpg RAR dosyasının adını girin: videolar.rar Oluşturulacak dosya adı: gizli.jpg

---

## 🔓 Gizli dosyayı geri çıkarmak

Oluşan `gizli.jpg` dosyasına:

- Sağ tık → **WinRAR ile aç**
- veya **Klasöre çıkart**

---
