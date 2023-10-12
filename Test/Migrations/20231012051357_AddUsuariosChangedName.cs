using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class AddUsuariosChangedName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_CARGO_IdCargo",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_DEPARTAMENTO_IdDepartamento",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "USUARIOS");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdDepartamento",
                table: "USUARIOS",
                newName: "IX_USUARIOS_IdDepartamento");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdCargo",
                table: "USUARIOS",
                newName: "IX_USUARIOS_IdCargo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USUARIOS",
                table: "USUARIOS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOS_CARGO_IdCargo",
                table: "USUARIOS",
                column: "IdCargo",
                principalTable: "CARGO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOS_DEPARTAMENTO_IdDepartamento",
                table: "USUARIOS",
                column: "IdDepartamento",
                principalTable: "DEPARTAMENTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOS_CARGO_IdCargo",
                table: "USUARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOS_DEPARTAMENTO_IdDepartamento",
                table: "USUARIOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USUARIOS",
                table: "USUARIOS");

            migrationBuilder.RenameTable(
                name: "USUARIOS",
                newName: "Usuarios");

            migrationBuilder.RenameIndex(
                name: "IX_USUARIOS_IdDepartamento",
                table: "Usuarios",
                newName: "IX_Usuarios_IdDepartamento");

            migrationBuilder.RenameIndex(
                name: "IX_USUARIOS_IdCargo",
                table: "Usuarios",
                newName: "IX_Usuarios_IdCargo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_CARGO_IdCargo",
                table: "Usuarios",
                column: "IdCargo",
                principalTable: "CARGO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_DEPARTAMENTO_IdDepartamento",
                table: "Usuarios",
                column: "IdDepartamento",
                principalTable: "DEPARTAMENTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
