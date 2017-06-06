CREATE TABLE [dbo].[PatientRecords]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OpTempId] INT NOT NULL,
	[PatientId] INT NOT NULL,
	[DoctorId] INT NOT NULL,
    [CreatedAt] DATETIME NOT NULL, 
     
    CONSTRAINT [FK_PatientRecords_OperationalsTemplates] FOREIGN KEY (OpTempId) REFERENCES [OperationalsTemplates]([Id]), 
    CONSTRAINT [FK_PatientRecords_Patients] FOREIGN KEY ([PatientId]) REFERENCES [Patients]([Id]), 
    CONSTRAINT [FK_PatientRecords_Doctors] FOREIGN KEY ([DoctorId]) REFERENCES [Doctors]([Id]) 
    
)
