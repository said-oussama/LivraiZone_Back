﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Rentals_RentalId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "RentalId",
                table: "Members",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Rentals_RentalId",
                table: "Members",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "RentalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Rentals_RentalId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "RentalId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Rentals_RentalId",
                table: "Members",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "RentalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
