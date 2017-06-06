CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(150) NOT NULL, 
    [Birth] DATE NOT NULL, 
    [sex] SMALLINT NOT NULL, 
    [EHR] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Patients_ToUsers] FOREIGN KEY (UserId) REFERENCES [Users](Id)
)
