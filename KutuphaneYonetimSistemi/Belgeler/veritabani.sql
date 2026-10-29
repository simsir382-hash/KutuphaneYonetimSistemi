CREATE DATABASE KutuphaneDB;
GO

USE KutuphaneDB;
GO

-- 1. Kullanıcılar Tablosu (Giriş için)
CREATE TABLE Kullanicilar (
    Id INT PRIMARY KEY IDENTITY(1,1),
    KullaniciAdi VARCHAR(50) NOT NULL,
    Sifre VARCHAR(50) NOT NULL,
    AdSoyad VARCHAR(100)
);

-- 2. Kitaplar Tablosu
CREATE TABLE Kitaplar (
    Id INT PRIMARY KEY IDENTITY(1,1),
    KitapAd VARCHAR(100) NOT NULL,
    Yazar VARCHAR(100),
    SayfaSayisi INT,
    Stok INT DEFAULT 1
);

-- 3. Üyeler Tablosu
CREATE TABLE Uyeler (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UyeNo VARCHAR(20) NOT NULL,
    Ad VARCHAR(50) NOT NULL,
    Soyad VARCHAR(50) NOT NULL,
    Telefon VARCHAR(15)
);

-- Varsayılan Giriş Kullanıcısı
INSERT INTO Kullanicilar (KullaniciAdi, Sifre, AdSoyad) 
VALUES ('admin', '1234', 'Yönetici');
