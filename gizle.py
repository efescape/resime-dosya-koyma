import os

def dosyalari_birlestir():
    resim_dosyasi = input("Resim dosyasının adını girin: ")
    rar_dosyasi = input("RAR dosyasının adını girin: ")
    cikti_dosyasi = input("Oluşturulacak dosya adı: ")

    if not os.path.exists(resim_dosyasi):
        print(f"HATA: {resim_dosyasi} bulunamadı!")
        return

    if not os.path.exists(rar_dosyasi):
        print(f"HATA: {rar_dosyasi} bulunamadı!")
        return

    with open(resim_dosyasi, "rb") as resim, open(rar_dosyasi, "rb") as rar, open(cikti_dosyasi, "wb") as cikti:
        cikti.write(resim.read())
        cikti.write(rar.read())

    print("Tamamlandı:", cikti_dosyasi)

dosyalari_birlestir()
