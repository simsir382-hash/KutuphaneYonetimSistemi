CREATE DATABASE KutuphaneDB;
GO

USE KutuphaneDB;
GO

CREATE TABLE Kullanicilar (
    Id INT PRIMARY KEY IDENTITY(1,1),
    KullaniciAdi VARCHAR(50) NOT NULL,
    Sifre VARCHAR(50) NOT NULL,
    AdSoyad VARCHAR(100)
);

CREATE TABLE Kitaplar (
    Id INT PRIMARY KEY IDENTITY(1,1),
    KitapAd VARCHAR(100) NOT NULL,
    Yazar VARCHAR(100),
    SayfaSayisi INT,
    Stok INT DEFAULT 1
);

CREATE TABLE Uyeler (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UyeNo VARCHAR(20) NOT NULL,
    Ad VARCHAR(50) NOT NULL,
    Soyad VARCHAR(50) NOT NULL,
    Telefon VARCHAR(15)
);

INSERT INTO Kullanicilar (KullaniciAdi, Sifre, AdSoyad) 
VALUES ('admin', '1234', 'Yönetici');

INSERT INTO Kitaplar (KitapAd, Yazar, SayfaSayisi, Stok)
VALUES ('Nutuk', 'Mustafa Kemal Atatürk', 543, 5);