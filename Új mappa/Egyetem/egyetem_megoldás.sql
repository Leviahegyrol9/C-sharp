-- 1.
SELECT AVG(feleviAtlag) AS feleviAtlag, AVG(evvegiAtlag) AS evvegiAtlag
FROM hallgatok;

-- 2.
SELECT DISTINCT szaktipus
FROM hallgatok;

-- 3.
SELECT tanuloNev, szulido
FROM hallgatok
ORDER BY szulido DESC LIMIT 10;

-- 4.
SELECT tanuloNev, szaktipus, evvegiAtlag
FROM hallgatok 
ORDER BY evvegiAtlag DESC, tanuloNev;

-- 5.
SELECT tanuloNev, evvegiAtlag - feleviAtlag AS javitas_rontas, 
(evvegiAtlag / feleviAtlag - 1) *100 AS javitas_rontas_szazalek
FROM hallgatok 
ORDER BY tanuloNev;

-- 6.
SELECT tanuloNev, feleviAtlag
FROM hallgatok 
ORDER BY feleviAtlag LIMIT 20;

-- 7.
SELECT MAX(feleviAtlag) - MIN(feleviAtlag) AS feleviIngadozas, 
MAX(evvegiAtlag) - MIN(evvegiAtlag) AS evvegiIngadozas
FROM hallgatok;

-- 8.
SELECT COUNT(DISTINCT szaktipus)
FROM hallgatok;

-- 9.
SELECT COUNT(*) AS hallgatok_szama
FROM hallgatok;

-- 10.
SELECT tanuloNev, feleviAtlag, feleviAtlag * 1.15 AS tervezettEvvegiAtlag
FROM hallgatok;

-- 11.
SELECT tanuloNev, evvegiAtlag
FROM hallgatok
WHERE evvegiAtlag > (SELECT AVG(evvegiAtlag) FROM hallgatok) + 1
ORDER BY evvegiAtlag DESC;





