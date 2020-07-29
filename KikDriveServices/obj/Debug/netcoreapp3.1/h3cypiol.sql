IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Supervisors] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [Nombre] nvarchar(max) NOT NULL,
    [Apellido_Paterno] nvarchar(max) NOT NULL,
    [Apellido_Materno] nvarchar(max) NOT NULL,
    [Usuario] nvarchar(max) NOT NULL,
    [Contraseña] nvarchar(max) NOT NULL,
    [Telefono] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Supervisors] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [UserName] nvarchar(max) NULL,
    [Password] nvarchar(max) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Vehiculos] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [Placa] nvarchar(1) NOT NULL,
    [Marca] nvarchar(max) NOT NULL,
    [Modelo] int NOT NULL,
    [Dimensiones] nvarchar(max) NOT NULL,
    [Capacidad] int NOT NULL,
    [VehiculoId] int NULL,
    CONSTRAINT [PK_Vehiculos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Vehiculos_Vehiculos_VehiculoId] FOREIGN KEY ([VehiculoId]) REFERENCES [Vehiculos] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Logins] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [Usuario] nvarchar(max) NOT NULL,
    [Contraseña] nvarchar(max) NOT NULL,
    [SupervisorId] int NOT NULL,
    CONSTRAINT [PK_Logins] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Logins_Supervisors_SupervisorId] FOREIGN KEY ([SupervisorId]) REFERENCES [Supervisors] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Conductors] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [Nombre] nvarchar(max) NOT NULL,
    [Apellido_Paterno] nvarchar(max) NOT NULL,
    [Apellifo_Materno] nvarchar(max) NOT NULL,
    [Tipo_liciencia] nvarchar(max) NOT NULL,
    [Vehiculos] nvarchar(1) NOT NULL,
    [VehiculoId] int NOT NULL,
    CONSTRAINT [PK_Conductors] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Conductors_Vehiculos_VehiculoId] FOREIGN KEY ([VehiculoId]) REFERENCES [Vehiculos] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Conductors_VehiculoId] ON [Conductors] ([VehiculoId]);

GO

CREATE INDEX [IX_Logins_SupervisorId] ON [Logins] ([SupervisorId]);

GO

CREATE INDEX [IX_Vehiculos_VehiculoId] ON [Vehiculos] ([VehiculoId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200714162754_InitialMigration', N'3.1.5');

GO

