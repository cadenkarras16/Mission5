using Microsoft.EntityFrameworkCore.Migrations;

namespace DateMe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MajorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    CreeperStalker = table.Column<bool>(nullable: false),
                    MajorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_Responses_Majors_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Majors",
                        principalColumn: "MajorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorName" },
                values: new object[] { 1, "Information Systems" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorName" },
                values: new object[] { 2, "Ancient Near Eastern Studies: Greek New Testament" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorName" },
                values: new object[] { 3, "Accounting" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorName" },
                values: new object[] { 4, "Actuarial Science" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorName" },
                values: new object[] { 5, "Undeclared" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "MajorID", "Phone" },
                values: new object[] { 1, (byte)45, false, "Michael", "Scott", 4, "555-123-4567" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "MajorID", "Phone" },
                values: new object[] { 2, (byte)90, true, "Creed", "Bratton", 5, "123-555-4567" });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_MajorID",
                table: "Responses",
                column: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Majors");
        }
    }
}
