-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th1 08, 2022 lúc 06:01 PM
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
-- Cơ sở dữ liệu: `bookstore`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `user_cmt`
--

CREATE TABLE `user_cmt` (
  `matk` int(7) NOT NULL,
  `masach` int(7) NOT NULL,
  `binhluan` varchar(100) NOT NULL,
  `ngaybl` datetime NOT NULL,
  `sosao` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `user_cmt`
--

INSERT INTO `user_cmt` (`matk`, `masach`, `binhluan`, `ngaybl`, `sosao`) VALUES
(202, 8001, 'Sách hay lắm', '2021-11-12 00:00:00', 4),
(202, 8009, 'adhfgdshfsgh', '0001-01-01 00:00:00', 5),
(202, 8009, 'nội dung hay', '0001-01-01 00:00:00', 5),
(202, 8009, 'sách hay đó', '2022-01-08 17:59:07', 3),
(202, 8009, 'sách oko', '2022-01-08 18:00:03', 3),
(202, 8002, 'sách hay', '2022-01-08 21:52:07', 3),
(202, 8001, 'hong hay', '2022-01-08 22:02:26', 4),
(202, 8001, 'cũng được mà thôi đừng mua', '2022-01-08 22:06:38', 4),
(202, 8002, 'đọc buồn ngủ lắm', '2022-01-08 22:09:20', 2),
(202, 8001, 'okla đó đừng tin mấy đứa kia', '2022-01-08 22:13:13', 5),
(202, 8001, 'được', '2022-01-08 22:17:13', 3),
(202, 8015, 'hay', '2022-01-08 23:03:20', 3),
(202, 8001, 'hgfgfgfg', '2022-01-08 23:13:39', 3),
(202, 8001, 'jhhghgghh', '2022-01-08 23:27:29', 3),
(202, 8002, 'hay', '2022-01-08 23:30:36', 3),
(202, 8001, 'hádhsag', '2022-01-08 23:36:09', 3),
(202, 8001, 'được đó', '2022-01-08 23:38:18', 4),
(202, 8001, 'cũng được được', '2022-01-08 23:48:15', 3);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
