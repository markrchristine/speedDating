CREATE TABLE [dbo].[Event]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY, 
    [Name] varchar(100) NULL,
	RegistrationDeadlineDate datetime,
	EventDate datetime,
	EventStartTime datetime,
	EventEndTime datetime,
	TimeSlotLength int
)
