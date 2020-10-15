CREATE DATABASE NoteDB;

USE NoteDB;

CREATE TABLE Notes
(
   Id int IDENTITY (1,1) NOT NULL,
   Title nvarchar(50) NULL,
   Description nvarchar(50) NULL,
   DateCreated datetime NULL,
   PRIMARY KEY (Id)
);


--SP INSERT NOTE
CREATE PROCEDURE CreateNote
@title nvarchar(50),
@description nvarchar(200)

AS
INSERT INTO Notes (Title,Description,DateCreated)
VALUES (@title,@description,GETDATE());


--SP UPDATE NOTE
CREATE PROCEDURE EditNote
@id int,
@title nvarchar(50),
@description nvarchar(200)

AS
UPDATE Notes
SET Title = @title, Description = @description
WHERE Id = @id;


--SP DELETE NOTE
CREATE PROCEDURE DeleteNote
@id int

AS
DELETE FROM Notes
WHERE Id = @id;


--SP SELECT ID
CREATE PROCEDURE SelectId
@id int

AS
SELECT *
FROM Notes
WHERE id = @id;
