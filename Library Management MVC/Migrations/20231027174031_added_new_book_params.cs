using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Advance_Library_Management_Application.Migrations
{
    public partial class added_new_book_params : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Available",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Available",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
