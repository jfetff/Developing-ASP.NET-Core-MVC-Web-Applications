IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    CREATE TABLE [Aquariums] (
        [AquariumId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [Number] int NOT NULL,
        [Open] bit NOT NULL,
        CONSTRAINT [PK_Aquariums] PRIMARY KEY ([AquariumId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    CREATE TABLE [fishes] (
        [FishId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [ScientificName] nvarchar(max) NULL,
        [ImageName] nvarchar(max) NULL,
        [PhotoFile] varbinary(max) NULL,
        [ImageMimeType] nvarchar(max) NULL,
        [AquariumId] int NOT NULL,
        CONSTRAINT [PK_fishes] PRIMARY KEY ([FishId]),
        CONSTRAINT [FK_fishes_Aquariums_AquariumId] FOREIGN KEY ([AquariumId]) REFERENCES [Aquariums] ([AquariumId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AquariumId', N'Address', N'Name', N'Number', N'Open') AND [object_id] = OBJECT_ID(N'[Aquariums]'))
        SET IDENTITY_INSERT [Aquariums] ON;
    INSERT INTO [Aquariums] ([AquariumId], [Address], [Name], [Number], [Open])
    VALUES (1, N'4121  Broadway Street', N'Fish Aquarium', -337, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AquariumId', N'Address', N'Name', N'Number', N'Open') AND [object_id] = OBJECT_ID(N'[Aquariums]'))
        SET IDENTITY_INSERT [Aquariums] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AquariumId', N'Address', N'Name', N'Number', N'Open') AND [object_id] = OBJECT_ID(N'[Aquariums]'))
        SET IDENTITY_INSERT [Aquariums] ON;
    INSERT INTO [Aquariums] ([AquariumId], [Address], [Name], [Number], [Open])
    VALUES (2, N'3219  Central Avenue', N'Ocean Aquarium', -1298, 0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AquariumId', N'Address', N'Name', N'Number', N'Open') AND [object_id] = OBJECT_ID(N'[Aquariums]'))
        SET IDENTITY_INSERT [Aquariums] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AquariumId', N'Address', N'Name', N'Number', N'Open') AND [object_id] = OBJECT_ID(N'[Aquariums]'))
        SET IDENTITY_INSERT [Aquariums] ON;
    INSERT INTO [Aquariums] ([AquariumId], [Address], [Name], [Number], [Open])
    VALUES (3, N'128  Stewart Street', N'Best Aquarium', -6695, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AquariumId', N'Address', N'Name', N'Number', N'Open') AND [object_id] = OBJECT_ID(N'[Aquariums]'))
        SET IDENTITY_INSERT [Aquariums] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FishId', N'AquariumId', N'ImageMimeType', N'ImageName', N'Name', N'PhotoFile', N'ScientificName') AND [object_id] = OBJECT_ID(N'[fishes]'))
        SET IDENTITY_INSERT [fishes] ON;
    INSERT INTO [fishes] ([FishId], [AquariumId], [ImageMimeType], [ImageName], [Name], [PhotoFile], [ScientificName])
    VALUES (1, 1, N'image/jpeg', N'goldfish.jpg', N'Goldfish', NULL, N'Carassius auratus');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FishId', N'AquariumId', N'ImageMimeType', N'ImageName', N'Name', N'PhotoFile', N'ScientificName') AND [object_id] = OBJECT_ID(N'[fishes]'))
        SET IDENTITY_INSERT [fishes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FishId', N'AquariumId', N'ImageMimeType', N'ImageName', N'Name', N'PhotoFile', N'ScientificName') AND [object_id] = OBJECT_ID(N'[fishes]'))
        SET IDENTITY_INSERT [fishes] ON;
    INSERT INTO [fishes] ([FishId], [AquariumId], [ImageMimeType], [ImageName], [Name], [PhotoFile], [ScientificName])
    VALUES (2, 1, N'image/jpeg', N'starfish.jpg', N'Starfish', NULL, N'Asteroidea');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FishId', N'AquariumId', N'ImageMimeType', N'ImageName', N'Name', N'PhotoFile', N'ScientificName') AND [object_id] = OBJECT_ID(N'[fishes]'))
        SET IDENTITY_INSERT [fishes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FishId', N'AquariumId', N'ImageMimeType', N'ImageName', N'Name', N'PhotoFile', N'ScientificName') AND [object_id] = OBJECT_ID(N'[fishes]'))
        SET IDENTITY_INSERT [fishes] ON;
    INSERT INTO [fishes] ([FishId], [AquariumId], [ImageMimeType], [ImageName], [Name], [PhotoFile], [ScientificName])
    VALUES (3, 1, N'image/jpeg', N'clownfish.jpg', N'Clownfish', NULL, N'Amphiprion ocellaris');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FishId', N'AquariumId', N'ImageMimeType', N'ImageName', N'Name', N'PhotoFile', N'ScientificName') AND [object_id] = OBJECT_ID(N'[fishes]'))
        SET IDENTITY_INSERT [fishes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    CREATE INDEX [IX_fishes_AquariumId] ON [fishes] ([AquariumId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218160024_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201218160024_InitialCreate', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218170639_AddFishCommonName')
BEGIN
    ALTER TABLE [fishes] ADD [CommonName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201218170639_AddFishCommonName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201218170639_AddFishCommonName', N'2.1.14-servicing-32113');
END;

GO

