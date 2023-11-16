using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSVParser.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sqliteDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RightAscension = table.Column<double>(type: "REAL", nullable: false),
                    Declination = table.Column<double>(type: "REAL", nullable: false),
                    DistanceFromSolInParsecs = table.Column<double>(type: "REAL", nullable: false),
                    ProperMotionRightAscension = table.Column<double>(type: "REAL", nullable: false),
                    ProperMotionDeclination = table.Column<double>(type: "REAL", nullable: false),
                    RadialVelocityKmPerSecond = table.Column<double>(type: "REAL", nullable: false),
                    V_Magnitude = table.Column<double>(type: "REAL", nullable: false),
                    AbsoluteMagnitude = table.Column<double>(type: "REAL", nullable: false),
                    MKSpectralType = table.Column<string>(type: "TEXT", nullable: false),
                    ColorIndex = table.Column<string>(type: "TEXT", nullable: false),
                    Luminosity = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stars");
        }
    }
}
