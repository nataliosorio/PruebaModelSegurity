using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entity.Migrations.PostgreSql
{
    /// <inheritdoc />
    public partial class Pg_SistemaCitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "segurity");

            migrationBuilder.EnsureSchema(
                name: "persons");

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCompleto = table.Column<string>(type: "text", nullable: false),
                    Especialidad = table.Column<string>(type: "text", nullable: false),
                    NumeroDeColegiado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "form",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_form", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCompleto = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Genero = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "person",
                schema: "persons",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    lastname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    phonenumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formmodule",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    formid = table.Column<int>(type: "integer", nullable: false),
                    moduleid = table.Column<int>(type: "integer", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formmodule", x => x.id);
                    table.ForeignKey(
                        name: "FK_FormModule_Form",
                        column: x => x.formid,
                        principalSchema: "segurity",
                        principalTable: "form",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Module_FormModules",
                        column: x => x.moduleid,
                        principalSchema: "segurity",
                        principalTable: "Module",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaHora = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MotivoConsulta = table.Column<string>(type: "text", nullable: false),
                    PacienteId = table.Column<int>(type: "integer", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cita_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cita_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    personid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_Person_User",
                        column: x => x.personid,
                        principalSchema: "persons",
                        principalTable: "person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rolformpermission",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rolid = table.Column<int>(type: "integer", nullable: false),
                    formid = table.Column<int>(type: "integer", nullable: false),
                    permissionid = table.Column<int>(type: "integer", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolformpermission", x => x.id);
                    table.ForeignKey(
                        name: "FK_RolFormPermission_Form",
                        column: x => x.formid,
                        principalSchema: "segurity",
                        principalTable: "form",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolFormPermission_Permission",
                        column: x => x.permissionid,
                        principalSchema: "segurity",
                        principalTable: "Permission",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolFormPermission_Rol",
                        column: x => x.rolid,
                        principalSchema: "segurity",
                        principalTable: "rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "roluser",
                schema: "segurity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rolid = table.Column<int>(type: "integer", nullable: false),
                    userid = table.Column<int>(type: "integer", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roluser", x => x.id);
                    table.ForeignKey(
                        name: "FK_RolUser_Rol",
                        column: x => x.rolid,
                        principalSchema: "segurity",
                        principalTable: "rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolUser_User",
                        column: x => x.userid,
                        principalSchema: "segurity",
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "Module",
                columns: new[] { "id", "active", "description", "name" },
                values: new object[] { 1, true, "Módulo de gestión", "Gestión" });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "Permission",
                columns: new[] { "id", "active", "description", "name" },
                values: new object[,]
                {
                    { 1, true, "Permiso para ver todos los registros", "GetAll" },
                    { 2, true, "Permiso para ver por id", "GetById" },
                    { 3, true, "Permiso para crear un registro", "Create" },
                    { 4, true, "Permiso para actualizar un registro", "Update" },
                    { 5, true, "Permiso para eliminar logicamente un registro", "DeleteLogic" },
                    { 6, true, "Permiso para eliminar permanentemente un registro", "Delete" },
                    { 7, true, "Permiso para recuperar un registro", "RecoverLogic" }
                });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "form",
                columns: new[] { "id", "active", "description", "name" },
                values: new object[,]
                {
                    { 1, true, "Formulario para lols Roles", "Rol" },
                    { 2, true, "Formulario para los Permisos", "Permission" },
                    { 3, true, "Formulario para las Personas", "Person" },
                    { 4, true, "Formulario de usuarios", "User" },
                    { 5, true, "Formulario para los modulos", "Module" },
                    { 6, true, "Formulario para los form", "FormControllerPrueba" },
                    { 7, true, "Formulario para los roles que tiene cada usuario", "RolUser" },
                    { 8, true, "Formulario para los formularios que pertenecen a cada modulo", "FormModule" },
                    { 9, true, "Formulario para los roles,formularios y permisos", "RolFormPermission" }
                });

            migrationBuilder.InsertData(
                schema: "persons",
                table: "person",
                columns: new[] { "id", "active", "firstname", "lastname", "phonenumber" },
                values: new object[,]
                {
                    { 1, true, "Admin", "Principal", "111111111" },
                    { 2, true, "Usuario", "Demo", "222222222" }
                });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "rol",
                columns: new[] { "id", "active", "description", "name" },
                values: new object[,]
                {
                    { 1, true, "Rol de administrador", "Administrador" },
                    { 2, true, "Rol de usuario estándar", "Usuario" }
                });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "User",
                columns: new[] { "id", "active", "email", "password", "personid", "username" },
                values: new object[,]
                {
                    { 1, true, "natiosoriopoveda@gmail.com", "pecas", 1, "admin" },
                    { 2, true, "marthapoveda579@gmail.com", "usuario123", 2, "usuario" }
                });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "formmodule",
                columns: new[] { "id", "active", "formid", "moduleid" },
                values: new object[] { 1, true, 1, 1 });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "rolformpermission",
                columns: new[] { "id", "active", "formid", "permissionid", "rolid" },
                values: new object[,]
                {
                    { 1, true, 1, 1, 1 },
                    { 2, true, 1, 2, 1 },
                    { 3, true, 1, 3, 1 },
                    { 4, true, 1, 4, 1 },
                    { 5, true, 1, 5, 1 },
                    { 6, true, 1, 6, 1 },
                    { 7, true, 1, 7, 1 },
                    { 8, true, 1, 1, 2 },
                    { 9, true, 1, 2, 2 },
                    { 10, true, 1, 3, 2 },
                    { 11, true, 1, 4, 2 },
                    { 12, true, 1, 5, 2 },
                    { 13, true, 2, 1, 1 },
                    { 14, true, 2, 2, 1 },
                    { 15, true, 2, 3, 1 },
                    { 16, true, 2, 4, 1 },
                    { 17, true, 2, 5, 1 },
                    { 18, true, 2, 6, 1 },
                    { 19, true, 2, 7, 1 },
                    { 20, true, 2, 1, 2 },
                    { 21, true, 2, 2, 2 },
                    { 22, true, 2, 3, 2 },
                    { 23, true, 2, 4, 2 },
                    { 24, true, 2, 5, 2 },
                    { 25, true, 3, 1, 1 },
                    { 26, true, 3, 2, 1 },
                    { 27, true, 3, 3, 1 },
                    { 28, true, 3, 4, 1 },
                    { 29, true, 3, 5, 1 },
                    { 30, true, 3, 6, 1 },
                    { 31, true, 3, 7, 1 },
                    { 32, true, 3, 1, 2 },
                    { 33, true, 3, 2, 2 },
                    { 34, true, 3, 3, 2 },
                    { 35, true, 3, 4, 2 },
                    { 36, true, 3, 5, 2 },
                    { 37, true, 4, 1, 1 },
                    { 38, true, 4, 2, 1 },
                    { 39, true, 4, 3, 1 },
                    { 40, true, 4, 4, 1 },
                    { 41, true, 4, 5, 1 },
                    { 42, true, 4, 6, 1 },
                    { 43, true, 4, 7, 1 },
                    { 44, true, 4, 1, 2 },
                    { 45, true, 4, 2, 2 },
                    { 46, true, 4, 3, 2 },
                    { 47, true, 4, 4, 2 },
                    { 48, true, 4, 5, 2 },
                    { 49, true, 5, 1, 1 },
                    { 50, true, 5, 2, 1 },
                    { 51, true, 5, 3, 1 },
                    { 52, true, 5, 4, 1 },
                    { 53, true, 5, 5, 1 },
                    { 54, true, 5, 6, 1 },
                    { 55, true, 5, 7, 1 },
                    { 56, true, 5, 1, 2 },
                    { 57, true, 5, 2, 2 },
                    { 58, true, 5, 3, 2 },
                    { 59, true, 5, 4, 2 },
                    { 60, true, 5, 5, 2 },
                    { 61, true, 6, 1, 1 },
                    { 62, true, 6, 2, 1 },
                    { 63, true, 6, 3, 1 },
                    { 64, true, 6, 4, 1 },
                    { 65, true, 6, 5, 1 },
                    { 66, true, 6, 6, 1 },
                    { 67, true, 6, 7, 1 },
                    { 68, true, 6, 1, 2 },
                    { 69, true, 6, 2, 2 },
                    { 70, true, 6, 3, 2 },
                    { 71, true, 6, 4, 2 },
                    { 72, true, 6, 5, 2 },
                    { 73, true, 7, 1, 1 },
                    { 74, true, 7, 2, 1 },
                    { 75, true, 7, 3, 1 },
                    { 76, true, 7, 4, 1 },
                    { 77, true, 7, 5, 1 },
                    { 78, true, 7, 6, 1 },
                    { 79, true, 7, 7, 1 },
                    { 80, true, 7, 1, 2 },
                    { 81, true, 7, 2, 2 },
                    { 82, true, 7, 3, 2 },
                    { 83, true, 7, 4, 2 },
                    { 84, true, 7, 5, 2 },
                    { 85, true, 8, 1, 1 },
                    { 86, true, 8, 2, 1 },
                    { 87, true, 8, 3, 1 },
                    { 88, true, 8, 4, 1 },
                    { 89, true, 8, 5, 1 },
                    { 90, true, 8, 6, 1 },
                    { 91, true, 8, 7, 1 },
                    { 92, true, 8, 1, 2 },
                    { 93, true, 8, 2, 2 },
                    { 94, true, 8, 3, 2 },
                    { 95, true, 8, 4, 2 },
                    { 96, true, 8, 5, 2 },
                    { 97, true, 9, 1, 1 },
                    { 98, true, 9, 2, 1 },
                    { 99, true, 9, 3, 1 },
                    { 100, true, 9, 4, 1 },
                    { 101, true, 9, 5, 1 },
                    { 102, true, 9, 6, 1 },
                    { 103, true, 9, 7, 1 },
                    { 104, true, 9, 1, 2 },
                    { 105, true, 9, 2, 2 },
                    { 106, true, 9, 3, 2 },
                    { 107, true, 9, 4, 2 },
                    { 108, true, 9, 5, 2 }
                });

            migrationBuilder.InsertData(
                schema: "segurity",
                table: "roluser",
                columns: new[] { "id", "active", "rolid", "userid" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, true, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cita_DoctorId",
                table: "Cita",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_PacienteId",
                table: "Cita",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_formmodule_formid",
                schema: "segurity",
                table: "formmodule",
                column: "formid");

            migrationBuilder.CreateIndex(
                name: "IX_formmodule_moduleid",
                schema: "segurity",
                table: "formmodule",
                column: "moduleid");

            migrationBuilder.CreateIndex(
                name: "IX_rolformpermission_formid",
                schema: "segurity",
                table: "rolformpermission",
                column: "formid");

            migrationBuilder.CreateIndex(
                name: "IX_rolformpermission_permissionid",
                schema: "segurity",
                table: "rolformpermission",
                column: "permissionid");

            migrationBuilder.CreateIndex(
                name: "IX_rolformpermission_rolid",
                schema: "segurity",
                table: "rolformpermission",
                column: "rolid");

            migrationBuilder.CreateIndex(
                name: "IX_roluser_rolid",
                schema: "segurity",
                table: "roluser",
                column: "rolid");

            migrationBuilder.CreateIndex(
                name: "IX_roluser_userid",
                schema: "segurity",
                table: "roluser",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_User_personid",
                schema: "segurity",
                table: "User",
                column: "personid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "formmodule",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "rolformpermission",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "roluser",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Module",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "form",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "Permission",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "rol",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "User",
                schema: "segurity");

            migrationBuilder.DropTable(
                name: "person",
                schema: "persons");
        }
    }
}
