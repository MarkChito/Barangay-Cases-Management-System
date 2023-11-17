-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 17, 2023 at 01:13 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `all_system_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barangaycasesmanagement_announcements`
--

CREATE TABLE `tbl_barangaycasesmanagement_announcements` (
  `primary_key` int(11) NOT NULL,
  `date_and_time` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `body` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barangaycasesmanagement_barangaycases`
--

CREATE TABLE `tbl_barangaycasesmanagement_barangaycases` (
  `primary_key` int(11) NOT NULL,
  `citizen_primary_key` int(11) NOT NULL,
  `date` varchar(255) NOT NULL,
  `time` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `mobile_number` varchar(255) NOT NULL,
  `address` text NOT NULL,
  `nature_of_complaint` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `image` longtext NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barangaycasesmanagement_barangaynews`
--

CREATE TABLE `tbl_barangaycasesmanagement_barangaynews` (
  `primary_key` int(11) NOT NULL,
  `date` varchar(255) NOT NULL,
  `time` varchar(255) NOT NULL,
  `title` text NOT NULL,
  `body` longtext NOT NULL,
  `image` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barangaycasesmanagement_citizens`
--

CREATE TABLE `tbl_barangaycasesmanagement_citizens` (
  `primary_key` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `sex` varchar(255) NOT NULL,
  `birthday` varchar(255) NOT NULL,
  `mobile_number` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `image` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barangaycasesmanagement_useraccounts`
--

CREATE TABLE `tbl_barangaycasesmanagement_useraccounts` (
  `primary_key` int(11) NOT NULL,
  `rfid_number` varchar(255) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `mobile_number` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` text NOT NULL,
  `position` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `image` longtext NOT NULL,
  `user_type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_barangaycasesmanagement_useraccounts`
--

INSERT INTO `tbl_barangaycasesmanagement_useraccounts` (`primary_key`, `rfid_number`, `first_name`, `middle_name`, `last_name`, `mobile_number`, `email`, `address`, `position`, `username`, `password`, `image`, `user_type`) VALUES
(1, '12345', 'Juan', '', 'Dela Cruz', '', '', '', 'Administrator', 'admin', '$2y$10$qZaaUdNw9dwAlnMZDFfqSOj5mVKvlNC86XHgRRWs/UaKyQMHZINby', 'default_user_image.png', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_barangaycasesmanagement_announcements`
--
ALTER TABLE `tbl_barangaycasesmanagement_announcements`
  ADD PRIMARY KEY (`primary_key`);

--
-- Indexes for table `tbl_barangaycasesmanagement_barangaycases`
--
ALTER TABLE `tbl_barangaycasesmanagement_barangaycases`
  ADD PRIMARY KEY (`primary_key`);

--
-- Indexes for table `tbl_barangaycasesmanagement_barangaynews`
--
ALTER TABLE `tbl_barangaycasesmanagement_barangaynews`
  ADD PRIMARY KEY (`primary_key`);

--
-- Indexes for table `tbl_barangaycasesmanagement_citizens`
--
ALTER TABLE `tbl_barangaycasesmanagement_citizens`
  ADD PRIMARY KEY (`primary_key`);

--
-- Indexes for table `tbl_barangaycasesmanagement_useraccounts`
--
ALTER TABLE `tbl_barangaycasesmanagement_useraccounts`
  ADD PRIMARY KEY (`primary_key`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_barangaycasesmanagement_announcements`
--
ALTER TABLE `tbl_barangaycasesmanagement_announcements`
  MODIFY `primary_key` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_barangaycasesmanagement_barangaycases`
--
ALTER TABLE `tbl_barangaycasesmanagement_barangaycases`
  MODIFY `primary_key` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_barangaycasesmanagement_barangaynews`
--
ALTER TABLE `tbl_barangaycasesmanagement_barangaynews`
  MODIFY `primary_key` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_barangaycasesmanagement_citizens`
--
ALTER TABLE `tbl_barangaycasesmanagement_citizens`
  MODIFY `primary_key` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_barangaycasesmanagement_useraccounts`
--
ALTER TABLE `tbl_barangaycasesmanagement_useraccounts`
  MODIFY `primary_key` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
