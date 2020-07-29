IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Logins] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [Usuario] nvarchar(max) NOT NULL,
    [Contraseña] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Logins] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Paradas] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [Incidentes] int NOT NULL,
    [Tipo_incidente] nvarchar(max) NOT NULL,
    [Fecha] nvarchar(max) NOT NULL,
    [Hora] int NOT NULL,
    [Ruta] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Paradas] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Rutas] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [Nombre] nvarchar(max) NOT NULL,
    [Tramos] int NOT NULL,
    CONSTRAINT [PK_Rutas] PRIMARY KEY ([Id])
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
    CONSTRAINT [PK_Vehiculos] PRIMARY KEY ([Id])
);

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
    [LoginId] int NOT NULL,
    CONSTRAINT [PK_Supervisors] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Supervisors_Logins_LoginId] FOREIGN KEY ([LoginId]) REFERENCES [Logins] ([Id]) ON DELETE CASCADE
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

CREATE TABLE [Supervisions] (
    [Id] int NOT NULL IDENTITY,
    [CreatedAT] datetime2 NOT NULL,
    [UpdatedAT] datetime2 NULL,
    [Status] bit NOT NULL,
    [ParadasId] int NOT NULL,
    [RutasId] int NOT NULL,
    [VehiculoId] int NOT NULL,
    [ConductorId] int NOT NULL,
    [SupervisorId] int NOT NULL,
    CONSTRAINT [PK_Supervisions] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Supervisions_Conductors_ConductorId] FOREIGN KEY ([ConductorId]) REFERENCES [Conductors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Supervisions_Paradas_ParadasId] FOREIGN KEY ([ParadasId]) REFERENCES [Paradas] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Supervisions_Rutas_RutasId] FOREIGN KEY ([RutasId]) REFERENCES [Rutas] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Supervisions_Supervisors_SupervisorId] FOREIGN KEY ([SupervisorId]) REFERENCES [Supervisors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Supervisions_Vehiculos_VehiculoId] FOREIGN KEY ([VehiculoId]) REFERENCES [Vehiculos] ([Id]) ON DELETE CASCADE
);

GO

CREATE UNIQUE INDEX [IX_Conductors_VehiculoId] ON [Conductors] ([VehiculoId]);

GO

CREATE INDEX [IX_Supervisions_ConductorId] ON [Supervisions] ([ConductorId]);

GO

CREATE INDEX [IX_Supervisions_ParadasId] ON [Supervisions] ([ParadasId]);

GO

CREATE INDEX [IX_Supervisions_RutasId] ON [Supervisions] ([RutasId]);

GO

CREATE INDEX [IX_Supervisions_SupervisorId] ON [Supervisions] ([SupervisorId]);

GO

CREATE INDEX [IX_Supervisions_VehiculoId] ON [Supervisions] ([VehiculoId]);

GO

CREATE UNIQUE INDEX [IX_Supervisors_LoginId] ON [Supervisors] ([LoginId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200718005750_InitialMigration', N'3.1.5');

GO

