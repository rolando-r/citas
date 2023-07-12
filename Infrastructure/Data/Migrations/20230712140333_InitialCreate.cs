using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Acudientes",
                columns: table => new
                {
                    AcuCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AcuNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcuTelefono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcuDireccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudientes", x => x.AcuCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Consultorios",
                columns: table => new
                {
                    ConsCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConsNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorios", x => x.ConsCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EspNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoCitas",
                columns: table => new
                {
                    EstCitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EstCitaNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCitas", x => x.EstCitaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    GenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GenNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GenAbreviatura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GenId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    TipDocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipDocNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipDocAbreviatura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.TipDocId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    MedNroMatriculaProfesional = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedNombreCompleto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MedConsultorio = table.Column<int>(type: "int", nullable: false),
                    ConsultorioConsCodigo = table.Column<int>(type: "int", nullable: true),
                    MedEspecialidad = table.Column<int>(type: "int", nullable: false),
                    EspecialidadEspId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.MedNroMatriculaProfesional);
                    table.ForeignKey(
                        name: "FK_Medicos_Consultorios_ConsultorioConsCodigo",
                        column: x => x.ConsultorioConsCodigo,
                        principalTable: "Consultorios",
                        principalColumn: "ConsCodigo");
                    table.ForeignKey(
                        name: "FK_Medicos_Especialidades_EspecialidadEspId",
                        column: x => x.EspecialidadEspId,
                        principalTable: "Especialidades",
                        principalColumn: "EspId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuSegdoNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuPrimerApellidoUsuar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuSegdoApellidoUsuar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuTelefono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuDireccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuTipoDoc = table.Column<int>(type: "int", nullable: false),
                    TipoDocumentoTipDocId = table.Column<int>(type: "int", nullable: true),
                    UsuGenero = table.Column<int>(type: "int", nullable: false),
                    GeneroGenId = table.Column<int>(type: "int", nullable: true),
                    UsuAcudiente = table.Column<int>(type: "int", nullable: false),
                    AcudienteAcuCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Acudientes_AcudienteAcuCodigo",
                        column: x => x.AcudienteAcuCodigo,
                        principalTable: "Acudientes",
                        principalColumn: "AcuCodigo");
                    table.ForeignKey(
                        name: "FK_Usuarios_Generos_GeneroGenId",
                        column: x => x.GeneroGenId,
                        principalTable: "Generos",
                        principalColumn: "GenId");
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoDocumentos_TipoDocumentoTipDocId",
                        column: x => x.TipoDocumentoTipDocId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "TipDocId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    CitCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CitFecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CitEstado = table.Column<int>(type: "int", nullable: false),
                    EstadoCitaEstCitaId = table.Column<int>(type: "int", nullable: true),
                    CitMedico = table.Column<int>(type: "int", nullable: false),
                    MedicoMedNroMatriculaProfesional = table.Column<int>(type: "int", nullable: true),
                    CitDatosUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioUsuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitCodigo);
                    table.ForeignKey(
                        name: "FK_Citas_EstadoCitas_EstadoCitaEstCitaId",
                        column: x => x.EstadoCitaEstCitaId,
                        principalTable: "EstadoCitas",
                        principalColumn: "EstCitaId");
                    table.ForeignKey(
                        name: "FK_Citas_Medicos_MedicoMedNroMatriculaProfesional",
                        column: x => x.MedicoMedNroMatriculaProfesional,
                        principalTable: "Medicos",
                        principalColumn: "MedNroMatriculaProfesional");
                    table.ForeignKey(
                        name: "FK_Citas_Usuarios_UsuarioUsuId",
                        column: x => x.UsuarioUsuId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_EstadoCitaEstCitaId",
                table: "Citas",
                column: "EstadoCitaEstCitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_MedicoMedNroMatriculaProfesional",
                table: "Citas",
                column: "MedicoMedNroMatriculaProfesional");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_UsuarioUsuId",
                table: "Citas",
                column: "UsuarioUsuId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_ConsultorioConsCodigo",
                table: "Medicos",
                column: "ConsultorioConsCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadEspId",
                table: "Medicos",
                column: "EspecialidadEspId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AcudienteAcuCodigo",
                table: "Usuarios",
                column: "AcudienteAcuCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_GeneroGenId",
                table: "Usuarios",
                column: "GeneroGenId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoDocumentoTipDocId",
                table: "Usuarios",
                column: "TipoDocumentoTipDocId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "EstadoCitas");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Consultorios");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Acudientes");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");
        }
    }
}
