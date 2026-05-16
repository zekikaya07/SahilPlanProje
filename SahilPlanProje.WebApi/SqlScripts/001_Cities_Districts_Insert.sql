/* ========================================================= CITIES ========================================================= */ 
IF NOT EXISTS (SELECT 1 FROM Cities WHERE plate_code = 7) 
	BEGIN INSERT INTO Cities (code, plate_code, name, country_code, is_active, create_date) VALUES ('07', 7, N'Antalya', 'TR', 1, GETDATE()); END 
IF NOT EXISTS (SELECT 1 FROM Cities WHERE plate_code = 15) 
	BEGIN INSERT INTO Cities (code, plate_code, name, country_code, is_active, create_date) VALUES ('15', 15, N'Burdur', 'TR', 1, GETDATE()); END 
IF NOT EXISTS (SELECT 1 FROM Cities WHERE plate_code = 32) 
	BEGIN INSERT INTO Cities (code, plate_code, name, country_code, is_active, create_date) VALUES ('32', 32, N'Isparta', 'TR', 1, GETDATE()); END 
IF NOT EXISTS (SELECT 1 FROM Cities WHERE plate_code = 6) 
	BEGIN INSERT INTO Cities (code, plate_code, name, country_code, is_active, create_date) VALUES ('06', 6, N'Ankara', 'TR', 1, GETDATE()); END
/* =========================================================
   CITY IDS
========================================================= */

DECLARE @AntalyaId INT = (SELECT TOP 1 id FROM Cities WHERE plate_code = 7);
DECLARE @BurdurId  INT = (SELECT TOP 1 id FROM Cities WHERE plate_code = 15);

DECLARE @IspartaId INT = (SELECT TOP 1 id FROM Cities WHERE plate_code = 32);
DECLARE @AnkaraId  INT = (SELECT TOP 1 id FROM Cities WHERE plate_code = 6);

/* =========================================================
   ANTALYA DISTRICTS
========================================================= */

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07001')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07001', 1, N'Akseki', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07002')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07002', 2, N'Aksu', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07003')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07003', 3, N'Alanya', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07004')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07004', 4, N'Demre', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07005')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07005', 5, N'Döþemealtý', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07006')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07006', 6, N'Elmalý', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07007')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07007', 7, N'Finike', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07008')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07008', 8, N'Gazipaþa', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07009')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07009', 9, N'Gündoðmuþ', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07010')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07010', 10, N'Ýbradý', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07011')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07011', 11, N'Kaþ', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07012')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07012', 12, N'Kemer', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07013')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07013', 13, N'Kepez', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07014')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07014', 14, N'Konyaaltý', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07015')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07015', 15, N'Korkuteli', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07016')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07016', 16, N'Kumluca', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07017')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07017', 17, N'Manavgat', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07018')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07018', 18, N'Muratpaþa', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '07019')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AntalyaId, '07019', 19, N'Serik', 0, 1, GETDATE());


/* =========================================================
   BURDUR DISTRICTS
========================================================= */

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15001')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15001', 1, N'Aðlasun', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15002')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15002', 2, N'Altýnyayla', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15003')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15003', 3, N'Bucak', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15004')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15004', 4, N'Burdur Merkez', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15005')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15005', 5, N'Çavdýr', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15006')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15006', 6, N'Çeltikçi', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15007')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15007', 7, N'Gölhisar', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15008')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15008', 8, N'Karamanlý', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15009')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15009', 9, N'Kemer', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15010')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15010', 10, N'Tefenni', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '15011')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@BurdurId, '15011', 11, N'Yeþilova', 0, 1, GETDATE());



/* =========================================================
   ISPARTA
========================================================= */

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32001')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32001', 1, N'Aksu', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32002')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32002', 2, N'Atabey', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32003')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32003', 3, N'Eðirdir', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32004')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32004', 4, N'Gelendost', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32005')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32005', 5, N'Gönen', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32006')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32006', 6, N'Isparta Merkez', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32007')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32007', 7, N'Keçiborlu', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32008')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32008', 8, N'Senirkent', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32009')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32009', 9, N'Sütçüler', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32010')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32010', 10, N'Þarkikaraaðaç', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32011')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32011', 11, N'Uluborlu', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32012')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32012', 12, N'Yalvaç', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '32013')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@IspartaId, '32013', 13, N'Yeniþarbademli', 0, 1, GETDATE());


/* =========================================================
   ANKARA
========================================================= */

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06001')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06001', 1, N'Akyurt', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06002')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06002', 2, N'Altýndað', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06003')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06003', 3, N'Ayaþ', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06004')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06004', 4, N'Bala', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06005')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06005', 5, N'Beypazarý', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06006')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06006', 6, N'Çamlýdere', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06007')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06007', 7, N'Çankaya', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06008')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06008', 8, N'Çubuk', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06009')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06009', 9, N'Elmadað', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06010')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06010', 10, N'Etimesgut', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06011')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06011', 11, N'Evren', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06012')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06012', 12, N'Gölbaþý', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06013')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06013', 13, N'Güdül', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06014')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06014', 14, N'Haymana', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06015')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06015', 15, N'Kahramankazan', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06016')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06016', 16, N'Kalecik', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06017')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06017', 17, N'Keçiören', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06018')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06018', 18, N'Kýzýlcahamam', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06019')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06019', 19, N'Mamak', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06020')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06020', 20, N'Nallýhan', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06021')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06021', 21, N'Polatlý', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06022')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06022', 22, N'Pursaklar', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06023')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06023', 23, N'Sincan', 1, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06024')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06024', 24, N'Þereflikoçhisar', 0, 1, GETDATE());

IF NOT EXISTS (SELECT 1 FROM Districts WHERE code = '06025')
INSERT INTO Districts (city_id, code, district_no, name, is_central, is_active, create_date)
VALUES (@AnkaraId, '06025', 25, N'Yenimahalle', 1, 1, GETDATE());