using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Simple.AuthorizationPro.Migrations.AuthorizationPro
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiResource",
                columns: table => new
                {
                    ApiResourceId = table.Column<string>(maxLength: 36, nullable: false),
                    BaseUrl = table.Column<string>(maxLength: 128, nullable: false),
                    Parameters = table.Column<string>(maxLength: 128, nullable: true),
                    Method = table.Column<string>(maxLength: 12, nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    IsValid = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResource", x => x.ApiResourceId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 36, nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    IsValid = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "RoleApiResourceRelation",
                columns: table => new
                {
                    RoleId = table.Column<string>(nullable: false),
                    ApiResourceId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleApiResourceRelation", x => new { x.RoleId, x.ApiResourceId });
                    table.ForeignKey(
                        name: "FK_RoleApiResourceRelation_ApiResource_ApiResourceId",
                        column: x => x.ApiResourceId,
                        principalTable: "ApiResource",
                        principalColumn: "ApiResourceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleApiResourceRelation_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleApiResourceRelation_ApiResourceId",
                table: "RoleApiResourceRelation",
                column: "ApiResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleApiResourceRelation");

            migrationBuilder.DropTable(
                name: "ApiResource");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
