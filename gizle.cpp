#include <iostream>
#include <fstream>
#include <filesystem>

using namespace std;
namespace fs = std::filesystem;

void dosyalari_birlestir() {
    string resim_dosyasi, rar_dosyasi, cikti_dosyasi;

    cout << "Resim dosyasının adını girin: ";
    cin >> resim_dosyasi;

    cout << "RAR dosyasının adını girin: ";
    cin >> rar_dosyasi;

    cout << "Oluşturulacak dosya adı: ";
    cin >> cikti_dosyasi;

    if (!fs::exists(resim_dosyasi)) {
        cout << "HATA: " << resim_dosyasi << " bulunamadı!" << endl;
        return;
    }

    if (!fs::exists(rar_dosyasi)) {
        cout << "HATA: " << rar_dosyasi << " bulunamadı!" << endl;
        return;
    }

    ifstream resim(resim_dosyasi, ios::binary);
    ifstream rar(rar_dosyasi, ios::binary);
    ofstream cikti(cikti_dosyasi, ios::binary);

    cikti << resim.rdbuf();
    cikti << rar.rdbuf();

    cout << "Tamamlandı
