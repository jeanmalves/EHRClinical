CREATE TABLE [dbo].[Data]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TemplateAttributeId] INT NOT NULL, 
    [Value] VARCHAR(MAX) NOT NULL, 
    [PatientRecordId] INT NOT NULL, 
    CONSTRAINT [FK_Data_TemplateAttributes] FOREIGN KEY ([TemplateAttributeId]) REFERENCES [TemplateAttributes]([Id]), 
    CONSTRAINT [FK_Data_PatientRecords] FOREIGN KEY ([PatientRecordId]) REFERENCES [PatientRecords]([Id])
)
