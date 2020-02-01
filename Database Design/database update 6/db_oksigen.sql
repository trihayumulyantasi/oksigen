-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Feb 2020 pada 09.26
-- Versi server: 10.4.6-MariaDB
-- Versi PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_oksigen`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `id_admin` varchar(20) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `jk` varchar(12) NOT NULL,
  `jabatan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`id_admin`, `username`, `password`, `alamat`, `no_telp`, `jk`, `jabatan`) VALUES
('adm1', 'admin1', 'admin1', 'Purwakarta', '087714646659', 'Perempuan', 'Owner');

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `id_barang` varchar(20) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga_jual` double NOT NULL,
  `harga_supplier` double NOT NULL,
  `stock` int(11) NOT NULL,
  `nama_supplier` varchar(20) NOT NULL,
  `waktu_input` date NOT NULL,
  `nama_admin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`id_barang`, `nama_barang`, `harga_jual`, `harga_supplier`, `stock`, `nama_supplier`, `waktu_input`, `nama_admin`) VALUES
('01', 'Shampoo', 2500, 2500, 10, 'Abang', '2020-01-27', 'admin1'),
('02', 'Shampoo bayi', 3000, 3000, 50, 'Affan', '2020-01-27', 'admin1'),
('03', 'Sabun', 6000, 6000, 50, 'Affan', '2020-01-27', 'admin1'),
('04', 'Pasta Gigi', 7000, 5000, 20, 'Affan', '2020-02-01', 'admin1'),
('05', 'Sikat Gigi', 5000, 3000, 20, 'Affan', '2020-01-27', 'admin1'),
('06', 'Garnier Facial Wash', 25000, 23500, 50, 'Abang', '2020-01-27', 'admin1'),
('07', 'Acnes Facial Wash', 27000, 24000, 50, 'Abang', '2020-01-27', 'admin1'),
('08', 'Parfum Eskulin', 15000, 12500, 50, 'Abang', '2020-01-27', 'admin1'),
('09', 'Sabun Lux', 4000, 2500, 70, 'Affan', '2020-01-27', 'admin1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id_detailtrans` varchar(20) NOT NULL,
  `tanggal` date NOT NULL,
  `waktu` time NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `harga_barang` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `laporan_harian`
--

CREATE TABLE `laporan_harian` (
  `id_lapharian` double NOT NULL,
  `id_transaksi` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `laporan_supplier`
--

CREATE TABLE `laporan_supplier` (
  `id_laporan` varchar(20) NOT NULL,
  `nama_supplier` varchar(20) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `tanggal_masuk` date NOT NULL,
  `tanggal_jatuhtempo` date NOT NULL,
  `status` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `laporan_supplier`
--

INSERT INTO `laporan_supplier` (`id_laporan`, `nama_supplier`, `nama_barang`, `tanggal_masuk`, `tanggal_jatuhtempo`, `status`, `username`) VALUES
('21', 'Affan', 'Shampoo bayi', '2020-01-28', '2020-01-22', 'Sudah Bayar', 'admin1'),
('23', 'Abang', 'Shampoo', '2020-01-28', '2020-01-17', 'Belum Bayar', 'admin1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE `supplier` (
  `id_supplier` varchar(20) NOT NULL,
  `nama_supplier` varchar(50) NOT NULL,
  `alamat_supplier` varchar(50) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `tanggal_input` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`id_supplier`, `nama_supplier`, `alamat_supplier`, `no_telp`, `tanggal_input`) VALUES
('001', 'Abang', 'Jatiluhur, Rt 21 Rw 05', '08112233334', '2020-01-16'),
('002', 'Affan', 'Munjul, Pondok Jaya Indah', '08994608117', '2020-01-01');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(20) NOT NULL,
  `tanggal` date NOT NULL,
  `waktu` time NOT NULL,
  `total_item` int(11) NOT NULL,
  `diskon` varchar(5) NOT NULL,
  `total_harga` double NOT NULL,
  `pembayaran` double NOT NULL,
  `kembalian` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indeks untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id_detailtrans`);

--
-- Indeks untuk tabel `laporan_harian`
--
ALTER TABLE `laporan_harian`
  ADD PRIMARY KEY (`id_lapharian`);

--
-- Indeks untuk tabel `laporan_supplier`
--
ALTER TABLE `laporan_supplier`
  ADD PRIMARY KEY (`id_laporan`);

--
-- Indeks untuk tabel `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
