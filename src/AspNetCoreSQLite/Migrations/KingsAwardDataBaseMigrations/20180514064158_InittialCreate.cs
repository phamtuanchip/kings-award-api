using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetCoreSQLite.Migrations.KingsAwardDataBaseMigrations
{
    public partial class InittialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Archiveid",
                table: "TasksDone",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "TasksDone",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "tasksId",
                table: "TasksDone",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "DefaultPoint",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManualPoint",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Archives",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArchivePoints = table.Column<long>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Data = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateTime = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    awardsId = table.Column<long>(type: "INTEGER", nullable: false),
                    childrenId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archives", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TasksDone_Archiveid",
                table: "TasksDone",
                column: "Archiveid");

            migrationBuilder.AddForeignKey(
                name: "FK_TasksDone_Archives_Archiveid",
                table: "TasksDone",
                column: "Archiveid",
                principalTable: "Archives",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TasksDone_Archives_Archiveid",
                table: "TasksDone");

            migrationBuilder.DropTable(
                name: "Archives");

            migrationBuilder.DropIndex(
                name: "IX_TasksDone_Archiveid",
                table: "TasksDone");

            migrationBuilder.DropColumn(
                name: "Archiveid",
                table: "TasksDone");

            migrationBuilder.DropColumn(
                name: "Point",
                table: "TasksDone");

            migrationBuilder.DropColumn(
                name: "tasksId",
                table: "TasksDone");

            migrationBuilder.DropColumn(
                name: "DefaultPoint",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ManualPoint",
                table: "Tasks");
        }
    }
}
