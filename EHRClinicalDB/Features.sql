CREATE TABLE [dbo].[Features]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(150) NOT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [DisplayMenu] SMALLINT NULL DEFAULT 0,
	[TemplateId] INT NOT NULL, 
     
    [CreatedAt] DATETIME NOT NULL, 
    [UpdatedAt] DATETIME NULL, 
    [UserId] INT NOT NULL, 
    [status] SMALLINT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_Features_ToOperationalsTemplates] FOREIGN KEY (TemplateId) REFERENCES OperationalsTemplates(Id), 
    CONSTRAINT [FK_Features_ToUsers] FOREIGN KEY (UserId) REFERENCES [Users](Id)
)
