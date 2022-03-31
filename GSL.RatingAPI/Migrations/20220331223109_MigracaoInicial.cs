﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GSL.RatingAPI.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgilidadeNaEntrega = table.Column<int>(type: "int", nullable: false),
                    Transparencia = table.Column<int>(type: "int", nullable: false),
                    BoaComunicacao = table.Column<int>(type: "int", nullable: false),
                    CuidadoComMercadoria = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");
        }
    }
}
