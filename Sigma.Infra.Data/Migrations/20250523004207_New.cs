using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sigma.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "classificacao",
                table: "projetos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "datainicio",
                table: "projetos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "projetos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "orcamentototal",
                table: "projetos",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "previsaotermino",
                table: "projetos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "classificacao",
                table: "projetos");

            migrationBuilder.DropColumn(
                name: "datainicio",
                table: "projetos");

            migrationBuilder.DropColumn(
                name: "descricao",
                table: "projetos");

            migrationBuilder.DropColumn(
                name: "orcamentototal",
                table: "projetos");

            migrationBuilder.DropColumn(
                name: "previsaotermino",
                table: "projetos");
        }
    }
}
