-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2022 at 05:14 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penginapan`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `CariBerdasarkanNamaTamu` (`nama` VARCHAR(100))  BEGIN
select tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_tamu.nama_tamu like nama;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariBerdasarkanTipeKamar` (`id` INT(10))  BEGIN
select id_kamar, nama, deskripsi, harga, status from tbl_kamar left join tbl_tipe_kamar on tbl_kamar.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_kamar.id_tipe_kamar=id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariKamarBerdasarkanNoKamar` (`no` INT(10))  BEGIN
select id_kamar, nama, deskripsi, harga, status from tbl_kamar left join tbl_tipe_kamar on tbl_kamar.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where id_kamar=no;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariPesananIdReservasi` (`nm` INT(5))  BEGIN
select tbl_pesanan.id_reservasi, id_kamar, nama, tgl_cek_in, tgl_cek_out, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu where tbl_reservasi.id_reservasi=nm;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariPesananTglNoKamar` (`tgl` VARCHAR(10), `nm` INT(5))  BEGIN
select tbl_pesanan.id_reservasi, id_kamar, nama, tgl_cek_in, tgl_cek_out, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu where tbl_pesanan.tgl=tgl and tbl_reservasi.id_kamar=nm;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariReservasi` ()  BEGIN
select id_reservasi, nama_tamu, tbl_kamar.id_kamar, tgl_cek_in, tgl_cek_out from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.status='N';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariReservasiBerdasarkanKamar` (`no` INT(10))  BEGIN
select id_reservasi, tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total, tbl_tamu.id_tamu, tbl_tipe_kamar.id_tipe_kamar from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.id_kamar=no and tbl_reservasi.status='N';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariReservasiBerdasarkanKamar2` (`no` INT(10))  BEGIN
select id_reservasi, nama_tamu, tbl_kamar.id_kamar, tgl_cek_in, tgl_cek_out from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.id_kamar=no and tbl_reservasi.status='N';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CekOut` (`idRs` INT(10), `idTm` INT(10), `idKm` INT(10), `idTip` INT(10), `idUs` INT(10), `tot` INT(20), `tgByr` VARCHAR(20), `thnByr` VARCHAR(20))  BEGIN
insert into tbl_pembayaran (id_reservasi, id_tamu, id_kamar, id_tipe_kamar, id_user, total_bayar, bulan, tahun) values (idRs, idTm, idKm, idTip, idUs, tot, tgByr, thnByr);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DataReservasi` ()  BEGIN
select id_reservasi, tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total, tbl_tamu.id_tamu, tbl_tipe_kamar.id_tipe_kamar from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.status='N';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ExportLaporan` (`bln` INT(10), `thn` INT(10))  BEGIN
select nama_tamu, tbl_kamar.id_kamar, total_bayar, bulan, tahun, username from tbl_pembayaran left join (tbl_tamu,tbl_kamar,tbl_user) on tbl_pembayaran.id_tamu=tbl_tamu.id_tamu and tbl_pembayaran.id_kamar=tbl_kamar.id_kamar and tbl_pembayaran.id_user=tbl_user.id_user where bulan=bln and tahun=thn;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LihatLaporan` ()  BEGIN
select nama_tamu, tbl_kamar.id_kamar, total_bayar, bulan, tahun, username from tbl_pembayaran left join (tbl_tamu,tbl_kamar,tbl_user) on tbl_pembayaran.id_tamu=tbl_tamu.id_tamu and tbl_pembayaran.id_kamar=tbl_kamar.id_kamar and tbl_pembayaran.id_user=tbl_user.id_user;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LihatPesananPerTamu` (`id` INT(10))  BEGIN
select id_kamar, nama, (harga*jumlah_pesanan) as total, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu where tbl_pesanan.id_reservasi=id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LihatTamu` ()  BEGIN
select id_tamu, nama_tamu, no_telpon from tbl_tamu;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LihatTipe` ()  BEGIN
select id_tipe_kamar, nama from tbl_tipe_kamar;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `loginUser` (`user` VARCHAR(40), `pass` VARCHAR(40))  BEGIN
select * from tbl_user where username='user' and password='pass';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahKamar` (`id_tipe` INT(10), `deskr` VARCHAR(400), `stts` VARCHAR(1))  BEGIN
insert into tbl_kamar (id_tipe_kamar, deskripsi, status) values (id_tipe, deskr, stts);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahMenu` (`nm` VARCHAR(100), `hrg` VARCHAR(100))  BEGIN
insert into tbl_menu (nama, harga) values (nm, hrg);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahPesanan` (`id_rs` INT(10), `id_mn` INT(10), `jml` INT(10), `tgl` VARCHAR(10))  BEGIN
insert into tbl_pesanan (id_reservasi, id_menu, jumlah_pesanan, tgl) values(id_rs,id_mn,jml,tgl);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `tambahReservasi` (`id_tamu` INT(10), `id_user` INT(10), `id_tipe_kamar` INT(10), `id_kamar` INT(10), `tgl_cek_in` VARCHAR(20), `tgl_cek_out` VARCHAR(20), `lama` INT(10))  BEGIN
insert into tbl_reservasi (id_tamu, id_user, id_tipe_kamar, id_kamar, tgl_cek_in, tgl_cek_out, lama_menginap, status) values (id_tamu, id_user, id_tipe_kamar, id_kamar, tgl_cek_in, tgl_cek_out, lama, 'N');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahTamu` (`nama` VARCHAR(100), `almt` VARCHAR(100), `tlpn` VARCHAR(40), `jk` VARCHAR(1), `kerja` VARCHAR(50))  BEGIN
insert into tbl_tamu (nama_tamu, alamat, no_telpon, jk, pekerjaan) values (nama, almt, tlpn, jk, kerja);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahTipeKamar` (`nama` VARCHAR(100), `harga` VARCHAR(20))  BEGIN
insert into tbl_tipe_kamar (nama, harga) values (nama, harga);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilKamar` ()  BEGIN
select id_kamar, nama, deskripsi, harga, status from tbl_kamar left join tbl_tipe_kamar on tbl_kamar.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilMenu` ()  BEGIN
select * from tbl_menu;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilPesanan` ()  BEGIN
select tbl_pesanan.id_reservasi, id_kamar, nama, tgl_cek_in, tgl_cek_out, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilTamu` ()  BEGIN
select * from tbl_tamu;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TipeKamar` ()  BEGIN
select * from tbl_tipe_kamar;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateStatusKamar` (`id_kamar` INT(10))  BEGIN
update tbl_kamar set status='Y' where id_kamar='id_kamar';
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kamar`
--

CREATE TABLE `tbl_kamar` (
  `id_kamar` int(10) NOT NULL,
  `id_tipe_kamar` int(10) NOT NULL,
  `deskripsi` text NOT NULL,
  `status` varchar(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_kamar`
--

INSERT INTO `tbl_kamar` (`id_kamar`, `id_tipe_kamar`, `deskripsi`, `status`) VALUES
(1, 1, 'Dilengkapi dengan AC, double bad, shower, dan televisi', 'N'),
(2, 1, 'Dilengkapi dengan AC, double bad, shower, dan televisi', 'N'),
(3, 1, 'Dilengkapi dengan AC, double bad, shower, dan televisi', 'N'),
(4, 2, 'Dilengkapi dengan AC, double bad, shower, dan televisi. Kamar yang nyaman, dijamin anda akan puas.', 'N'),
(5, 2, 'Dilengkapi dengan AC, double bad, shower, dan televisi. Kamar yang nyaman, dijamin anda akan puas.', 'N'),
(6, 1, 'Dilengkapi dengan AC, double bad, shower, dan televisi', 'N');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_menu`
--

CREATE TABLE `tbl_menu` (
  `id_menu` int(10) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `harga` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_menu`
--

INSERT INTO `tbl_menu` (`id_menu`, `nama`, `harga`) VALUES
(1, 'Nasi Goreng Biasa', 10000),
(2, 'Nasi Goreng Spesial', 18000),
(3, 'Rujak Soto', 8000),
(4, 'Sop Buntut Spesial', 13000),
(5, 'Ayam Bakar Kalasan', 14000),
(6, 'Ayam Goreng Crispy', 12000),
(7, 'Es Jeruk', 5000),
(8, 'Es Degan Susu', 4000),
(9, 'Es Cappucino', 8000),
(10, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pembayaran`
--

CREATE TABLE `tbl_pembayaran` (
  `id_pembayaran` int(10) NOT NULL,
  `id_reservasi` int(10) NOT NULL,
  `id_tamu` int(10) NOT NULL,
  `id_kamar` int(10) NOT NULL,
  `id_tipe_kamar` int(10) NOT NULL,
  `id_user` int(10) NOT NULL,
  `total_bayar` int(30) NOT NULL,
  `bulan` varchar(5) NOT NULL,
  `tahun` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pembayaran`
--

INSERT INTO `tbl_pembayaran` (`id_pembayaran`, `id_reservasi`, `id_tamu`, `id_kamar`, `id_tipe_kamar`, `id_user`, `total_bayar`, `bulan`, `tahun`) VALUES
(1, 4, 1, 5, 1, 2, 820000, '1', '2011'),
(2, 5, 2, 1, 2, 2, 1228000, '1', '2011'),
(3, 6, 2, 3, 2, 1, 1318000, '1', '2011'),
(4, 7, 2, 5, 2, 2, 428000, '1', '2011');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pesanan`
--

CREATE TABLE `tbl_pesanan` (
  `id_pesanan` int(10) NOT NULL,
  `id_reservasi` int(10) NOT NULL,
  `id_menu` int(10) NOT NULL,
  `jumlah_pesanan` int(10) NOT NULL,
  `tgl` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pesanan`
--

INSERT INTO `tbl_pesanan` (`id_pesanan`, `id_reservasi`, `id_menu`, `jumlah_pesanan`, `tgl`) VALUES
(1, 4, 1, 2, '23/01/2011'),
(2, 5, 1, 2, '23/01/2011'),
(3, 5, 8, 2, '23/01/2011'),
(4, 6, 5, 3, '23/01/2011'),
(5, 6, 9, 5, '23/01/2011'),
(6, 6, 6, 2, '24/01/2011'),
(7, 6, 8, 3, '24/01/2011'),
(8, 7, 1, 2, '29/01/2011'),
(9, 7, 8, 2, '29/01/2011');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reservasi`
--

CREATE TABLE `tbl_reservasi` (
  `id_reservasi` int(10) NOT NULL,
  `id_tamu` int(10) NOT NULL,
  `id_user` int(10) NOT NULL,
  `id_tipe_kamar` int(10) NOT NULL,
  `id_kamar` int(10) NOT NULL,
  `tgl_cek_in` varchar(20) NOT NULL,
  `tgl_cek_out` varchar(20) NOT NULL,
  `lama_menginap` varchar(20) NOT NULL,
  `status` varchar(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_reservasi`
--

INSERT INTO `tbl_reservasi` (`id_reservasi`, `id_tamu`, `id_user`, `id_tipe_kamar`, `id_kamar`, `tgl_cek_in`, `tgl_cek_out`, `lama_menginap`, `status`) VALUES
(1, 1, 2, 1, 3, '23/01/2011', '25/01/2011', '2', 'Y'),
(2, 3, 2, 1, 3, '23/01/2011', '26/01/2011', '3', 'Y'),
(3, 2, 2, 1, 2, '23/01/2011', '28/01/2011', '5', 'Y'),
(4, 1, 2, 2, 5, '23/01/2011', '25/01/2011', '2', 'Y'),
(5, 2, 2, 1, 1, '23/01/2011', '29/01/2011', '6', 'Y'),
(6, 2, 2, 1, 3, '23/01/2011', '29/01/2011', '6', 'Y'),
(7, 2, 2, 2, 5, '29/01/2011', '30/01/2011', '1', 'Y');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tamu`
--

CREATE TABLE `tbl_tamu` (
  `id_tamu` int(10) NOT NULL,
  `nama_tamu` varchar(100) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_telpon` varchar(20) NOT NULL,
  `jk` varchar(1) NOT NULL,
  `pekerjaan` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_tamu`
--

INSERT INTO `tbl_tamu` (`id_tamu`, `nama_tamu`, `alamat`, `no_telpon`, `jk`, `pekerjaan`) VALUES
(1, 'Gede Suma Wijaya', 'Denpasar', '081916186418', 'L', 'Kuli Coding'),
(2, 'Willy Witanto', 'Banyuwangi', '081805394038', 'L', 'Kuli Jaringan'),
(3, 'Ayus Nyemplung', 'Banyuwangi', '081236987343', 'L', 'Kuli HaPe'),
(4, 'Puji Agustian AW', 'Rogojampi', '081555799323', 'L', 'Kuli Coding'),
(5, 'Untung Jasuli', 'Situbondo Rock City', '081999345678', 'L', 'Kuli Coding');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tipe_kamar`
--

CREATE TABLE `tbl_tipe_kamar` (
  `id_tipe_kamar` int(10) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `harga` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_tipe_kamar`
--

INSERT INTO `tbl_tipe_kamar` (`id_tipe_kamar`, `nama`, `harga`) VALUES
(1, 'Eksekutif', 200000),
(2, 'VIP', 400000),
(3, 'Standar', 100000),
(4, 'Super VIP', 600000),
(5, 'Melati', 50000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL,
  `nama_lengkap` varchar(100) NOT NULL,
  `kelahiran` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `username`, `password`, `nama_lengkap`, `kelahiran`) VALUES
(1, 'lumbung', 'lumbung', 'Gede Suma Wijaya', 'Denpasar, 4 Februari 1991'),
(2, 'gede', 'gede', 'Wayan Gede Suma Wijaya', 'Denpasar, 4 Februari 1991');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_kamar`
--
ALTER TABLE `tbl_kamar`
  ADD PRIMARY KEY (`id_kamar`);

--
-- Indexes for table `tbl_menu`
--
ALTER TABLE `tbl_menu`
  ADD PRIMARY KEY (`id_menu`);

--
-- Indexes for table `tbl_pembayaran`
--
ALTER TABLE `tbl_pembayaran`
  ADD PRIMARY KEY (`id_pembayaran`);

--
-- Indexes for table `tbl_pesanan`
--
ALTER TABLE `tbl_pesanan`
  ADD PRIMARY KEY (`id_pesanan`);

--
-- Indexes for table `tbl_reservasi`
--
ALTER TABLE `tbl_reservasi`
  ADD PRIMARY KEY (`id_reservasi`);

--
-- Indexes for table `tbl_tamu`
--
ALTER TABLE `tbl_tamu`
  ADD PRIMARY KEY (`id_tamu`);

--
-- Indexes for table `tbl_tipe_kamar`
--
ALTER TABLE `tbl_tipe_kamar`
  ADD PRIMARY KEY (`id_tipe_kamar`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_kamar`
--
ALTER TABLE `tbl_kamar`
  MODIFY `id_kamar` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_menu`
--
ALTER TABLE `tbl_menu`
  MODIFY `id_menu` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_pembayaran`
--
ALTER TABLE `tbl_pembayaran`
  MODIFY `id_pembayaran` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_pesanan`
--
ALTER TABLE `tbl_pesanan`
  MODIFY `id_pesanan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_reservasi`
--
ALTER TABLE `tbl_reservasi`
  MODIFY `id_reservasi` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_tamu`
--
ALTER TABLE `tbl_tamu`
  MODIFY `id_tamu` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_tipe_kamar`
--
ALTER TABLE `tbl_tipe_kamar`
  MODIFY `id_tipe_kamar` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
