using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KikDriveServices.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Tramos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido_Paterno = table.Column<string>(nullable: false),
                    Apellido_Materno = table.Column<string>(nullable: false),
                    Usuario = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Placa = table.Column<string>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    Modelo = table.Column<int>(nullable: false),
                    Dimensiones = table.Column<string>(nullable: false),
                    Capacidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paradas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Incidentes = table.Column<int>(nullable: false),
                    Tipo_incidente = table.Column<string>(nullable: false),
                    Fecha = table.Column<string>(nullable: false),
                    Hora = table.Column<int>(nullable: false),
                    RutasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paradas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paradas_Rutas_RutasId",
                        column: x => x.RutasId,
                        principalTable: "Rutas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Usuario = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false),
                    SupervisorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supervisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Paradas = table.Column<string>(nullable: false),
                    Rutas = table.Column<string>(nullable: false),
                    Vehiculo = table.Column<string>(nullable: false),
                    Conductor = table.Column<string>(nullable: false),
                    SupervisorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supervisions_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conductors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido_Paterno = table.Column<string>(nullable: false),
                    Apellifo_Materno = table.Column<string>(nullable: false),
                    Tipo_liciencia = table.Column<string>(nullable: false),
                    Vehiculos = table.Column<string>(nullable: false),
                    VehiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conductors_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conductors_VehiculoId",
                table: "Conductors",
                column: "VehiculoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_SupervisorId",
                table: "Logins",
                column: "SupervisorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paradas_RutasId",
                table: "Paradas",
                column: "RutasId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supervisions_SupervisorId",
                table: "Supervisions",
                column: "SupervisorId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conductors");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Paradas");

            migrationBuilder.DropTable(
                name: "Supervisions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "Supervisors");
        }
    }
}
