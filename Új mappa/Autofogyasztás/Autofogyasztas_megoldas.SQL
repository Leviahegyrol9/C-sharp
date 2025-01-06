1. Készítsen "auto" néven egy adatbázist, amely utf8 kódolású és a magyar ékezetes karaktereket használja!

CREATE DATABASE auto CHARACTER SET utf8 COLLATE utf8_hungarian_ci;

2. Importálja az "autofogyasztas" táblát az adatokkal együtt!
(A táblázat néhány autótípus három fogyasztási adatát tartalmazza liter/100 km mértékegységben. A kombinált fogyasztást (átlagfogyasztás), a városban és az országúton mért fogyasztási adatokat.)

3. Készítsen lekérdezést, amely megszámolja, hány autó van a táblában!

SELECT COUNT(*) AS autok_szama
FROM autofogyasztas;

4. Készítsen lekérdezést, amely az első 5 legjobb fogyasztású autót listázza az országúti fogyasztást figyelembe véve! A listában jelenítse meg az autó típusát és az országúti fogyasztását!

SELECT autotipus, orszaguti_fogyasztas
FROM autofogyasztas
ORDER BY orszaguti_fogyasztas LIMIT 5;


5. Az összes autó városi fogyasztását figyelembe véve, mennyi az átlagos fogyasztás 100 km-en?

SELECT AVG(varosi_fogyasztas) AS atlagfogyasztas_varosban
FROM autofogyasztas;

6. Listázza az autók típusát, kombinált fogyasztását 100 km-en és azt, hogy egy 450 km-es út megtétele mennyibe kerülne, ha a benzin ára 350 Ft/liter. A számításhoz a kombinált fogyasztás adatát használja! A végeredményt rendezze fizetett összeg szerint!

SELECT autotipus, kombinalt_fogyasztas, kombinalt_fogyasztas * 350 * 4.5 AS benzin_ar
FROM autofogyasztas
ORDER BY benzin_ar;

7. Adja meg minden autónál, hogy az országúti fogyasztás hány százaléka a városi fogyasztásnak! A listában az autó típusa és a kiszámolt százalékérték szerepeljen autótípus szerinti ábécé sorrendben!

SELECT autotipus, orszaguti_fogyasztas / varosi_fogyasztas * 100 AS szazalek
FROM autofogyasztas
ORDER BY autotipus;

8. Adja meg milyen két határérték között ingadozik az autók városi fogyasztása!

SELECT MIN(varosi_fogyasztas) AS min_fogyasztas, MAX(varosi_fogyasztas) AS max_fogyasztas
FROM autofogyasztas;

