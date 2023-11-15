using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSVParser.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialSQLiteDBCreate : Migration
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
                    RightAscension = table.Column<float>(type: "REAL", nullable: true),
                    Declination = table.Column<float>(type: "REAL", nullable: true),
                    DistanceFromSolInParsecs = table.Column<float>(type: "REAL", nullable: true),
                    ProperMotionRightAscension = table.Column<float>(type: "REAL", nullable: true),
                    ProperMotionDeclination = table.Column<float>(type: "REAL", nullable: true),
                    RadialVelocityKmPerSecond = table.Column<float>(type: "REAL", nullable: true),
                    V_Magnitude = table.Column<float>(type: "REAL", nullable: true),
                    AbsoluteMagnitude = table.Column<float>(type: "REAL", nullable: true),
                    MKSpectralType = table.Column<string>(type: "TEXT", nullable: true),
                    ColorIndex = table.Column<float>(type: "REAL", nullable: true),
                    Luminosity = table.Column<float>(type: "REAL", nullable: true)
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
