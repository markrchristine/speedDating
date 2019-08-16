CREATE TABLE [dbo].[EventCorpPref]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY,
	EventCorpId int not null ,
	EventInvestorId int not null,
	PrefOrder int not null,
)
