using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalScheds.Serverce.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInfolist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    UserName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    IsUse = table.Column<int>(nullable: false),
                    LoginName = table.Column<string>(nullable: true),
                    CreatePerson = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfolist", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfolist");
        }
    }
}
