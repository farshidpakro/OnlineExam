using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Data.Migrations
{
    public partial class addexqsstdtodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examlist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examlist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Qs = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Anone = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Antwo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Anthree = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Anfour = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Qskey = table.Column<int>(nullable: false),
                    Examlistid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Examlist_Examlistid",
                        column: x => x.Examlistid,
                        principalTable: "Examlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Studentnum = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Examlistid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Examlist_Examlistid",
                        column: x => x.Examlistid,
                        principalTable: "Examlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Examlistid",
                table: "Questions",
                column: "Examlistid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Examlistid",
                table: "Students",
                column: "Examlistid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Examlist");
        }
    }
}
