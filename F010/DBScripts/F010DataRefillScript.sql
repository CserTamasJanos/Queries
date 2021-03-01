USE FictiveCompany


--SELECT * FROM ProductCategory
--SELECT * FROM Product
--SELECT * FROM Customer
--SELECT * FROM CustomerOrder
--SELECT * FROM OrderedProduct


DELETE FROM OrderedProduct
DELETE FROM CustomerOrder
DELETE FROM Customer
DELETE FROM Product 
DELETE FROM ProductCategory


SET IDENTITY_INSERT ProductCategory ON

INSERT INTO ProductCategory(ProductCategoryID,ProductCategoryName)
VALUES(1,'Elektromos kieg�sz�t�k')

INSERT INTO ProductCategory(ProductCategoryID,ProductCategoryName)
VALUES(2,'Kisg�p alkatr�szek')

INSERT INTO ProductCategory(ProductCategoryID,ProductCategoryName)
VALUES(3,'Irodaszerek')

INSERT INTO ProductCategory(ProductCategoryID,ProductCategoryName)
VALUES(4,'J�t�kok')

SET IDENTITY_INSERT ProductCategory OFF


SET IDENTITY_INSERT Product ON

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (1, 'Egyp�lus� kapcsol�', 'Egy fogyaszt� (pl.l�mpatest) egy helyr�l t�rt�n� kapcsol�s�ra alkalmas.
Elhelyez�se: belt�r, kiv�ve vizes, nedves helyis�gek.', 550, 12, 1, 1)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (2,'Csiszol� korong', 'A lamell�s csiszol�t�ny�r v�szonb�l k�sz�lt csiszol�lamell�i legyez�szer�, sugaras elrendez�d�s�nek k�sz�nhet�en a szokv�nyos szersz�mok csiszol�si teljes�tm�ny�nek t�bbsz�r�s�t �ri el. A lamell�s csiszol�t�ny�r egyenes kivitel�.
Egyenletes csiszolat a szersz�m teljes elhaszn�l�d�s�ig. Nagy lev�laszt�si teljes�tm�ny. Aluminium-oxid (korund) szemcs�j�.', 200, 1, 2, 1)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (3,'Hosszabb�t�', 'Sz�ne feh�r, v�d�f�ldel�s, vezet�k t�pusa: H05VV-F 3G 1,0 mm2, vezet�k hossza: 20 m, n�vleges fesz�lts�g: 250 V~, n�vleges �ramer�ss�g: 10 A, n�vleges teljes�tm�ny: 2300 W, aljzatok sz�ma: 1 db, IP v�delem: IP20.', 1900, 6, 1, 1)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (4,'T�z�g�p', 'M�anyag test�, f�mszerkezet� f�z�g�p, t�z� �s f�z� funkci�val - haszn�lhat� kapocsm�ret: No. 10. - f�z�si m�lys�g: 42 mm - egyszerre �sszef�zhet� lapok sz�ma: 10 lap', 440, 12, 3, 1)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (5,'F�ny�r�k�s', 'Alkalmazott g�p t�pus(ok): AL-KO COMFORT 420 E/B BIO-COMBI (112362), (112363), ut�ngy�rtott (sz�rmaz�si hely: Magyarorsz�g), F�ny�r�k�s hossza (mm): 400, K�z�ps� furat �tm�r�je (mm): 19,7, Sz�ls� furatok �tm�r�je (mm): 8,2x12, Sz�ls� furatok t�vols�ga (mm): 65, F�ny�r�k�s sz�less�ge (mm): 55.', 1490, 1,2, 1)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (6, 'K�rz�','Maped K�rz� k�szlet, r�gz�thet� l�bakkal, 7 darabos', 1500, 12, 3, 0)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (7, 'Slime labda','A Slime labda egy puha, ny�lk�s anyaggal t�lt�tt �s h�l�ba csomagolt goly�, amit ha �sszenyomsz, ki fog t�remkedni a h�l� r�sein. ', 200, 1, 4, 0)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (8, 'F�rd�szobai csempekr�ta','A F�rd�szobai csempekr�ta 8 darabos k�szlet sz�nes kr�t�kat tartalmaz, amikkel a csemp�re, �s a k�d fel�let�re tudsz rajzolni. A kr�t�k �l�nk sz�n�ek, �s v�zzel nyom n�lk�l le lehet mosni a fel�letr�l.  ', 1800, 6, 4, 1)

INSERT INTO Product (ProductID,ProductName,ProductDescription,ProductListPrice,WarrantyPeriod,ProductCategoryID,ProductStatus)
VALUES (9, 'K�rz�','Rotring, kiv�l� min�s�g� iskolai k�rz�, A szett k�rz� hegyet is tartalmaz, M�anyag t�rol�dobozban', 2000, 12, 3, 0)

SET IDENTITY_INSERT Product OFF


SET IDENTITY_INSERT Customer ON

INSERT INTO Customer (CustomerID,CustomerName,CustomerLocation,CustomerEmailAddress,CustomerGender,CustomerBirthDate)
VALUES (1,'Szendrei K�lm�n', 'Budapest, Nap utca 2,', 'kalman.szendrei@gmail.com',1,'1995-06-12')

INSERT INTO Customer (CustomerID,CustomerName,CustomerLocation,CustomerEmailAddress,CustomerGender,CustomerBirthDate)
VALUES (2,'Endr�di Albert', 'Budapest, Felh�v�zi utca 9,', 'endrodi.albert@freemail.hu',1,'1977-11-01')

INSERT INTO Customer (CustomerID,CustomerName,CustomerLocation,CustomerEmailAddress,CustomerGender,CustomerBirthDate)
VALUES (3,'Horv�th Ibolya', 'Balatonm�riaf�rd�, R�k�czi utca 138,', 'ibolykaH@citromail.hu',2,'1999-03-03')

INSERT INTO Customer (CustomerID,CustomerName,CustomerLocation,CustomerEmailAddress,CustomerGender,CustomerBirthDate)
VALUES (4,'Szeles K�roly', 'Sz�kesfeh�rv�r, Budai �t 192 ,', 'szkaroly@gmail.com',1,'1962-05-22')

INSERT INTO Customer (CustomerID,CustomerName,CustomerLocation,CustomerEmailAddress,CustomerGender,CustomerBirthDate)
VALUES (5,'Kertes Endre', 'Hajdudorog, Tokaji �t 31', 'EndreKertes2001@gmail.com',1,'2001-01-09')

INSERT INTO Customer (CustomerID,CustomerName,CustomerLocation,CustomerEmailAddress,CustomerGender,CustomerBirthDate)
VALUES (6,'Kertes Endre', 'Sz�kesfeh�rv�r, Pesti �t 198', 'EndreKertes1979@gmail.com',1,'1979-06-17')

INSERT INTO Customer (CustomerID,CustomerName,CustomerLocation,CustomerEmailAddress,CustomerGender,CustomerBirthDate)
VALUES (7,'Kenderesi S�ra', 'Marcali, R�zs utca 56,', 'sarikavilagra@gmail.com',2,'1988-08-11')

SET IDENTITY_INSERT Customer OFF


SET IDENTITY_INSERT CustomerOrder ON

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (1,'2017-04-20 13:25:45', 1, 1, 5)

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (2,'2018-04-22 09:30:01', 1, 2, 5)

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (3,'2018-05-22 09:25:01', 2, 2, 5)

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (4,'2019-06-30 11:10:10', 3, 1, 3)

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (5,'2019-07-02 23:01:55', 4, 2, 2)

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (6,'2019-07-03 10:44:12', 5, 1, 1)

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (7,'2019-07-03 15:44:12', 2, 2, 1)

INSERT INTO CustomerOrder (CustomerOrderID,OrderDateTime,CustomerID,OrderMode,OrderStatus)
VALUES (8,'2019-07-26 10:10:10', 6, 2, 0)

SET IDENTITY_INSERT CustomerOrder OFF


SET IDENTITY_INSERT OrderedProduct ON

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (1,1,1,1,900)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (2,2,3,1,2600)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (3,3,2,3,300)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (4,3,3,1,2600)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (5,4,3,1,2600)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (6,4,4,2,760)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (7,4,5,1,3100)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (8,5,1,4,900)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (9,5,3,1,2600)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (10,6,2,2,300)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (11,7,3,1,2600)

INSERT INTO OrderedProduct (OrderedProductID,CustomerOrderID,ProductID,OrderedAmount,UnitPrice)
VALUES (12,8,8,1,2690)

SET IDENTITY_INSERT OrderedProduct OFF