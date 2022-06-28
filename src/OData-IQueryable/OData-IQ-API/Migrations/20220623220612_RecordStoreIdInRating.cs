using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OData_IQ_API.Migrations
{
    public partial class RecordStoreIdInRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_MusicRecords_MusicRecordId",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "MusicRecordId",
                table: "Ratings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MusicRecordId", "RatedByPersonId", "RatedDate", "RecordStoreId", "Value" },
                values: new object[,]
                {
                    { 8, null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 9, null, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 10, null, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 11, null, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 12, null, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_MusicRecords_MusicRecordId",
                table: "Ratings",
                column: "MusicRecordId",
                principalTable: "MusicRecords",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_MusicRecords_MusicRecordId",
                table: "Ratings");

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<int>(
                name: "MusicRecordId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_MusicRecords_MusicRecordId",
                table: "Ratings",
                column: "MusicRecordId",
                principalTable: "MusicRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
