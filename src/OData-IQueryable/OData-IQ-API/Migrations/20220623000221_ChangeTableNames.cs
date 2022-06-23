using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OData_IQ_API.Migrations
{
    public partial class ChangeTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonMusicRecord_People_PersonId",
                table: "PersonMusicRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonMusicRecord_StoreMusicRecord_RecordId",
                table: "PersonMusicRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_MusicRecords_MusicRecordId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_People_RatedByPersonId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_RecordStores_RecordStoreId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreMusicRecord_MusicRecords_RecordId",
                table: "StoreMusicRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreMusicRecord_RecordStores_RecordStoreId",
                table: "StoreMusicRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreMusicRecord",
                table: "StoreMusicRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonMusicRecord",
                table: "PersonMusicRecord");

            migrationBuilder.RenameTable(
                name: "StoreMusicRecord",
                newName: "StoreMusicRecords");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Ratings");

            migrationBuilder.RenameTable(
                name: "PersonMusicRecord",
                newName: "PersonMusicRecords");

            migrationBuilder.RenameIndex(
                name: "IX_StoreMusicRecord_RecordStoreId_RecordId",
                table: "StoreMusicRecords",
                newName: "IX_StoreMusicRecords_RecordStoreId_RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreMusicRecord_RecordId",
                table: "StoreMusicRecords",
                newName: "IX_StoreMusicRecords_RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_RecordStoreId",
                table: "Ratings",
                newName: "IX_Ratings_RecordStoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_RatedByPersonId",
                table: "Ratings",
                newName: "IX_Ratings_RatedByPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_MusicRecordId",
                table: "Ratings",
                newName: "IX_Ratings_MusicRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonMusicRecord_RecordId",
                table: "PersonMusicRecords",
                newName: "IX_PersonMusicRecords_RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonMusicRecord_PersonId",
                table: "PersonMusicRecords",
                newName: "IX_PersonMusicRecords_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreMusicRecords",
                table: "StoreMusicRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonMusicRecords",
                table: "PersonMusicRecords",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMusicRecords_People_PersonId",
                table: "PersonMusicRecords",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMusicRecords_StoreMusicRecords_RecordId",
                table: "PersonMusicRecords",
                column: "RecordId",
                principalTable: "StoreMusicRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_MusicRecords_MusicRecordId",
                table: "Ratings",
                column: "MusicRecordId",
                principalTable: "MusicRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_People_RatedByPersonId",
                table: "Ratings",
                column: "RatedByPersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_RecordStores_RecordStoreId",
                table: "Ratings",
                column: "RecordStoreId",
                principalTable: "RecordStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreMusicRecords_MusicRecords_RecordId",
                table: "StoreMusicRecords",
                column: "RecordId",
                principalTable: "MusicRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreMusicRecords_RecordStores_RecordStoreId",
                table: "StoreMusicRecords",
                column: "RecordStoreId",
                principalTable: "RecordStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonMusicRecords_People_PersonId",
                table: "PersonMusicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonMusicRecords_StoreMusicRecords_RecordId",
                table: "PersonMusicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_MusicRecords_MusicRecordId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_People_RatedByPersonId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_RecordStores_RecordStoreId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreMusicRecords_MusicRecords_RecordId",
                table: "StoreMusicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreMusicRecords_RecordStores_RecordStoreId",
                table: "StoreMusicRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreMusicRecords",
                table: "StoreMusicRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonMusicRecords",
                table: "PersonMusicRecords");

            migrationBuilder.RenameTable(
                name: "StoreMusicRecords",
                newName: "StoreMusicRecord");

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "Rating");

            migrationBuilder.RenameTable(
                name: "PersonMusicRecords",
                newName: "PersonMusicRecord");

            migrationBuilder.RenameIndex(
                name: "IX_StoreMusicRecords_RecordStoreId_RecordId",
                table: "StoreMusicRecord",
                newName: "IX_StoreMusicRecord_RecordStoreId_RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreMusicRecords_RecordId",
                table: "StoreMusicRecord",
                newName: "IX_StoreMusicRecord_RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_RecordStoreId",
                table: "Rating",
                newName: "IX_Rating_RecordStoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_RatedByPersonId",
                table: "Rating",
                newName: "IX_Rating_RatedByPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_MusicRecordId",
                table: "Rating",
                newName: "IX_Rating_MusicRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonMusicRecords_RecordId",
                table: "PersonMusicRecord",
                newName: "IX_PersonMusicRecord_RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonMusicRecords_PersonId",
                table: "PersonMusicRecord",
                newName: "IX_PersonMusicRecord_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreMusicRecord",
                table: "StoreMusicRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonMusicRecord",
                table: "PersonMusicRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMusicRecord_People_PersonId",
                table: "PersonMusicRecord",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMusicRecord_StoreMusicRecord_RecordId",
                table: "PersonMusicRecord",
                column: "RecordId",
                principalTable: "StoreMusicRecord",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_MusicRecords_MusicRecordId",
                table: "Rating",
                column: "MusicRecordId",
                principalTable: "MusicRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_People_RatedByPersonId",
                table: "Rating",
                column: "RatedByPersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_RecordStores_RecordStoreId",
                table: "Rating",
                column: "RecordStoreId",
                principalTable: "RecordStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreMusicRecord_MusicRecords_RecordId",
                table: "StoreMusicRecord",
                column: "RecordId",
                principalTable: "MusicRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreMusicRecord_RecordStores_RecordStoreId",
                table: "StoreMusicRecord",
                column: "RecordStoreId",
                principalTable: "RecordStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
