CREATE TABLE [dbo].[FeatureGroup]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FeatureID] INT NOT NULL, 
    [RoleGroupID] INT NOT NULL, 
    CONSTRAINT [FK_FeatureGroup_ToFeature] FOREIGN KEY (FeatureID) REFERENCES Features(Id), 
    CONSTRAINT [FK_FeatureGroup_ToRoleGroup] FOREIGN KEY (RoleGroupID) REFERENCES RolesGroup(Id)
)
