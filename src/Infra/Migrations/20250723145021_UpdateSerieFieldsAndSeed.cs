﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSerieFieldsAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("527527a4-7afe-4bb2-beb9-eb7882a21581"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("bde9c541-2d22-4e9e-b531-61fd747bae3d"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("e2fb83cf-37e2-4c06-9939-389e7ca2d2de"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("f0724150-cd9c-4b69-a02b-441af370e4e7"));

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Genre", "Seasons", "Title" },
                values: new object[,]
                {
                    { new Guid("a1111111-1111-1111-1111-111111111111"), "[\"Fantasy\"]", 9, "Game of Thrones" },
                    { new Guid("b1111111-1111-1111-1111-111111111111"), "[\"Crime\"]", 5, "Breaking Bad" },
                    { new Guid("c1111111-1111-1111-1111-111111111111"), "[\"Sci-Fi\"]", 4, "Stranger Things" },
                    { new Guid("d1111111-1111-1111-1111-111111111111"), "[\"Drama\"]", 6, "The Crown" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"));

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Genre", "Seasons", "Title" },
                values: new object[,]
                {
                    { new Guid("527527a4-7afe-4bb2-beb9-eb7882a21581"), "[\"Drama\"]", 6, "The Crown" },
                    { new Guid("bde9c541-2d22-4e9e-b531-61fd747bae3d"), "[\"Fantasy\"]", 9, "Game of Thrones" },
                    { new Guid("e2fb83cf-37e2-4c06-9939-389e7ca2d2de"), "[\"Crime\"]", 5, "Breaking Bad" },
                    { new Guid("f0724150-cd9c-4b69-a02b-441af370e4e7"), "[\"Sci-Fi\"]", 4, "Stranger Things" }
                });
        }
    }
}