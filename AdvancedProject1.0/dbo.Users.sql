﻿CREATE TABLE [dbo].[Users] (
    [Id]         INT           NOT NULL IDENTITY,
    [Username]   VARCHAR (50)  NOT NULL,
    [Password]   VARCHAR (50)  NOT NULL,
    [First Name] VARCHAR (50)  NOT NULL,
    [Last Name]  VARCHAR (50)  NOT NULL,
    [House Nr.]  INT           NOT NULL,
    [Student ID] VARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

