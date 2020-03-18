IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

create proc test as select * from People

GO

CREATE TABLE [People] (
    [PersonId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    CONSTRAINT [PK_People] PRIMARY KEY ([PersonId])
);

GO

CREATE TABLE [Contacts] (
    [ContactId] int NOT NULL IDENTITY,
    [AddressLine] nvarchar(max) NULL,
    [PersonId] int NOT NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY ([ContactId]),
    CONSTRAINT [FK_Contacts_People_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [People] ([PersonId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Contacts_PersonId] ON [Contacts] ([PersonId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200211123928_Init', N'3.1.1');

GO

CREATE TABLE [Cars] (
    [CarId] int NOT NULL IDENTITY,
    [CarName] nvarchar(max) NULL,
    [PersonId] int NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY ([CarId]),
    CONSTRAINT [FK_Cars_People_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [People] ([PersonId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Cars_PersonId] ON [Cars] ([PersonId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200211132636_AddCar', N'3.1.1');

GO

