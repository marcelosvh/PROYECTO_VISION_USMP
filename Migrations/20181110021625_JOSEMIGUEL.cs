using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROYECTOAPPVISIONVISUALSTUDIO.Migrations
{
    public partial class JOSEMIGUEL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aula",
                columns: table => new
                {
                    IDAula = table.Column<string>(nullable: false),
                    DescAula = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aula", x => x.IDAula);
                });

            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    IDCarrera = table.Column<string>(nullable: false),
                    NomCarrera = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.IDCarrera);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    IDEmpresa = table.Column<string>(nullable: false),
                    NomEmpresa = table.Column<string>(nullable: false),
                    CorreoEmpresa = table.Column<string>(nullable: false),
                    Pais = table.Column<string>(nullable: false),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.IDEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IDEvento = table.Column<string>(nullable: false),
                    TemaEvento = table.Column<string>(nullable: false),
                    Fecha_Ini = table.Column<string>(nullable: false),
                    Fecha_Fin = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IDEvento);
                });

            migrationBuilder.CreateTable(
                name: "Pabellon",
                columns: table => new
                {
                    IDPabellon = table.Column<string>(nullable: false),
                    NomPab = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pabellon", x => x.IDPabellon);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    IDTip = table.Column<string>(nullable: false),
                    DescTip = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.IDTip);
                });

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    DNI = table.Column<string>(nullable: false),
                    ApePat = table.Column<string>(nullable: false),
                    ApeMat = table.Column<string>(nullable: false),
                    NomAlumno = table.Column<string>(nullable: false),
                    CorreoAlum = table.Column<string>(nullable: false),
                    Celular = table.Column<int>(nullable: false),
                    FechaNac = table.Column<DateTime>(nullable: false),
                    IDCarrera = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.DNI);
                    table.ForeignKey(
                        name: "FK_Alumno_Carrera_IDCarrera",
                        column: x => x.IDCarrera,
                        principalTable: "Carrera",
                        principalColumn: "IDCarrera",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expositor",
                columns: table => new
                {
                    IDExpositor = table.Column<string>(nullable: false),
                    ApePat = table.Column<string>(nullable: false),
                    ApeMat = table.Column<string>(nullable: false),
                    NomExp = table.Column<string>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: false),
                    TipoOrador = table.Column<string>(nullable: false),
                    CorreoExp = table.Column<string>(nullable: false),
                    Orden = table.Column<int>(maxLength: 1, nullable: false),
                    IDEmpresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expositor", x => x.IDExpositor);
                    table.ForeignKey(
                        name: "FK_Expositor_Empresa_IDEmpresa",
                        column: x => x.IDEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "IDEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conferencia",
                columns: table => new
                {
                    IDConferencia = table.Column<string>(nullable: false),
                    NomConferencia = table.Column<string>(nullable: false),
                    HoraIni = table.Column<DateTime>(nullable: false),
                    HoraFin = table.Column<DateTime>(nullable: false),
                    Fecha = table.Column<string>(nullable: false),
                    IDPabellon = table.Column<string>(nullable: true),
                    IDAula = table.Column<string>(nullable: true),
                    IDCarrera = table.Column<string>(nullable: true),
                    IDEvento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferencia", x => x.IDConferencia);
                    table.ForeignKey(
                        name: "FK_Conferencia_Aula_IDAula",
                        column: x => x.IDAula,
                        principalTable: "Aula",
                        principalColumn: "IDAula",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conferencia_Carrera_IDCarrera",
                        column: x => x.IDCarrera,
                        principalTable: "Carrera",
                        principalColumn: "IDCarrera",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conferencia_Evento_IDEvento",
                        column: x => x.IDEvento,
                        principalTable: "Evento",
                        principalColumn: "IDEvento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conferencia_Pabellon_IDPabellon",
                        column: x => x.IDPabellon,
                        principalTable: "Pabellon",
                        principalColumn: "IDPabellon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PabAula",
                columns: table => new
                {
                    IDPabellon = table.Column<string>(nullable: false),
                    IDAula = table.Column<string>(nullable: false),
                    Piso = table.Column<int>(maxLength: 1, nullable: false),
                    Capacidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PabAula", x => new { x.IDPabellon, x.IDAula });
                    table.ForeignKey(
                        name: "FK_PabAula_Aula_IDAula",
                        column: x => x.IDAula,
                        principalTable: "Aula",
                        principalColumn: "IDAula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PabAula_Pabellon_IDPabellon",
                        column: x => x.IDPabellon,
                        principalTable: "Pabellon",
                        principalColumn: "IDPabellon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taller",
                columns: table => new
                {
                    IDTaller = table.Column<string>(nullable: false),
                    NomTaller = table.Column<string>(nullable: false),
                    HoraIni = table.Column<DateTime>(nullable: false),
                    HoraFin = table.Column<DateTime>(nullable: false),
                    Fecha = table.Column<string>(nullable: false),
                    IDPabellon = table.Column<string>(nullable: true),
                    IDAula = table.Column<string>(nullable: true),
                    IDCarrera = table.Column<string>(nullable: true),
                    IDEvento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taller", x => x.IDTaller);
                    table.ForeignKey(
                        name: "FK_Taller_Aula_IDAula",
                        column: x => x.IDAula,
                        principalTable: "Aula",
                        principalColumn: "IDAula",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Taller_Carrera_IDCarrera",
                        column: x => x.IDCarrera,
                        principalTable: "Carrera",
                        principalColumn: "IDCarrera",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Taller_Evento_IDEvento",
                        column: x => x.IDEvento,
                        principalTable: "Evento",
                        principalColumn: "IDEvento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Taller_Pabellon_IDPabellon",
                        column: x => x.IDPabellon,
                        principalTable: "Pabellon",
                        principalColumn: "IDPabellon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpTipDoc",
                columns: table => new
                {
                    IDTip = table.Column<string>(nullable: false),
                    IDExpositor = table.Column<string>(nullable: false),
                    Número = table.Column<int>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpTipDoc", x => new { x.IDTip, x.IDExpositor });
                    table.ForeignKey(
                        name: "FK_ExpTipDoc_Expositor_IDExpositor",
                        column: x => x.IDExpositor,
                        principalTable: "Expositor",
                        principalColumn: "IDExpositor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpTipDoc_TipoDocumento_IDTip",
                        column: x => x.IDTip,
                        principalTable: "TipoDocumento",
                        principalColumn: "IDTip",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequisitosConferencia",
                columns: table => new
                {
                    IDExpositor = table.Column<string>(nullable: false),
                    IDConferencia = table.Column<string>(nullable: false),
                    DescReqConf = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitosConferencia", x => new { x.IDExpositor, x.IDConferencia });
                    table.ForeignKey(
                        name: "FK_RequisitosConferencia_Conferencia_IDConferencia",
                        column: x => x.IDConferencia,
                        principalTable: "Conferencia",
                        principalColumn: "IDConferencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequisitosConferencia_Expositor_IDExpositor",
                        column: x => x.IDExpositor,
                        principalTable: "Expositor",
                        principalColumn: "IDExpositor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequisitosTaller",
                columns: table => new
                {
                    IDExpositor = table.Column<string>(nullable: false),
                    IDTaller = table.Column<string>(nullable: false),
                    DescReqTal = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitosTaller", x => new { x.IDExpositor, x.IDTaller });
                    table.ForeignKey(
                        name: "FK_RequisitosTaller_Expositor_IDExpositor",
                        column: x => x.IDExpositor,
                        principalTable: "Expositor",
                        principalColumn: "IDExpositor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequisitosTaller_Taller_IDTaller",
                        column: x => x.IDTaller,
                        principalTable: "Taller",
                        principalColumn: "IDTaller",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_IDCarrera",
                table: "Alumno",
                column: "IDCarrera");

            migrationBuilder.CreateIndex(
                name: "IX_Conferencia_IDAula",
                table: "Conferencia",
                column: "IDAula");

            migrationBuilder.CreateIndex(
                name: "IX_Conferencia_IDCarrera",
                table: "Conferencia",
                column: "IDCarrera");

            migrationBuilder.CreateIndex(
                name: "IX_Conferencia_IDEvento",
                table: "Conferencia",
                column: "IDEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Conferencia_IDPabellon",
                table: "Conferencia",
                column: "IDPabellon");

            migrationBuilder.CreateIndex(
                name: "IX_Expositor_IDEmpresa",
                table: "Expositor",
                column: "IDEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_ExpTipDoc_IDExpositor",
                table: "ExpTipDoc",
                column: "IDExpositor");

            migrationBuilder.CreateIndex(
                name: "IX_PabAula_IDAula",
                table: "PabAula",
                column: "IDAula");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitosConferencia_IDConferencia",
                table: "RequisitosConferencia",
                column: "IDConferencia");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitosTaller_IDTaller",
                table: "RequisitosTaller",
                column: "IDTaller");

            migrationBuilder.CreateIndex(
                name: "IX_Taller_IDAula",
                table: "Taller",
                column: "IDAula");

            migrationBuilder.CreateIndex(
                name: "IX_Taller_IDCarrera",
                table: "Taller",
                column: "IDCarrera");

            migrationBuilder.CreateIndex(
                name: "IX_Taller_IDEvento",
                table: "Taller",
                column: "IDEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Taller_IDPabellon",
                table: "Taller",
                column: "IDPabellon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "ExpTipDoc");

            migrationBuilder.DropTable(
                name: "PabAula");

            migrationBuilder.DropTable(
                name: "RequisitosConferencia");

            migrationBuilder.DropTable(
                name: "RequisitosTaller");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Conferencia");

            migrationBuilder.DropTable(
                name: "Expositor");

            migrationBuilder.DropTable(
                name: "Taller");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Aula");

            migrationBuilder.DropTable(
                name: "Carrera");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Pabellon");
        }
    }
}
