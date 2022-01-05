-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 25, 2021 lúc 11:51 AM
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
-- Cấu trúc bảng cho bảng `khuyenmais`
--

CREATE TABLE `khuyenmais` (
  `daluu` int(5) DEFAULT NULL,
  `dieukien` int(8) DEFAULT NULL,
  `img` varchar(79) DEFAULT NULL,
  `loai` varchar(17) DEFAULT NULL,
  `makm` int(4) DEFAULT NULL,
  `manhap` varchar(10) DEFAULT NULL,
  `ngaybd` date DEFAULT NULL,
  `ngaykt` date DEFAULT NULL,
  `noidung` varchar(18) DEFAULT NULL,
  `phantram` int(8) DEFAULT NULL,
  `sl` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `khuyenmais`
--

INSERT INTO `khuyenmais` (`daluu`, `dieukien`, `img`, `loai`, `makm`, `manhap`, `ngaybd`, `ngaykt`, `noidung`, `phantram`, `sl`) VALUES
(14, 200, 'https://cdn2.iconfinder.com/data/icons/solid-black-labels/128/sale_copy-512.png', 'Free Ship', 101, 'VOUCHER001', '2021-06-10', '2022-02-02', 'Siêu to bự', 10, 7),
(11, 200, 'https://cdn2.iconfinder.com/data/icons/solid-black-labels/128/sale_copy-512.png', 'Free Ship', 102, 'VOUCHER002', '2021-06-10', '2022-06-06', 'Vip vip vip', 10, 10),
(13, 200, 'https://cdn2.iconfinder.com/data/icons/solid-black-labels/128/sale_copy-512.png', 'Free Ship', 103, 'VOUCHER003', '2021-06-10', '2022-02-02', 'Nghỉ lễ siêu vip', 10, 8),
(11, 200, 'https://cdn2.iconfinder.com/data/icons/solid-black-labels/128/sale_copy-512.png', 'mã giảm giá', 104, 'VOUCHER004', '2021-06-10', '2021-02-02', 'Còn không ta', 10, 10),
(10, 200, 'https://cdn2.iconfinder.com/data/icons/solid-black-labels/128/sale_copy-512.png', 'mã giảm giá', 105, 'VOUCHER005', '2021-12-10', '2021-12-22', 'Siêu sale tháng 12', 10, 11),
(18, 200, 'https://cdn2.iconfinder.com/data/icons/solid-black-labels/128/sale_copy-512.png', 'ưu đãi khách hàng', 106, 'VOUCHER006', '2021-12-10', '2021-12-31', 'Siêu sale cuối năm', 15, 3),
(11, 200, 'https://cdn2.iconfinder.com/data/icons/solid-black-labels/128/sale_copy-512.png', 'ưu đãi khách hàng', 107, 'VOUCHER007', '2021-12-10', '2021-12-31', 'Siêu sale cuối năm', 20, 10);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
