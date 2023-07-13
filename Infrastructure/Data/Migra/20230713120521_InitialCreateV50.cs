using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migra
{
    /// <inheritdoc />
    public partial class InitialCreateV50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Acudiente",
                columns: table => new
                {
                    AcuCodigo = table.Column<int>(type: "int", nullable: false),
                    AcuNombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcuTelefono = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcuDireccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudiente", x => x.AcuCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Consultorios",
                columns: table => new
                {
                    ConsCodigo = table.Column<int>(type: "int", nullable: false),
                    ConsNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorios", x => x.ConsCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    EspId = table.Column<int>(type: "int", nullable: false),
                    EspNombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.EspId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoCita",
                columns: table => new
                {
                    EstCitaId = table.Column<int>(type: "int", nullable: false),
                    EstCitaNombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCita", x => x.EstCitaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    GenId = table.Column<int>(type: "int", nullable: false),
                    GenNombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GenAbreviatura = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.GenId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    TipDocId = table.Column<int>(type: "int", nullable: false),
                    TipDocNombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipDocAbreviatura = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.TipDocId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedNroMatriculaProfesional = table.Column<int>(type: "int", nullable: false),
                    MedNombreCompleto = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MedConsultorio = table.Column<int>(type: "int", nullable: false),
                    MedEspecialidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedNroMatriculaProfesional);
                    table.ForeignKey(
                        name: "FK_Medico_Consultorios_MedConsultorio",
                        column: x => x.MedConsultorio,
                        principalTable: "Consultorios",
                        principalColumn: "ConsCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidad_MedEspecialidad",
                        column: x => x.MedEspecialidad,
                        principalTable: "Especialidad",
                        principalColumn: "EspId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuId = table.Column<int>(type: "int", nullable: false),
                    UsuNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuSegdoNombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuPrimerApellidoUsuar = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuSegdoApellidoUsuar = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuTelefono = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuDireccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuTipoDoc = table.Column<int>(type: "int", nullable: false),
                    UsuGenero = table.Column<int>(type: "int", nullable: false),
                    UsuAcudiente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuId);
                    table.ForeignKey(
                        name: "FK_Usuario_Acudiente_UsuAcudiente",
                        column: x => x.UsuAcudiente,
                        principalTable: "Acudiente",
                        principalColumn: "AcuCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Genero_UsuGenero",
                        column: x => x.UsuGenero,
                        principalTable: "Genero",
                        principalColumn: "GenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_TipoDocumento_UsuTipoDoc",
                        column: x => x.UsuTipoDoc,
                        principalTable: "TipoDocumento",
                        principalColumn: "TipDocId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    CitCodigo = table.Column<int>(type: "int", nullable: false),
                    CitFecha = table.Column<DateTime>(type: "date", nullable: false),
                    CitEstado = table.Column<int>(type: "int", nullable: false),
                    CitMedico = table.Column<int>(type: "int", nullable: false),
                    CitDatosUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.CitCodigo);
                    table.ForeignKey(
                        name: "FK_Cita_EstadoCita_CitEstado",
                        column: x => x.CitEstado,
                        principalTable: "EstadoCita",
                        principalColumn: "EstCitaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cita_Medico_CitMedico",
                        column: x => x.CitMedico,
                        principalTable: "Medico",
                        principalColumn: "MedNroMatriculaProfesional",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cita_Usuario_CitDatosUsuario",
                        column: x => x.CitDatosUsuario,
                        principalTable: "Usuario",
                        principalColumn: "UsuId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_CitDatosUsuario",
                table: "Cita",
                column: "CitDatosUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_CitEstado",
                table: "Cita",
                column: "CitEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_CitMedico",
                table: "Cita",
                column: "CitMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_MedConsultorio",
                table: "Medico",
                column: "MedConsultorio");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_MedEspecialidad",
                table: "Medico",
                column: "MedEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuAcudiente",
                table: "Usuario",
                column: "UsuAcudiente");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuGenero",
                table: "Usuario",
                column: "UsuGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuTipoDoc",
                table: "Usuario",
                column: "UsuTipoDoc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "EstadoCita");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Consultorios");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoDocumento");
        }
    }
}
