CREATE TABLE [dbo].[Bikes] (
    [BikeId]    INT            IDENTITY (1, 1) NOT NULL,
    [RegNumber] NVARCHAR (50) NOT NULL,
    [Producer]  NVARCHAR (50) NULL,
    [Model]     NVARCHAR (20) NULL,
    [Colour]    NVARCHAR (20) NULL,
    CONSTRAINT [PK_dbo.Bikes] PRIMARY KEY ([BikeId])
);

INSERT INTO Bikes (RegNumber, Producer, Model, Colour)
VALUES ('101','Trek','TR-25','Black');

INSERT INTO Bikes (RegNumber, Producer, Model, Colour)
VALUES ('256','Sobim-1','SM-1','Blue');

INSERT INTO Bikes (RegNumber, Producer, Model, Colour)
VALUES ('138','Rog','Sprint','Yellow');

INSERT INTO Bikes (RegNumber, Producer, Model, Colour)
VALUES ('505','Trek','TR-A05','Red');

INSERT INTO Bikes (RegNumber, Producer, Model, Colour)
VALUES ('326','Cross','Downhill','Black');

INSERT INTO Bikes (RegNumber, Producer, Model, Colour)
VALUES ('004','Rog','Kid','White');



