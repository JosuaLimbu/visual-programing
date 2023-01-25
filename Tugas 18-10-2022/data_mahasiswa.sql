-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Okt 2022 pada 12.46
-- Versi server: 10.4.25-MariaDB
-- Versi PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `data mahasiswa`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `hal_login`
--

CREATE TABLE `hal_login` (
  `ID` int(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` int(50) NOT NULL,
  `Level` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `hal_login`
--

INSERT INTO `hal_login` (`ID`, `Username`, `Password`, `Level`) VALUES
(11111111, 'Josua', 12345678, 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `Nama` varchar(50) NOT NULL,
  `NIM` int(20) NOT NULL,
  `Jenis_Kelamin` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `mahasiswa`
--

INSERT INTO `mahasiswa` (`Nama`, `NIM`, `Jenis_Kelamin`) VALUES
('Josua Limbu', 11111111, 'Pria'),
('Hendra', 22222222, 'Pria'),
('Gabriela Gracela', 33333333, 'Wanit'),
('Melati', 44444444, 'Wanit'),
('Antares Nathan', 55555555, 'Pria'),
('David', 66666666, 'Wanit');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `hal_login`
--
ALTER TABLE `hal_login`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indeks untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`NIM`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
