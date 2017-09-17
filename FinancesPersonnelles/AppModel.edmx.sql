
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/16/2017 14:25:07
-- Generated from EDMX file: C:\Users\Client\documents\visual studio 2017\Projects\FinancesPersonnelles\FinancesPersonnelles\AppModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MainDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Accounts__Accoun__4CA06362]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Accounts] DROP CONSTRAINT [FK__Accounts__Accoun__4CA06362];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accounts];
GO
IF OBJECT_ID(N'[dbo].[AccountType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountType];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [Type] int  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [Balance] float  NULL,
    [AccountId] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(255)  NOT NULL
);
GO

-- Creating table 'AccountTypes'
CREATE TABLE [dbo].[AccountTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Desc] varchar(255)  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Type] nvarchar(200)  NULL,
    [Description] nvarchar(200)  NULL,
    [GroupId] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AccountId] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([AccountId] ASC);
GO

-- Creating primary key on [Id] in table 'AccountTypes'
ALTER TABLE [dbo].[AccountTypes]
ADD CONSTRAINT [PK_AccountTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [GroupId] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([GroupId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AccountId] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK__Accounts__Accoun__4CA06362]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[AccountTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------