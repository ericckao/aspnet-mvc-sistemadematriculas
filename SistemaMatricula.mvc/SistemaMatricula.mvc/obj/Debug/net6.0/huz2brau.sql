IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_MATRICULAS] (
    [MatriculaId] int NOT NULL IDENTITY,
    [NOME_ALUNO] nvarchar(50) NOT NULL DEFAULT N'CAMPO-VAZIO',
    [NOME_CURSO] nvarchar(100) NOT NULL DEFAULT N'CAMPO-VAZIO',
    [UNIDADE] nvarchar(20) NOT NULL DEFAULT N'CAMPO-VAZIO',
    [DATA_MATRICULA] datetimeoffset NOT NULL DEFAULT '2023-07-21T15:42:00.6935469-03:00',
    CONSTRAINT [PK_TB_MATRICULAS] PRIMARY KEY ([MatriculaId])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MatriculaId', N'NOME_CURSO', N'DATA_MATRICULA', N'NOME_ALUNO', N'UNIDADE') AND [object_id] = OBJECT_ID(N'[TB_MATRICULAS]'))
    SET IDENTITY_INSERT [TB_MATRICULAS] ON;
INSERT INTO [TB_MATRICULAS] ([MatriculaId], [NOME_CURSO], [DATA_MATRICULA], [NOME_ALUNO], [UNIDADE])
VALUES (1, N'Análise e Desenvolvimento de Sistemas', '2023-07-21T15:42:00.6935602-03:00', N'Erik Fernandes', N'Vergueiro'),
(2, N'Enfermagem', '2023-07-21T15:42:00.6935607-03:00', N'Marcos Felipe', N'São Judas'),
(3, N'Odontólogia', '2023-07-21T15:42:00.6935610-03:00', N'Mariana Dias', N'Vila Mariana'),
(4, N'Publicidade e Propaganda', '2023-07-21T15:42:00.6935613-03:00', N'Leticia Silva', N'Paulista'),
(5, N'Culínaria', '2023-07-21T15:42:00.6935615-03:00', N'Beatriz Reis', N'Praça da Arvoré'),
(6, N'Administração', '2023-07-21T15:42:00.6935617-03:00', N'Vinicius Muller', N'Saúde');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MatriculaId', N'NOME_CURSO', N'DATA_MATRICULA', N'NOME_ALUNO', N'UNIDADE') AND [object_id] = OBJECT_ID(N'[TB_MATRICULAS]'))
    SET IDENTITY_INSERT [TB_MATRICULAS] OFF;
GO

CREATE INDEX [IX_MATRICULA_UNIQUE] ON [TB_MATRICULAS] ([MatriculaId]);
GO

CREATE INDEX [IX_NOME_UNIQUE] ON [TB_MATRICULAS] ([NOME_ALUNO]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230721184200_BancoInicial', N'6.0.20');
GO

COMMIT;
GO

