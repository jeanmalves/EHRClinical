CREATE TABLE [dbo].[Doctors]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(150) NOT NULL, 
	[Birth] DATE NOT NULL,
    [Sex] SMALLINT NOT NULL, 
    [MedicId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Doctors_ToUsers] FOREIGN KEY (UserId) REFERENCES [Users](Id) 
    
)
