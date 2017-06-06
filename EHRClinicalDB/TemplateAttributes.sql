CREATE TABLE [dbo].[TemplateAttributes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Attribute] VARCHAR(MAX) NOT NULL, 
    [PathAttribute] VARCHAR(MAX) NOT NULL, 
	[Type] VARCHAR(50) NOT NULL,
    [OpTempId] INT NOT NULL, 
    CONSTRAINT [FK_TemplateAttributes_OperationalsTemplates] FOREIGN KEY ([OpTempId]) REFERENCES [OperationalsTemplates]([Id])
    
)
