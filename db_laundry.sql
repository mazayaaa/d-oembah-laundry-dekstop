-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 29, 2023 at 12:34 PM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_laundry`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_detailtransaksi`
--

CREATE TABLE `tbl_detailtransaksi` (
  `id` int NOT NULL,
  `id_transaksi` varchar(15) COLLATE utf8mb4_general_ci NOT NULL,
  `id_layanan` int NOT NULL,
  `kuantitas` int NOT NULL,
  `total` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_detailtransaksi`
--

INSERT INTO `tbl_detailtransaksi` (`id`, `id_transaksi`, `id_layanan`, `kuantitas`, `total`) VALUES
(15, 'INV/001/12/2023', 1, 2, 2000),
(16, 'INV/001/12/2023', 2, 4, 200000),
(17, 'INV/002/12/2023', 1, 1, 1000),
(18, 'INV/002/12/2023', 2, 1, 50000),
(19, 'INV/003/12/2023', 1, 2, 40000),
(21, 'INV/003/12/2023', 2, 1, 15000),
(22, 'INV/004/12/2023', 2, 2, 30000),
(24, 'INV/004/12/2023', 1, 1, 20000),
(25, 'INV/005/12/2023', 2, 2, 30000),
(26, 'INV/005/12/2023', 1, 5, 100000),
(27, 'INV/010/12/2023', 1, 2, 40000),
(28, 'INV/010/12/2023', 2, 2, 30000),
(29, 'INV/011/12/2023', 2, 3, 45000),
(30, 'INV/011/12/2023', 1, 3, 60000),
(31, 'INV/012/12/2023', 1, 4, 80000),
(34, 'INV/013/12/2023', 12, 1, 7000),
(35, 'INV/013/12/2023', 11, 1, 10000),
(36, 'INV/013/12/2023', 10, 2, 12000),
(37, 'INV/014/12/2023', 10, 3, 18000),
(38, 'INV/014/12/2023', 11, 1, 10000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_layanan`
--

CREATE TABLE `tbl_layanan` (
  `id` int NOT NULL,
  `nama_layanan` varchar(30) COLLATE utf8mb4_general_ci NOT NULL,
  `durasi_layanan` int NOT NULL,
  `harga_layanan` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_layanan`
--

INSERT INTO `tbl_layanan` (`id`, `nama_layanan`, `durasi_layanan`, `harga_layanan`) VALUES
(1, 'Cuci Premium', 2, 20000),
(2, 'Cuci Ekspres', 1, 15000),
(9, 'Cuci Standar', 3, 5000),
(10, 'Cuci Setrika', 3, 6000),
(11, 'Seprei', 1, 10000),
(12, 'Jaket', 1, 7000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_owner`
--

CREATE TABLE `tbl_owner` (
  `id` varchar(5) COLLATE utf8mb4_general_ci NOT NULL,
  `nama_owner` varchar(30) COLLATE utf8mb4_general_ci NOT NULL,
  `password_owner` varchar(5) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_owner`
--

INSERT INTO `tbl_owner` (`id`, `nama_owner`, `password_owner`) VALUES
('DL01', 'mazaya', '12345'),
('DL02', 'putri', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `id` int NOT NULL,
  `nama_pelanggan` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `no_hppelanggan` varchar(15) COLLATE utf8mb4_general_ci NOT NULL,
  `alamat_pelanggan` varchar(50) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`id`, `nama_pelanggan`, `no_hppelanggan`, `alamat_pelanggan`) VALUES
(1, 'Dea', '085335599876', 'Graha Family'),
(2, 'Iluh', '085355252176', 'Citraland'),
(6, 'Putri', '083438729887', 'Medokan Asri'),
(7, 'Adibah', '081293433989', 'Lakar Santri'),
(8, 'Rizanna', '085298323911', 'Candi Asri');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `faktur` varchar(15) COLLATE utf8mb4_general_ci NOT NULL,
  `id_pelanggan` int NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `tgl_selesai` date NOT NULL,
  `metode_pembayaran` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `total` int NOT NULL,
  `total_bayar` int NOT NULL,
  `kembalian` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`faktur`, `id_pelanggan`, `tgl_transaksi`, `tgl_selesai`, `metode_pembayaran`, `total`, `total_bayar`, `kembalian`) VALUES
('INV/001/12/2023', 1, '2023-12-28', '2023-12-31', 'Tunai', 202000, 300000, 98000),
('INV/002/12/2023', 2, '2023-12-28', '2023-12-31', 'Tunai', 51000, 60000, 9000),
('INV/003/12/2023', 1, '2023-12-28', '2023-12-31', 'BCA', 65000, 100000, 35000),
('INV/004/12/2023', 2, '2023-12-28', '2023-12-31', 'QRIS', 80000, 100000, 20000),
('INV/005/12/2023', 1, '2023-12-28', '2023-12-30', 'Tunai', 130000, 150000, 20000),
('INV/006/12/2023', 1, '2023-12-28', '2023-12-30', 'Tunai', 40000, 40000, 0),
('INV/007/12/2023', 1, '2023-12-28', '2023-12-30', 'Tunai', 60000, 60000, 0),
('INV/008/12/2023', 1, '2023-12-28', '2023-12-30', 'BCA', 40000, 50000, 10000),
('INV/009/12/2023', 1, '2023-12-28', '2023-12-30', 'BCA', 60000, 70000, 10000),
('INV/010/12/2023', 2, '2023-12-28', '2023-12-30', 'Tunai', 70000, 70000, 0),
('INV/011/12/2023', 2, '2023-12-28', '2023-12-30', 'BCA', 105000, 105000, 0),
('INV/012/12/2023', 1, '2023-12-29', '2023-12-31', 'Tunai', 80000, 80000, 0),
('INV/013/12/2023', 7, '2023-12-29', '2024-01-01', 'Tunai', 29000, 30000, 1000),
('INV/014/12/2023', 1, '2023-12-29', '2024-01-01', 'BCA', 28000, 28000, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_detailtransaksi`
--
ALTER TABLE `tbl_detailtransaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_transaksi` (`id_transaksi`),
  ADD KEY `id_layanan` (`id_layanan`);

--
-- Indexes for table `tbl_layanan`
--
ALTER TABLE `tbl_layanan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_owner`
--
ALTER TABLE `tbl_owner`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`faktur`),
  ADD KEY `id_pelanggan` (`id_pelanggan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_detailtransaksi`
--
ALTER TABLE `tbl_detailtransaksi`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `tbl_layanan`
--
ALTER TABLE `tbl_layanan`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_detailtransaksi`
--
ALTER TABLE `tbl_detailtransaksi`
  ADD CONSTRAINT `tbl_detailtransaksi_ibfk_1` FOREIGN KEY (`id_transaksi`) REFERENCES `tbl_transaksi` (`faktur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_detailtransaksi_ibfk_2` FOREIGN KEY (`id_layanan`) REFERENCES `tbl_layanan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD CONSTRAINT `tbl_transaksi_ibfk_1` FOREIGN KEY (`id_pelanggan`) REFERENCES `tbl_pelanggan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
