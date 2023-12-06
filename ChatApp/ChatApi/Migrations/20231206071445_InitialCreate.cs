using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChatApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    SendDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Message", "SendDate", "UserName" },
                values: new object[,]
                {
                    { 1, "Hello Wolrd!!", new DateTime(2023, 12, 6, 10, 14, 45, 30, DateTimeKind.Local).AddTicks(6920), "MOHAMMED" },
                    { 2, "Hi Wolrd!!", new DateTime(2023, 12, 6, 10, 14, 45, 30, DateTimeKind.Local).AddTicks(6934), "Manger" },
                    { 3, "Hello There!!", new DateTime(2023, 12, 6, 10, 14, 45, 30, DateTimeKind.Local).AddTicks(6934), "Fakid" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");
        }
    }
}
