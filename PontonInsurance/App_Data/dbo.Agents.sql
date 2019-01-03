CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Certifications] NVARCHAR(255) NULL, 
    [Agency] NVARCHAR(255) NULL, 
    [Address] NVARCHAR(255) NULL, 
    [Suite] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(255) NULL, 
    [State] NVARCHAR(50) NULL, 
    [Zip] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Licenses] NVARCHAR(255) NOT NULL
)
