
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/01/2019 10:48:56
-- Generated from EDMX file: C:\Users\david\source\repos\BallisticsCalcApp\BallisticsCalcApp\WebsiteDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BallisticsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ShotInformations'
CREATE TABLE [dbo].[ShotInformations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TargetRange] nvarchar(max)  NOT NULL,
    [BallisticCoefficient] nvarchar(max)  NOT NULL,
    [Diameter] nvarchar(max)  NOT NULL,
    [Velocity] nvarchar(max)  NOT NULL,
    [Mass] nvarchar(max)  NOT NULL,
    [FinalVelocity] nvarchar(max)  NOT NULL,
    [ImpactTime] nvarchar(max)  NOT NULL,
    [DensityAltidude] nvarchar(max)  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'ShotDatas'
CREATE TABLE [dbo].[ShotDatas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VelocityX] nvarchar(max)  NOT NULL,
    [VelocityY] nvarchar(max)  NOT NULL,
    [Time] nvarchar(max)  NOT NULL,
    [DistanceX] nvarchar(max)  NOT NULL,
    [DistanceY] nvarchar(max)  NOT NULL,
    [ShotInformation_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ShotInformations'
ALTER TABLE [dbo].[ShotInformations]
ADD CONSTRAINT [PK_ShotInformations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ShotDatas'
ALTER TABLE [dbo].[ShotDatas]
ADD CONSTRAINT [PK_ShotDatas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_Id] in table 'ShotInformations'
ALTER TABLE [dbo].[ShotInformations]
ADD CONSTRAINT [FK_UserShotInformation]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserShotInformation'
CREATE INDEX [IX_FK_UserShotInformation]
ON [dbo].[ShotInformations]
    ([User_Id]);
GO

-- Creating foreign key on [ShotInformation_Id] in table 'ShotDatas'
ALTER TABLE [dbo].[ShotDatas]
ADD CONSTRAINT [FK_ShotInformationShotData]
    FOREIGN KEY ([ShotInformation_Id])
    REFERENCES [dbo].[ShotInformations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ShotInformationShotData'
CREATE INDEX [IX_FK_ShotInformationShotData]
ON [dbo].[ShotDatas]
    ([ShotInformation_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------