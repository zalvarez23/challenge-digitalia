using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.Repository.Migrations
{
    public partial class initSurveyCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Survey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SurveyStatus = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    SurveyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    SurveyQuestion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    QuestionScore = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    DateSurveryDetail = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyDetail_Survey_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Survey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyDetail_SurveyId",
                table: "SurveyDetail",
                column: "SurveyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyDetail");

            migrationBuilder.DropTable(
                name: "Survey");
        }
    }
}
