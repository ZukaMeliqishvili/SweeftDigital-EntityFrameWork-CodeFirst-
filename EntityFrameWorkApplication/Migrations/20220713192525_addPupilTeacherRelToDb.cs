using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWorkApplication.Migrations
{
    public partial class addPupilTeacherRelToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PupilTeacherRel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    PupilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PupilTeacherRel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PupilTeacherRel_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PupilTeacherRel_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PupilTeacherRel_PupilId",
                table: "PupilTeacherRel",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_PupilTeacherRel_TeacherId",
                table: "PupilTeacherRel",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PupilTeacherRel");
        }
    }
}
