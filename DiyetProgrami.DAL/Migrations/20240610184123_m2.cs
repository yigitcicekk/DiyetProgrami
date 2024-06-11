﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetProgrami.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieters_Users_UserId",
                table: "Dieters");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Dieters",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieters_Users_UserId",
                table: "Dieters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieters_Users_UserId",
                table: "Dieters");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Dieters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dieters_Users_UserId",
                table: "Dieters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
