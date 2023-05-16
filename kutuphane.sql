-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                8.0.21 - MySQL Community Server - GPL
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- kutuphane için veritabanı yapısı dökülüyor
DROP DATABASE IF EXISTS `kutuphane`;
CREATE DATABASE IF NOT EXISTS `kutuphane` /*!40100 DEFAULT CHARACTER SET latin5 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `kutuphane`;

-- tablo yapısı dökülüyor kutuphane.kitaplar
DROP TABLE IF EXISTS `kitaplar`;
CREATE TABLE IF NOT EXISTS `kitaplar` (
  `kitap_id` int NOT NULL AUTO_INCREMENT,
  `tur_id` tinyint NOT NULL DEFAULT '0',
  `kitap_adi` varchar(40) NOT NULL DEFAULT '0',
  `yazar` varchar(40) NOT NULL DEFAULT '0',
  `yayinevi` varchar(40) NOT NULL DEFAULT '0',
  `sayfa_sayisi` smallint NOT NULL DEFAULT '0',
  PRIMARY KEY (`kitap_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.kitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitaplar`;
/*!40000 ALTER TABLE `kitaplar` DISABLE KEYS */;
INSERT INTO `kitaplar` (`kitap_id`, `tur_id`, `kitap_adi`, `yazar`, `yayinevi`, `sayfa_sayisi`) VALUES
	(1, 1, 'Küçük Prens', 'Valla Ben Değilim', 'Yaprak Yayınları', 186),
	(2, 1, 'Sadrazam', 'Valla Ben Değilim', 'Pusula Yayınları', 186),
	(3, 1, 'Büyük Prenses', 'Ben Yazdım', 'Düşler Yayınları', 298),
	(5, 1, 'Yere Yakın, Yıldızlara uzak', 'Valla Ben Değilim', 'Dünya Yayınları', 156),
	(6, 1, 'Beş Çember Kitabını da yazsanız hocam', 'Valla Ben Değilim', 'Toprak Yayınları', 386),
	(7, 1, 'Çalıkuşu', 'Reşat Nuri Güntekin', 'Armağan Yayınları', 541),
	(8, 1, 'Abdülhamit Kurtlarla Dansı', 'Mustafa Armağan', 'Timaş Yayınları', 562),
	(9, 1, 'Benim Adım Sena', 'Sena Yamakoğlu', 'Nesil Yayınları', 100);
/*!40000 ALTER TABLE `kitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.kitap_turleri
DROP TABLE IF EXISTS `kitap_turleri`;
CREATE TABLE IF NOT EXISTS `kitap_turleri` (
  `tur_id` tinyint NOT NULL AUTO_INCREMENT,
  `tur_adi` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`tur_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.kitap_turleri: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitap_turleri`;
/*!40000 ALTER TABLE `kitap_turleri` DISABLE KEYS */;
/*!40000 ALTER TABLE `kitap_turleri` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.odunc_kitaplar
DROP TABLE IF EXISTS `odunc_kitaplar`;
CREATE TABLE IF NOT EXISTS `odunc_kitaplar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ogr_no` int NOT NULL,
  `kitap_id` int NOT NULL,
  `verilis_tarihi` date NOT NULL,
  `teslim_tarihi` date DEFAULT NULL,
  `aciklama` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- kutuphane.odunc_kitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `odunc_kitaplar`;
/*!40000 ALTER TABLE `odunc_kitaplar` DISABLE KEYS */;
/*!40000 ALTER TABLE `odunc_kitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.ogrenciler
DROP TABLE IF EXISTS `ogrenciler`;
CREATE TABLE IF NOT EXISTS `ogrenciler` (
  `ogrenci_no` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(25) DEFAULT NULL,
  `soyad` varchar(25) DEFAULT NULL,
  `sinif` tinyint DEFAULT NULL,
  `cinsiyet` varchar(7) DEFAULT NULL,
  `telefon` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.ogrenciler: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `ogrenciler`;
/*!40000 ALTER TABLE `ogrenciler` DISABLE KEYS */;
/*!40000 ALTER TABLE `ogrenciler` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
