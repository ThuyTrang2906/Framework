-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 25, 2021 lúc 11:50 AM
-- Phiên bản máy phục vụ: 10.4.19-MariaDB
-- Phiên bản PHP: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `newbooks`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `client_accounts_framework`
--

CREATE TABLE `client_accounts` (
  `matk` int(4) DEFAULT NULL,
  `diachi` varchar(41) DEFAULT NULL,
  `diem` int(4) DEFAULT NULL,
  `email` varchar(22) DEFAULT NULL,
  `gioitinh` varchar(8) DEFAULT NULL,
  `hoten` varchar(13) DEFAULT NULL,
  `tentk` varchar(8) DEFAULT NULL,
  `matkhau` varchar(7) DEFAULT NULL,
  `ngaysinh` date DEFAULT NULL,
  `ngaytao` date DEFAULT NULL,
  `sl_giohang` int(10) DEFAULT NULL,
  `sodt` varchar(8) DEFAULT NULL,
  `tinhtrang` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `client_accounts_framework`
--

INSERT INTO `client_accounts` (`matk`, `diachi`, `diem`, `email`, `gioitinh`, `hoten`, `tentk`, `matkhau`, `ngaysinh`, `ngaytao`, `sl_giohang`, `sodt`, `tinhtrang`) VALUES
(201, 'Khu Phố 6,Linh Trung,Thủ Đức,Hồ Chí Minh ', 0, 'client002@gmail.com', 'Nam', 'Văn Đình Quốc', 'vdq1511', '11', '0000-00-00', '0000-00-00', 2, '43632435', 'Đang sử dụng'),
(202, 'An Phú, Thuận An, Bình Dương', 0, '19521550@gm.uit.edu.vn', 'Nữ', 'Hồng nguyễn', 'hongcute', '1', '0000-00-00', '0000-00-00', 2, '9898742', 'Đang sử dụng');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
