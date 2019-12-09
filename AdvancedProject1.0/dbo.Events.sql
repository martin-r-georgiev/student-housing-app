CREATE TABLE [dbo].[Events] (
    [Id]          INT         NOT NULL,
    [Name]        NCHAR (50)  NULL,
    [Date]        DATE        NULL,
    [Time]        TIME (7)    NULL,
    [Description] NCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

