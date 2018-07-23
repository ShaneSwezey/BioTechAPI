using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BioTechAPI.Migrations
{
    public partial class UpdatePositiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Education",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "Qualifications",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "Responsibilites",
                table: "Positions",
                newName: "PositionStatement");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostDate",
                table: "Positions",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Statement = table.Column<string>(nullable: false),
                    PositionFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Education_Positions_PositionFK",
                        column: x => x.PositionFK,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Statement = table.Column<string>(nullable: false),
                    PositionFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experiences_Positions_PositionFK",
                        column: x => x.PositionFK,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    QualificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Statement = table.Column<string>(nullable: false),
                    PositionFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.QualificationId);
                    table.ForeignKey(
                        name: "FK_Qualifications_Positions_PositionFK",
                        column: x => x.PositionFK,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsibilities",
                columns: table => new
                {
                    ResponsibilityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Statement = table.Column<string>(nullable: false),
                    PositionFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibilities", x => x.ResponsibilityId);
                    table.ForeignKey(
                        name: "FK_Responsibilities_Positions_PositionFK",
                        column: x => x.PositionFK,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Education_PositionFK",
                table: "Education",
                column: "PositionFK");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PositionFK",
                table: "Experiences",
                column: "PositionFK");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_PositionFK",
                table: "Qualifications",
                column: "PositionFK");

            migrationBuilder.CreateIndex(
                name: "IX_Responsibilities_PositionFK",
                table: "Responsibilities",
                column: "PositionFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Responsibilities");

            migrationBuilder.RenameColumn(
                name: "PositionStatement",
                table: "Positions",
                newName: "Responsibilites");

            migrationBuilder.AlterColumn<string>(
                name: "PostDate",
                table: "Positions",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Positions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Positions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qualifications",
                table: "Positions",
                nullable: true);
        }
    }
}
