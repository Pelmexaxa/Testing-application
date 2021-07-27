CREATE TABLE [dbo].[Salesman] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50) NULL,
    [LastName]  NVARCHAR (50) NULL,
    [DataEnjoy] DATE          NULL,
    [Boss]      NVARCHAR (50) NULL,
    [IdentificationID] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);