IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Writers] (
    [ID] int NOT NULL IDENTITY,
    [DateOfBirth] datetime2 NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_Writers] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [Books] (
    [ID] int NOT NULL IDENTITY,
    [Title] nvarchar(100) NOT NULL,
    [WriterID] int NOT NULL,
    [Year] int NOT NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Books_Writers_WriterID] FOREIGN KEY ([WriterID]) REFERENCES [Writers] ([ID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Books_WriterID] ON [Books] ([WriterID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180713011446_LibraryInitial', N'2.0.3-rtm-10026');

GO

SET IDENTITY_INSERT [dbo].[Writers] ON
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (1, N'1903-06-25 00:00:00', N'George Orwell')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (2, N'1896-11-19 00:00:00', N'Lev Vygotsky')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (3, N'1950-01-18 00:00:00', N'Michael Tomasello')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (4, N'1922-06-11 00:00:00', N'Erving Goffman')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (5, N'1976-02-24 00:00:00', N'Yuval Noah Harari')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (6, N'1890-09-15 00:00:00', N'Agatha Christie')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (7, N'1917-02-11 00:00:00', N'Sidney Sheldon')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (8, N'1947-08-24 00:00:00', N'Paulo Coelho')
INSERT INTO [dbo].[Writers] ([ID], [DateOfBirth], [Name]) VALUES (9, N'1892-01-03 00:00:00', N'J. R. R. Tolkien')
SET IDENTITY_INSERT [dbo].[Writers] OFF


SET IDENTITY_INSERT [dbo].[Books] ON
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (1, N'My book 1', 1, 1960)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (2, N'My book 2', 1, 1961)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (3, N'My book 3', 1, 1962)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (4, N'My book 4', 2, 1963)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (5, N'My book 5', 2, 1964)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (6, N'My book 6', 3, 1965)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (7, N'My book 7', 4, 1966)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (8, N'My book 8', 4, 1967)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (9, N'My book 9', 5, 1968)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (10, N'My book 10', 6, 1969)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (11, N'My book 11', 6, 1970)
INSERT INTO [dbo].[Books] ([ID], [Title], [WriterID], [Year]) VALUES (12, N'My book 12', 6, 1971)
SET IDENTITY_INSERT [dbo].[Books] OFF
