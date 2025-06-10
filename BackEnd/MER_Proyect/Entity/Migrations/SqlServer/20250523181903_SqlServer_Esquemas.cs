using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class SqlServer_Esquemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "username",
                schema: "segurity",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                schema: "segurity",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                schema: "segurity",
                table: "User",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "User",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "roluser",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "roluser",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "rolformpermission",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "rolformpermission",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "rol",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "rol",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "rol",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "rol",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "phonenumber",
                schema: "persons",
                table: "person",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                schema: "persons",
                table: "person",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "firstname",
                schema: "persons",
                table: "person",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "persons",
                table: "person",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "persons",
                table: "person",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "Permission",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "Permission",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "Permission",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "Permission",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "Module",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "Module",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "Module",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "Module",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "formmodule",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "formmodule",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "form",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "form",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                schema: "segurity",
                table: "form",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "form",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Module",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 3,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 4,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 5,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 6,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 7,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "User",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 3,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 4,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 5,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 6,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 7,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 8,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 9,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "formmodule",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "persons",
                table: "person",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "persons",
                table: "person",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 3,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 4,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 5,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 6,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 7,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 8,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 9,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 10,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 11,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 12,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 13,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 14,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 15,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 16,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 17,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 18,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 19,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 20,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 21,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 22,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 23,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 24,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 25,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 26,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 27,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 28,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 29,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 30,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 31,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 32,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 33,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 34,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 35,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 36,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 37,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 38,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 39,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 40,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 41,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 42,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 43,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 44,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 45,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 46,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 47,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 48,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 49,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 50,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 51,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 52,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 53,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 54,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 55,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 56,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 57,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 58,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 59,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 60,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 61,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 62,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 63,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 64,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 65,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 66,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 67,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 68,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 69,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 70,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 71,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 72,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 73,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 74,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 75,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 76,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 77,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 78,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 79,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 80,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 81,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 82,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 83,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 84,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 85,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 86,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 87,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 88,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 89,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 90,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 91,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 92,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 93,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 94,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 95,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 96,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 97,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 98,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 99,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 100,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 101,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 102,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 103,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 104,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 105,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 106,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 107,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 108,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "roluser",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "roluser",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "username",
                schema: "segurity",
                table: "User",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                schema: "segurity",
                table: "User",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                schema: "segurity",
                table: "User",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "User",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "roluser",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "roluser",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "rolformpermission",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "rolformpermission",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "rol",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "rol",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "rol",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "rol",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "phonenumber",
                schema: "persons",
                table: "person",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                schema: "persons",
                table: "person",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "firstname",
                schema: "persons",
                table: "person",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "persons",
                table: "person",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "persons",
                table: "person",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "Permission",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "Permission",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "Permission",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "Permission",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "Module",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "Module",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "Module",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "Module",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "formmodule",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "formmodule",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "segurity",
                table: "form",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "segurity",
                table: "form",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<byte>(
                name: "active",
                schema: "segurity",
                table: "form",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                schema: "segurity",
                table: "form",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Module",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 3,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 4,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 5,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 6,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "Permission",
                keyColumn: "id",
                keyValue: 7,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "User",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 3,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 4,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 5,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 6,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 7,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 8,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "form",
                keyColumn: "id",
                keyValue: 9,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "formmodule",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "persons",
                table: "person",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "persons",
                table: "person",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 3,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 4,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 5,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 6,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 7,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 8,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 9,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 10,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 11,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 12,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 13,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 14,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 15,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 16,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 17,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 18,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 19,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 20,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 21,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 22,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 23,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 24,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 25,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 26,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 27,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 28,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 29,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 30,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 31,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 32,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 33,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 34,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 35,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 36,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 37,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 38,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 39,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 40,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 41,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 42,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 43,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 44,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 45,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 46,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 47,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 48,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 49,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 50,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 51,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 52,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 53,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 54,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 55,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 56,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 57,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 58,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 59,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 60,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 61,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 62,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 63,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 64,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 65,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 66,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 67,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 68,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 69,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 70,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 71,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 72,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 73,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 74,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 75,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 76,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 77,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 78,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 79,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 80,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 81,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 82,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 83,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 84,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 85,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 86,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 87,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 88,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 89,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 90,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 91,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 92,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 93,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 94,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 95,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 96,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 97,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 98,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 99,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 100,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 101,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 102,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 103,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 104,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 105,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 106,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 107,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "rolformpermission",
                keyColumn: "id",
                keyValue: 108,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "roluser",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "segurity",
                table: "roluser",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: (byte)1);
        }
    }
}
