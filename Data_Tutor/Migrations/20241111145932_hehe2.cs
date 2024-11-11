using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Tutor.Migrations
{
    /// <inheritdoc />
    public partial class hehe2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GHCTs_GioHangs_GioHangId",
                table: "GHCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_GHCTs_SanPhams_SanPhamId",
                table: "GHCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_GioHangs_Users_UserId",
                table: "GioHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDCTs_HoaDons_HoaDonId",
                table: "HDCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDCTs_SanPhams_SanPhamId",
                table: "HDCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_Users_UserId",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_GioHangs_UserId",
                table: "GioHangs");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalMoney",
                table: "HoaDons",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "HoaDons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SoldDate",
                table: "HoaDons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalMoney",
                table: "HDCTs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "SanPhamId",
                table: "HDCTs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "HoaDonId",
                table: "HDCTs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "GioHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "GioHangs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "SoLuong",
                table: "GHCTs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SanPhamId",
                table: "GHCTs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "GioHangId",
                table: "GHCTs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_UserId",
                table: "GioHangs",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_GHCTs_GioHangs_GioHangId",
                table: "GHCTs",
                column: "GioHangId",
                principalTable: "GioHangs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHCTs_SanPhams_SanPhamId",
                table: "GHCTs",
                column: "SanPhamId",
                principalTable: "SanPhams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GioHangs_Users_UserId",
                table: "GioHangs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDCTs_HoaDons_HoaDonId",
                table: "HDCTs",
                column: "HoaDonId",
                principalTable: "HoaDons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDCTs_SanPhams_SanPhamId",
                table: "HDCTs",
                column: "SanPhamId",
                principalTable: "SanPhams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_Users_UserId",
                table: "HoaDons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GHCTs_GioHangs_GioHangId",
                table: "GHCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_GHCTs_SanPhams_SanPhamId",
                table: "GHCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_GioHangs_Users_UserId",
                table: "GioHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDCTs_HoaDons_HoaDonId",
                table: "HDCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDCTs_SanPhams_SanPhamId",
                table: "HDCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_Users_UserId",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_GioHangs_UserId",
                table: "GioHangs");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalMoney",
                table: "HoaDons",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "HoaDons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SoldDate",
                table: "HoaDons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalMoney",
                table: "HDCTs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SanPhamId",
                table: "HDCTs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HoaDonId",
                table: "HDCTs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "GioHangs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "GioHangs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SoLuong",
                table: "GHCTs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SanPhamId",
                table: "GHCTs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GioHangId",
                table: "GHCTs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_UserId",
                table: "GioHangs",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GHCTs_GioHangs_GioHangId",
                table: "GHCTs",
                column: "GioHangId",
                principalTable: "GioHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GHCTs_SanPhams_SanPhamId",
                table: "GHCTs",
                column: "SanPhamId",
                principalTable: "SanPhams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GioHangs_Users_UserId",
                table: "GioHangs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDCTs_HoaDons_HoaDonId",
                table: "HDCTs",
                column: "HoaDonId",
                principalTable: "HoaDons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDCTs_SanPhams_SanPhamId",
                table: "HDCTs",
                column: "SanPhamId",
                principalTable: "SanPhams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_Users_UserId",
                table: "HoaDons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
