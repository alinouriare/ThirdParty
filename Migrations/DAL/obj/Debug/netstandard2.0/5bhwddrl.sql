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

