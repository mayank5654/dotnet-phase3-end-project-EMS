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

CREATE TABLE [Department] (
    [DeptCode] int NOT NULL IDENTITY,
    [DeptName] nvarchar(max) NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY ([DeptCode])
);
GO

CREATE TABLE [Employee] (
    [EmpCode] int NOT NULL IDENTITY,
    [DateOfBirth] datetime2 NOT NULL,
    [EmpName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [DeptCode] int NOT NULL,
    [DeptMasterDeptCode] int NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY ([EmpCode]),
    CONSTRAINT [FK_Employee_Department_DeptMasterDeptCode] FOREIGN KEY ([DeptMasterDeptCode]) REFERENCES [Department] ([DeptCode])
);
GO

CREATE INDEX [IX_Employee_DeptMasterDeptCode] ON [Employee] ([DeptMasterDeptCode]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240103102052_FirstMig', N'6.0.23');
GO

COMMIT;
GO

