using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICI.ProvaCandidato.Dados.Migrations
{
    public partial class correção : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Noticia_NoticiiaId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_NoticiiaId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "NoticiiaId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Noticia");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tag",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tag",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tag",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "NoticiaTag",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "NoticiaTag",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "NoticiaTag",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Noticia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Noticia",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Noticia",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Noticia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "NoticiaTag");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "NoticiaTag");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "NoticiaTag");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Noticia");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Noticia");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Noticia");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Noticia");

            migrationBuilder.AddColumn<int>(
                name: "NoticiiaId",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Noticia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_NoticiiaId",
                table: "Tag",
                column: "NoticiiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Noticia_NoticiiaId",
                table: "Tag",
                column: "NoticiiaId",
                principalTable: "Noticia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
