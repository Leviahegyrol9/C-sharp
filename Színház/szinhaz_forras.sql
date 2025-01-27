CREATE TABLE `eloadas` (
  `eloadasAZ` int(11) NOT NULL,
  `szerzo` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `cim` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `rendezo` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `hol` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `mufaj` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `bemutat` date NOT NULL,
  `gyerekeknek` binary(1) NOT NULL,
  `szereplok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `eloadas` (`eloadasAZ`, `szerzo`, `cim`, `rendezo`, `hol`, `mufaj`, `bemutat`, `gyerekeknek`, `szereplok`) VALUES

(1, 'Bartók', 'A Csodálatos mandarin', 'Juronics Tamás', 'Nagyszínház', 'táncjáték', '2009-02-27', 0x30, 10),
(2, 'Hoffmann – Kapecz – Gothár – Selmeczi', 'A diótörő', 'Hargitai Iván', 'Nagyszínház', 'zenés családi mesejáték', '2008-12-19', 0x31, 6),
(3, 'Gilbert – Sullivan', 'A kalózkaland', 'Almási-Tóth András', 'Nagyszínház', 'operett', '2009-03-20', 0x31, 13),
(4, 'Sztravinszkij – Ramuz', 'A katona története', 'Juronics Tamás', 'Nagyszínház', 'balett-oratórium', '2008-11-28', 0x31, 10),
(5, 'Goldoni – Mohácsi', 'A kávéház', 'Rusznyák Gábor', 'Nagyszínház', 'vígjáték', '2008-09-26', 0x30, 12),
(6, 'Lendvay', 'A mennyei város', 'Juronics Tamás', 'Nagyszínház', 'balett-oratórium', '2008-11-28', 0x30, 8),
(7, '', 'A tudattalan', 'Juronics Tamás', 'Kiszínház', 'táncjáték', '2008-10-24', 0x30, 9),
(8, 'Cilea', 'Adriana Lecouvreur', 'Michael Sturm', 'Nagyszínház', 'opera', '2008-11-03', 0x30, 11),
(9, 'Lőrinczy', 'Balta a fejbe', 'Tasnádi Csaba', 'Kiszínház', 'hisztériumjáték', '2009-03-20', 0x30, 10),
(10, '', 'Csipkerózsika', 'Juronics Tamás', 'Kiszínház', 'táncjáték', '2009-02-20', 0x31, 7),
(11, 'Berlioz', 'Faust elkárhozása', 'Juronics Tamás', 'Nagyszínház', 'opera', '2009-04-24', 0x30, 13),
(12, 'Mozart', 'Figaro házassága', 'Anger Ferenc', 'Kiszínház', 'vígopera', '2009-01-16', 0x30, 11),
(13, 'Victor Hugo', 'Királyasszony lovagja', 'Znamenák István', 'Nagyszínház', 'színmű', '2009-01-30', 0x31, 6),
(14, 'Machiavelli', 'Mandragóra', 'Szabó Máté', 'Kiszínház', 'vígjáték', '2008-10-03', 0x30, 14),
(15, 'Ayckburn', 'Mr. A', 'Quintus Konrád', 'Kiszínház', 'mesejáték', '2009-02-06', 0x31, 11),
(16, 'Verdi', 'Otello', 'Anger Ferenc', 'Nagyszínház', 'opera', '2009-03-28', 0x30, 9),
(17, 'Miller', 'Pillantás a hídról', 'Hargitai Iván', 'Kiszínház', 'dráma', '2008-10-29', 0x30, 6),
(18, 'Stephens', 'Pornográfia', 'Bodolay Géza', 'Kiszínház', 'színmű', '2008-11-14', 0x30, 8),
(19, 'Puccini', 'Tosca', 'Angyal Mária', 'Nagyszínház', 'opera', '2008-10-03', 0x30, 6),
(20, 'Verdi', 'Trubadúr', 'Harangi Mária', 'Nagyszínház', 'opera', '2008-12-12', 0x30, 9);

ALTER TABLE `eloadas`
  ADD PRIMARY KEY (`eloadasAZ`);
ALTER TABLE `eloadas`
  MODIFY `eloadasAZ` int(11) NOT NULL AUTO_INCREMENT;