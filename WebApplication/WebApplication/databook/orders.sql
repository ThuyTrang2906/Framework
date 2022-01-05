-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th1 01, 2022 lúc 10:28 AM
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
-- Cấu trúc bảng cho bảng `orders`
--

CREATE TABLE `orders` (
  `madh` int(4) NOT NULL,
  `hinhthucthanhtoan` varchar(17) DEFAULT NULL,
  `makm` int(4) DEFAULT NULL,
  `matk` int(8) DEFAULT NULL,
  `ngaycapnhat` date DEFAULT NULL,
  `ngaylap` date DEFAULT NULL,
  `phanhoi` varchar(20) DEFAULT NULL,
  `tienship` int(8) DEFAULT NULL,
  `tinhtrangdonhang` varchar(20) DEFAULT NULL,
  `tinhtrangthanhtoan` varchar(18) DEFAULT NULL,
  `tongtien` int(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `orders`
--

INSERT INTO `orders` (`madh`, `hinhthucthanhtoan`, `makm`, `matk`, `ngaycapnhat`, `ngaylap`, `phanhoi`, `tienship`, `tinhtrangdonhang`, `tinhtrangthanhtoan`, `tongtien`) VALUES
(701, 'Trực tuyến', 0, 201, '2021-12-24', '2021-12-21', '', 0, 'giao hàng thất bại', 'Đã thanh toán', 235000),
(702, 'Trực tiếp', 0, 202, '2021-12-24', '2021-12-22', 'khách hàng nhận hàng', 0, 'giao hàng thành công', 'Chưa thanh toán', 517000),
(703, 'Trực tiếp', 0, 202, '2021-12-24', '2021-12-22', 'khách hàng nhận hàng', 0, 'chờ xác nhận', 'Chưa thanh toán', 517000),
(704, 'Trực tiếp', 0, 202, '0000-00-00', '2021-12-22', '', 0, 'giao hàng thành công', 'dã thanh toán', 517000),
(705, 'Trực tuyến', 0, 201, '0000-00-00', '2021-12-31', '', 40000, 'đang vận chuyển', 'Đã thanh toán', 355000),
(706, 'Trực tuyến', 0, 0, '0000-00-00', '2021-12-31', '', 40000, 'chờ xác nhận', 'Đã thanh toán', 355000),
(707, 'Trực tuyến', 0, 0, '0000-00-00', '2021-12-31', '', 40000, 'chờ xác nhận', 'Đã thanh toán', 355000),
(708, 'Trực tuyến', 0, 0, '0000-00-00', '2021-12-31', '', 40000, 'chờ xác nhận', 'Đã thanh toán', 355000),
(709, 'Trực tuyến', 0, 0, '0000-00-00', '2021-12-31', '', 40000, 'chờ xác nhận', 'Đã thanh toán', 355000),
(710, 'Trực tuyến', 0, 0, '0000-00-00', '2021-12-31', '', 40000, 'chờ xác nhận', 'Đã thanh toán', 318000),
(711, 'Trực tuyến', 0, 0, '0000-00-00', '2021-12-31', '', 40000, 'chờ xác nhận', 'Đã thanh toán', 318000),
(712, 'Trực tuyến', 0, 0, '0000-00-00', '2021-12-31', '', 40000, 'chờ xác nhận', 'Đã thanh toán', 318000);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`madh`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `orders`
--
ALTER TABLE `orders`
  MODIFY `madh` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=713;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
