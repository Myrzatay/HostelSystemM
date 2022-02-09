-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Фев 07 2022 г., 21:54
-- Версия сервера: 10.4.17-MariaDB
-- Версия PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `hotel_data`
--

-- --------------------------------------------------------

--
-- Структура таблицы `category`
--

CREATE TABLE `category` (
  `CategoryId` int(10) NOT NULL,
  `Label` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `category`
--

INSERT INTO `category` (`CategoryId`, `Label`) VALUES
(1, 'Single'),
(2, 'Double'),
(3, 'Family'),
(4, 'Suite');

-- --------------------------------------------------------

--
-- Структура таблицы `guest`
--

CREATE TABLE `guest` (
  `GuestId` varchar(20) NOT NULL,
  `GuestFirstName` varchar(10) NOT NULL,
  `GuestLastName` varchar(20) NOT NULL,
  `GuestPhone` varchar(15) NOT NULL,
  `GuestCity` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `guest`
--

INSERT INTO `guest` (`GuestId`, `GuestFirstName`, `GuestLastName`, `GuestPhone`, `GuestCity`) VALUES
('1', 'Amir', 'Dyussembayev', 'Dyussembayev', 'Rzeszow'),
('2', 'Khassan', 'Dyussembayev', 'Dyussembayev', 'Rzeszow');

-- --------------------------------------------------------

--
-- Структура таблицы `reservation`
--

CREATE TABLE `reservation` (
  `RecervId` int(10) NOT NULL,
  `GuestId` varchar(20) NOT NULL,
  `RoomNo` varchar(10) NOT NULL,
  `DateIn` date NOT NULL,
  `DateOut` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `reservation`
--

INSERT INTO `reservation` (`RecervId`, `GuestId`, `RoomNo`, `DateIn`, `DateOut`) VALUES
(11, '2', '201', '2022-02-06', '2022-02-10'),
(12, '1', '205', '2022-02-08', '2022-02-18');

-- --------------------------------------------------------

--
-- Структура таблицы `room`
--

CREATE TABLE `room` (
  `RoomId` int(5) NOT NULL,
  `RoomType` int(5) NOT NULL,
  `RoomPhone` varchar(15) NOT NULL,
  `RoomStatus` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `room`
--

INSERT INTO `room` (`RoomId`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES
(201, 1, '201002', 'Busy'),
(202, 1, '202002', 'Free'),
(203, 1, '203002', 'Free'),
(204, 3, '204002', 'Free'),
(205, 2, '205002', 'Busy'),
(206, 2, '206002', 'Free'),
(207, 4, '207002', 'Free'),
(208, 4, '208002', 'Free');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'Admin', 'Admin');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Индексы таблицы `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`GuestId`);

--
-- Индексы таблицы `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`RecervId`),
  ADD KEY `GuestId` (`GuestId`);

--
-- Индексы таблицы `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`RoomId`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `reservation`
--
ALTER TABLE `reservation`
  MODIFY `RecervId` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`GuestId`) REFERENCES `guest` (`GuestId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
