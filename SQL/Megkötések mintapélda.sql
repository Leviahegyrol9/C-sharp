CREATE DATABASE iskola CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE iskola;

CREATE TABLE diak(
    diakAZ int PRIMARY KEY,
    nev varchar(100) NOT null,
    email varchar(100) NOT null UNIQUE,
    szuldatum date NOT null,
    testverszam tinyint,
    INDEX(nev),
    INDEX szuldatum_idx(szuldatum)
);

-- A Not null azt jelenti, hogy a mező nem lehet üres.
-- A UNIQUE azt jelenti, hogy a mező egyedi értékeket tartalmazhat, nem lehet két egyforma érték benne.
-- Az index megadása kétféleképpen történt. Az első esetben az indexnév a mezőnévvel megegyezik, a második esetben mi adtunk indexnevet (szuldatum_idx).

DROP INDEX szuldatum_idx ON diak;
-- index törlésének egyik módja

CREATE UNIQUE INDEX email_idx ON diak(email);
-- egyedi index létrehozásának egyik módja
-- mivel már létezett az email mezőre egy index, jelzi, hogy ez duplikált index, de végrehajtja

ALTER TABLE diak DROP INDEX email;
-- index törlésének másik módja - érdemes törölni, hogy egyféle index legyen

ALTER TABLE diak DROP diakAZ;
-- mező törlése

ALTER TABLE diak ADD diakID int AUTO_INCREMENT PRIMARY KEY FIRST;
-- új elsődleges kulcs mező létrehozása automatikus sorszámként

INSERT INTO `diak`(`nev`, `email`, `szuldatum`, `testverszam`) VALUES 
('Varga Zsolt','varga.zsolt@vasvari.org','2007-05-26',0),
('Hajós Álmos','almoshajos@vasvari.org','2007-02-10',3),
('Tolnai Renáta','tolnairencsi@gmail.com','2006-12-11',1);
-- tábla feltöltése

INSERT INTO `diak`(`nev`, `email`, `szuldatum`, `testverszam`) VALUES 
('Karika Árpád','varga.zsolt@vasvari.org','2008-04-13',2);
-- ez a parancs nem fut le, mert az email cím mezőben duplikált érték van

INSERT INTO `diak`(`nev`, `email`, `szuldatum`, `testverszam`) VALUES 
('Karika Árpád','karikaarpika@vasvari.org','2008-04-13',2);
-- javított rekordbeszúrás

ALTER TABLE diak ADD osztaly varchar(6);
-- a diak táblához új mező hozzáadása

UPDATE diak SET osztaly = "9.a";
-- az új mező feltöltése azonos értékekkel

CREATE TABLE osztalyok(
	osztalyAZ varchar(6) PRIMARY KEY,
    osztalyfonok varchar(40) NOT null,
    osztalyterem tinyint UNIQUE
);
-- Az osztalyok tábla létrehozása, amelyet a diak táblához fogunk majd kapcsolni

INSERT INTO `osztalyok`(`osztalyAZ`, `osztalyfonok`, `osztalyterem`) VALUES 
('9.a','Vass Mária',30),
('9.b',null,14),
('9.c','Kovácsné Kertész Etelka',32)

-- Az osztalyok tábla feltöltése - mivel a név mező nem lehett null, azért figyelmeztetést kapunk, de a parancs lefut.
-- Üzenet: "Warning: #1048 A(z) 'osztalyfonok' oszlop erteke nem lehet nulla"

ALTER TABLE diak ADD FOREIGN KEY (osztaly) REFERENCES osztalyok(osztalyAZ);
-- Idegen kulcs létrehozása a diak tábla osztaly mezőjére

-- A kapcsolathoz alapvetően a szigorú szabályrendszer kapcsolódik (RESTRICT)
-- Ebben az esetben az elsődleges kulcsot nem lehet törölni vagy módosítani, ha van kapcsolódó rekord a másik táblában, ill. nem lehet olyan tanulót felvenni a diak táblába, akinek nem létezik az osztálya a másik táblában.

DELETE FROM osztalyok WHERE osztalyAZ = "9.a";
UPDATE osztalyok SET osztalyAZ = "9.m" WHERE osztalyAZ = "9.a";
-- Egyik parancs sem fut le, mert a 9.a osztályban vannak diákok
-- Hibaüzenet: "Cannot delete or update a parent row: a foreign key constraint fails (`iskola`.`diak`, CONSTRAINT `diak_ibfk_1` FOREIGN KEY (`osztaly`) REFERENCES `osztalyok` (`osztalyAZ`))"

INSERT INTO `diak`(`nev`, `email`, `szuldatum`, `testverszam`, `osztaly`) VALUES
('Hajas Árpád','arpadhaj@gmail.com','2007-03-10',2,'10.a');
-- Ez a parancs sem fut le, mert az osztalyok táblában nincs felvéve 10.a osztály, nem tudja mihez kapcsolni a rekordot.
-- Hibaüzenet: "Cannot add or update a child row: a foreign key constraint fails (`iskola`.`diak`, CONSTRAINT `diak_ibfk_1` FOREIGN KEY (`osztaly`) REFERENCES `osztalyok` (`osztalyAZ`))"

-- Ha a kapcsolatnál az ON DELETE / ON UPDATE CASCADE-ra van átállítva, akkor lehetséges a fenti törlés és módosítás

UPDATE osztalyok SET osztalyAZ = "9.m" WHERE osztalyAZ = "9.a";
-- A 9.a osztály mostantól 9.m lesz és a diak táblában minden 9.a-diáknál a 9.m osztály fog látszódni.

DELETE FROM osztalyok WHERE osztalyAZ = "9.m";
-- A 9.m osztályt kitörli és ezzel együtt az összes olyan diákot is a diak táblából, aki ebbe az osztályba jár.

