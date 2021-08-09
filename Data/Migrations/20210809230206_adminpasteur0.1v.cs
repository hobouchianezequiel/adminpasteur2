using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPasteur.Data.Migrations
{
    public partial class adminpasteur01v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Cuit = table.Column<long>(nullable: false),
                    PrestadorNumber = table.Column<long>(nullable: false),
                    ConsultingRoom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayRoll",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AffiliateId = table.Column<int>(nullable: true),
                    DoctorId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    CodPrest = table.Column<long>(nullable: false),
                    Trans = table.Column<string>(nullable: true),
                    AuthorizationNumber = table.Column<long>(nullable: false),
                    Diagnosis = table.Column<string>(nullable: true),
                    Coseg = table.Column<long>(nullable: false),
                    InvoicedPeriod = table.Column<DateTime>(nullable: false),
                    ConsultingRoom = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(nullable: true),
                    Amount = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayRoll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayRoll_Affiliate_AffiliateId",
                        column: x => x.AffiliateId,
                        principalTable: "Affiliate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayRoll_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayRoll_AffiliateId",
                table: "PayRoll",
                column: "AffiliateId");

            migrationBuilder.CreateIndex(
                name: "IX_PayRoll_DoctorId",
                table: "PayRoll",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayRoll");

            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
