using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatupWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class NovasEntidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalarioBase = table.Column<double>(type: "double", nullable: false),
                    DataAniver = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendedores_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecordVendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Quantia = table.Column<double>(type: "double", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    VendedoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordVendas_Vendedores_VendedoresId",
                        column: x => x.VendedoresId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RecordVendas_VendedoresId",
                table: "RecordVendas",
                column: "VendedoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_DepartamentoId",
                table: "Vendedores",
                column: "DepartamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordVendas");

            migrationBuilder.DropTable(
                name: "Vendedores");
        }
    }
}
