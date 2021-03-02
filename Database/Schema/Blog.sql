CREATE TABLE [dbo].[Blog]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , 
    [Name] VARCHAR(500) NULL, 
    [Content] VARCHAR(5000) NULL, 
    [CreatedDate] DATETIME NULL, 
    [CreatedBy] INT NULL, 
    [status] INT NULL
)
