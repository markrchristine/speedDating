CREATE TABLE [dbo].[EventInvestorPref]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY,
	EventInvestorId int not null,
	EventCorpId int not null,
	PrefOrder int not null,

)
