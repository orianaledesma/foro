using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Foro.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 200, nullable: false),
                    Apellido = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: false),
                    FechaAlta = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Telefono = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    FechaAlta = table.Column<DateTime>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    MiembroId = table.Column<int>(nullable: false),
                    Privada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrada_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entrada_Usuario_MiembroId",
                        column: x => x.MiembroId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntradasMiembros",
                columns: table => new
                {
                    EntradaId = table.Column<int>(nullable: false),
                    MiembroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasMiembros", x => new { x.EntradaId, x.MiembroId });
                    table.ForeignKey(
                        name: "FK_EntradasMiembros_Entrada_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entrada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntradasMiembros_Usuario_MiembroId",
                        column: x => x.MiembroId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pregunta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: false),
                    EntradaId = table.Column<int>(nullable: false),
                    MiembroId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Activa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregunta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pregunta_Entrada_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entrada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pregunta_Usuario_MiembroId",
                        column: x => x.MiembroId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Respuesta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreguntaId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 2000, nullable: false),
                    MiembroId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respuesta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Respuesta_Usuario_MiembroId",
                        column: x => x.MiembroId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Respuesta_Pregunta_PreguntaId",
                        column: x => x.PreguntaId,
                        principalTable: "Pregunta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reaccion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    MeGusta = table.Column<bool>(nullable: false),
                    RespuestaId = table.Column<int>(nullable: false),
                    MiembroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reaccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reaccion_Usuario_MiembroId",
                        column: x => x.MiembroId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reaccion_Respuesta_RespuestaId",
                        column: x => x.RespuestaId,
                        principalTable: "Respuesta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_CategoriaId",
                table: "Entrada",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_MiembroId",
                table: "Entrada",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasMiembros_MiembroId",
                table: "EntradasMiembros",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregunta_EntradaId",
                table: "Pregunta",
                column: "EntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregunta_MiembroId",
                table: "Pregunta",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaccion_MiembroId",
                table: "Reaccion",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaccion_RespuestaId",
                table: "Reaccion",
                column: "RespuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_Respuesta_MiembroId",
                table: "Respuesta",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Respuesta_PreguntaId",
                table: "Respuesta",
                column: "PreguntaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradasMiembros");

            migrationBuilder.DropTable(
                name: "Reaccion");

            migrationBuilder.DropTable(
                name: "Respuesta");

            migrationBuilder.DropTable(
                name: "Pregunta");

            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
