﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Napelem_API.Migrations
{
    /// <inheritdoc />
    public partial class addCurrent_quantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "current_quantity",
                table: "Components",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "current_quantity",
                table: "Components");
        }
    }
}
