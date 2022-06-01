using Microsoft.EntityFrameworkCore.Migrations;

namespace BeatLeaderAuth.Data.Migrations
{
    public partial class TransferComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AccountAge = table.Column<int>(type: "int", nullable: false),
                    PlayerHMD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerPlatform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modcount = table.Column<int>(type: "int", nullable: false),
                    LevelsBeaten = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerID);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    SongID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SongLength = table.Column<int>(type: "int", nullable: false),
                    SongBPM = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongID);
                });

            migrationBuilder.CreateTable(
                name: "Beatmap",
                columns: table => new
                {
                    BeatmapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongID = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<int>(type: "int", nullable: false),
                    Walls = table.Column<int>(type: "int", nullable: false),
                    Bombs = table.Column<int>(type: "int", nullable: false),
                    Slash = table.Column<int>(type: "int", nullable: false),
                    MapPlays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beatmap", x => x.BeatmapID);
                    table.ForeignKey(
                        name: "FK_Beatmap_Song_SongID",
                        column: x => x.SongID,
                        principalTable: "Song",
                        principalColumn: "SongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeatmapID = table.Column<int>(type: "int", nullable: false),
                    Multiplier = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    FullCombo = table.Column<bool>(type: "bit", nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreID);
                    table.ForeignKey(
                        name: "FK_Score_Beatmap_BeatmapID",
                        column: x => x.BeatmapID,
                        principalTable: "Beatmap",
                        principalColumn: "BeatmapID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Score_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beatmap_SongID",
                table: "Beatmap",
                column: "SongID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Score_BeatmapID",
                table: "Score",
                column: "BeatmapID");

            migrationBuilder.CreateIndex(
                name: "IX_Score_PlayerID",
                table: "Score",
                column: "PlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Beatmap");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Song");
        }
    }
}
