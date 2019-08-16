CREATE TABLE [dbo].[Investor]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY, 
    [FirstName] varchar(100) NOT NULL, 
    [LastName] VARCHAR(100) NOT NULL, 
    [Company] VARCHAR(100) NOT NULL
)
