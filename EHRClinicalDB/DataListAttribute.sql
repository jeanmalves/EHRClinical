CREATE TABLE [dbo].[DataListAttribute]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Key] INT NOT NULL, 
    [Value] VARCHAR(50) NOT NULL,
	[Term] VARCHAR(20) NULL, 
    [AttributeId] INT NOT NULL,  
    CONSTRAINT [FK_DataListAttribute_ToTemplateAttributes] FOREIGN KEY (AttributeId) REFERENCES [TemplateAttributes](Id)
)
