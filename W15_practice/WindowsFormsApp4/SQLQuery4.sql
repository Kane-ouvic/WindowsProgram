﻿INSERT INTO 學號_宿舍(學號,宿舍)VALUES('F12345678', N'不存在的宿舍');
INSERT INTO 學號_宿舍(學號,宿舍)VALUES('F74091247', N'勝利');
INSERT INTO 姓名_學號_系級(姓名,學號,系級)VALUES(N'不存在的人','F12345678',N'資訊777');
INSERT INTO 姓名_學號_系級(姓名,學號,系級)VALUES(N'歐長諺','F74091247',N'資訊113');
INSERT INTO 姓名_期中考成績(姓名,期中考成績)VALUES(N'不存在的人',100);
INSERT INTO 姓名_期中考成績(姓名,期中考成績)VALUES(N'歐長諺',69);

SELECT * FROM 學號_宿舍
SELECT * FROM 姓名_學號_系級
SELECT * FROM 姓名_期中考成績


/*
UPDATE 學號_宿舍 SET 宿舍='光復' WHERE 學號='F12345678'
SELECT * FROM 姓名_學號_系級
SELECT * FROM 姓名_期中考成績
//

DELETE FROM 學號_宿舍 WHERE 姓名='不存在'
*/