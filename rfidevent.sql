-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jul 31, 2023 at 08:23 AM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `rfidevent`
--
CREATE DATABASE IF NOT EXISTS `rfidevent` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `rfidevent`;

-- --------------------------------------------------------

--
-- Table structure for table `tblevent`
--

CREATE TABLE IF NOT EXISTS `tblevent` (
  `eventid` varchar(50) NOT NULL,
  `event` varchar(50) NOT NULL,
  `penalty` decimal(10,2) NOT NULL,
  `status` varchar(50) NOT NULL,
  PRIMARY KEY (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbllog`
--

CREATE TABLE IF NOT EXISTS `tbllog` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `eventid` varchar(50) NOT NULL,
  `studentno` varchar(50) NOT NULL,
  `sdate` date NOT NULL,
  `amin` varchar(50) NOT NULL DEFAULT '---------------',
  `amout` varchar(50) NOT NULL DEFAULT '---------------',
  `pmin` varchar(50) NOT NULL DEFAULT '---------------',
  `pmout` varchar(50) NOT NULL DEFAULT '---------------',
  `total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=329 ;

-- --------------------------------------------------------

--
-- Table structure for table `tblstudent`
--

CREATE TABLE IF NOT EXISTS `tblstudent` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `studentno` varchar(50) NOT NULL,
  `rfid` varchar(50) NOT NULL,
  `fullname` varchar(200) NOT NULL,
  `address` text NOT NULL,
  `mobileno` varchar(50) NOT NULL,
  `program` varchar(50) NOT NULL,
  `section` varchar(50) NOT NULL,
  `pic` mediumblob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=70 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(150) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`username`, `password`, `name`) VALUES
('admin', '1234', 'Joemel E. Resare');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
