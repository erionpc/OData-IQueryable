using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OData_IQ_API.Migrations
{
    public partial class InitialiseDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecordStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StoreAddress_Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StoreAddress_City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StoreAddress_PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StoreAddress_Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StoreUri = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    RecordStoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicRecords_RecordStores_RecordStoreId",
                        column: x => x.RecordStoreId,
                        principalTable: "RecordStores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    RatedByPersonId = table.Column<int>(type: "int", nullable: false),
                    RatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusicRecordId = table.Column<int>(type: "int", nullable: false),
                    RecordStoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_MusicRecords_MusicRecordId",
                        column: x => x.MusicRecordId,
                        principalTable: "MusicRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_People_RatedByPersonId",
                        column: x => x.RatedByPersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_RecordStores_RecordStoreId",
                        column: x => x.RecordStoreId,
                        principalTable: "RecordStores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreMusicRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordStoreId = table.Column<int>(type: "int", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    DateFirstArrived = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreMusicRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreMusicRecord_MusicRecords_RecordId",
                        column: x => x.RecordId,
                        principalTable: "MusicRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreMusicRecord_RecordStores_RecordStoreId",
                        column: x => x.RecordStoreId,
                        principalTable: "RecordStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonMusicRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    StoreRecordId = table.Column<int>(type: "int", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: true),
                    DateBought = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMusicRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonMusicRecord_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonMusicRecord_StoreMusicRecord_RecordId",
                        column: x => x.RecordId,
                        principalTable: "StoreMusicRecord",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "MusicRecords",
                columns: new[] { "Id", "Artist", "RecordStoreId", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Artist 1", null, "Title 1", 2000 },
                    { 2, "Artist 2", null, "Title 2", 2001 },
                    { 3, "Artist 3", null, "Title 3", 2002 },
                    { 4, "Artist 1", null, "Title 4", 2004 },
                    { 5, "Artist 2", null, "Title 5", 2005 },
                    { 6, "Artist 3", null, "Title 6", 2006 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "DateOfBirth", "Email", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "test1@email.com", "name11", "surname1" },
                    { 2, new DateTimeOffset(new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "test2@email.com", "name12", "surname2" },
                    { 3, new DateTimeOffset(new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "test3@email.com", "name13", "surname3" },
                    { 4, new DateTimeOffset(new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "test4@email.com", "name14", "surname4" }
                });

            migrationBuilder.InsertData(
                table: "RecordStores",
                columns: new[] { "Id", "Name", "StoreUri", "Tags", "StoreAddress_City", "StoreAddress_Country", "StoreAddress_PostalCode", "StoreAddress_Street" },
                values: new object[] { 1, "Record store 1", "https://recordstore1.azurewebsites.net/", "[\"classic\",\"jazz\",\"blues\"]", "City 1", "Country 1", "CF101AA", "Street 1" });

            migrationBuilder.InsertData(
                table: "RecordStores",
                columns: new[] { "Id", "Name", "StoreUri", "Tags" },
                values: new object[] { 2, "Record store 2", "https://recordstore1.azurewebsites.net/", "[\"rock\",\"punk\",\"grunge\",\"metal\"]" });

            migrationBuilder.InsertData(
                table: "PersonMusicRecord",
                columns: new[] { "Id", "DateBought", "PersonId", "RecordId", "StoreRecordId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1 },
                    { 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 2 },
                    { 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 3 },
                    { 4, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 2 },
                    { 5, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 3 },
                    { 6, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 4 },
                    { 7, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 5 },
                    { 8, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 5 },
                    { 9, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 6 },
                    { 10, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 7 },
                    { 11, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "MusicRecordId", "RatedByPersonId", "RatedDate", "RecordStoreId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 2, 2, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 3, 4, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 4, 2, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 5, 3, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 6, 3, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 7, 2, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 }
                });

            migrationBuilder.InsertData(
                table: "StoreMusicRecord",
                columns: new[] { "Id", "DateFirstArrived", "RecordId", "RecordStoreId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 3, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 4, new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 5, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 6, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 7, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 8, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 9, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicRecords_RecordStoreId",
                table: "MusicRecords",
                column: "RecordStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_People_Email",
                table: "People",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonMusicRecord_PersonId",
                table: "PersonMusicRecord",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonMusicRecord_RecordId",
                table: "PersonMusicRecord",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_MusicRecordId",
                table: "Rating",
                column: "MusicRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_RatedByPersonId",
                table: "Rating",
                column: "RatedByPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_RecordStoreId",
                table: "Rating",
                column: "RecordStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMusicRecord_RecordId",
                table: "StoreMusicRecord",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMusicRecord_RecordStoreId_RecordId",
                table: "StoreMusicRecord",
                columns: new[] { "RecordStoreId", "RecordId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonMusicRecord");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "StoreMusicRecord");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "MusicRecords");

            migrationBuilder.DropTable(
                name: "RecordStores");
        }
    }
}
