using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectAndSellSupport.Domain.Migrations
{
    public partial class TDNCArchive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_Dnc_Archive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientCompanyID = table.Column<int>(type: "int", nullable: false),
                    ContactCompany = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ContactNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getutcdate())"),
                    CreateUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('Administrator')"),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getutcdate())"),
                    ModUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('Administrator')"),
                    Country = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContactName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ContactTitle = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValueSql: "('')"),
                    ContactCountry = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ReasonMessage = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    Pitcher = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Agent = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    DNCType = table.Column<int>(type: "int", nullable: false),
                    DNCExpires = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('2000-01-01')"),
                    ClientCompany = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ArchiveDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getutcdate())"),
                    ArchiveUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Dnc_Archive", x => x.ID);
                    table.ForeignKey(
                        name: "FK_t_Dnc_Archive_t_ArchiveUserID",
                        column: x => x.ArchiveUserID,
                        principalTable: "t_User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_Dnc_Archive_t_Company",
                        column: x => x.ClientCompanyID,
                        principalTable: "t_Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_Dnc_Archive_ArchiveUserID",
                table: "t_Dnc_Archive",
                column: "ArchiveUserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_Dnc_Archive_ClientCompanyID",
                table: "t_Dnc_Archive",
                column: "ClientCompanyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_Dnc_Archive");
        }
    }
}
