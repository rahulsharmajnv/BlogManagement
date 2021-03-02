CREATE TABLE [dbo].[User]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY ,
	UserName varchar(200) NOT NULL , 
	Password varchar(200) NOT NULL ,
	Email varchar(200) NOT NULL
)
