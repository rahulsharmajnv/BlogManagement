/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

delete from dbo.[user]
delete from dbo.[blog]

INSERT INTO [dbo].[User]
(Id,UserName,Password,Email) 
VALUES
(1,'Ajay','asdfghj','dfgh')


Insert into [dbo].[Blog] (Name, Content, CreatedDate, CreatedBy,Status)
values ( 'blog1' , 'content' , GETUTCDATE() , 1 , 1)

Insert into [dbo].[Blog] (Name, Content, CreatedDate, CreatedBy,Status)
values ( 'blog1' , 'content' , GETUTCDATE() , 1 , 1)
GO
