using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevLearningPlannerAndTracker.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    ModuleCode = table.Column<string>(type: "text", nullable: false),
                    ModuleName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.ModuleCode);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "integer", nullable: false),
                    ModuleCode = table.Column<string>(type: "text", nullable: false),
                    TopicName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topics", x => new { x.TopicId, x.ModuleCode });
                    table.ForeignKey(
                        name: "FK_topics_modules_ModuleCode",
                        column: x => x.ModuleCode,
                        principalTable: "modules",
                        principalColumn: "ModuleCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "concepts",
                columns: table => new
                {
                    ConceptId = table.Column<string>(type: "text", nullable: false),
                    ModuleCode = table.Column<string>(type: "text", nullable: false),
                    TopicId = table.Column<int>(type: "integer", nullable: false),
                    ConceptName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concepts", x => x.ConceptId);
                    table.ForeignKey(
                        name: "FK_concepts_topics_TopicId_ModuleCode",
                        columns: x => new { x.TopicId, x.ModuleCode },
                        principalTable: "topics",
                        principalColumns: new[] { "TopicId", "ModuleCode" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userTasks",
                columns: table => new
                {
                    Username = table.Column<string>(type: "text", nullable: false),
                    ConceptId = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Priority = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTasks", x => new { x.Username, x.ConceptId });
                    table.ForeignKey(
                        name: "FK_userTasks_concepts_ConceptId",
                        column: x => x.ConceptId,
                        principalTable: "concepts",
                        principalColumn: "ConceptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userTasks_users_Username",
                        column: x => x.Username,
                        principalTable: "users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_concepts_TopicId_ModuleCode",
                table: "concepts",
                columns: new[] { "TopicId", "ModuleCode" });

            migrationBuilder.CreateIndex(
                name: "IX_topics_ModuleCode",
                table: "topics",
                column: "ModuleCode");

            migrationBuilder.CreateIndex(
                name: "IX_userTasks_ConceptId",
                table: "userTasks",
                column: "ConceptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userTasks");

            migrationBuilder.DropTable(
                name: "concepts");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "topics");

            migrationBuilder.DropTable(
                name: "modules");
        }
    }
}
