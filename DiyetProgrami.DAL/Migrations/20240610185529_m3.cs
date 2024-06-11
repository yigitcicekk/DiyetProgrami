using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetProgrami.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieters_Users_UserId",
                table: "Dieters");

            migrationBuilder.DropIndex(
                name: "IX_Dieters_UserId",
                table: "Dieters");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Dieters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Dieters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dieters_UserId",
                table: "Dieters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieters_Users_UserId",
                table: "Dieters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
