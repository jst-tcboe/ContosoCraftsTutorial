CREATE DATABASE IF NOT EXISTS ContosoCrafts;

USE ContosoCrafts;

DROP TABLE IF EXISTS Maker, Item, Rating;

CREATE TABLE Maker
(
    MakerId INT NOT NULL AUTO_INCREMENT,
    MakerHandle TEXT NOT NULL,
    PRIMARY KEY (MakerId)
);
GO

CREATE TABLE Item
(
    ItemId INT NOT NULL AUTO_INCREMENT,
    ImageUrl TEXT NOT NULL,
    ItemUrl TEXT NOT NULL,
    Title TEXT NOT NULL,
    Description TEXT NOT NULL,
    MakerId INT NOT NULL,
    ItemShortName TEXT NOT NULL,
    PRIMARY KEY (ItemId),
    FOREIGN KEY (MakerId) REFERENCES Maker(MakerId)
);
GO

CREATE TABLE Rating
(
    RatingId INT NOT NULL AUTO_INCREMENT,
    Rating INT NOT NULL,
    ItemId INT NOT NULL,
    PRIMARY KEY (RatingId),
    FOREIGN KEY (ItemId) REFERENCES Item(ItemId)
);
GO