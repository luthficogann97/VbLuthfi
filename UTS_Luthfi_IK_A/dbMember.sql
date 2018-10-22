-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versi server:                 10.1.19-MariaDB - mariadb.org binary distribution
-- OS Server:                    Win32
-- HeidiSQL Versi:               9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Membuang struktur basisdata untuk dbmember
CREATE DATABASE IF NOT EXISTS `dbmember` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dbmember`;

-- membuang struktur untuk table dbmember.member
CREATE TABLE IF NOT EXISTS `member` (
  `Member_Id` varchar(20) NOT NULL,
  `Nama_lengkap` varchar(50) DEFAULT NULL,
  `Jenis_kelamin` enum('Y','N') DEFAULT NULL,
  `Tanggal_lahir` date DEFAULT NULL,
  `Telpon` varchar(15) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Alamat` varchar(50) DEFAULT NULL,
  `Kota` varchar(50) DEFAULT NULL,
  `Kode_pos` varchar(10) DEFAULT NULL,
  `Catatan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`member_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Pengeluaran data tidak dipilih.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
