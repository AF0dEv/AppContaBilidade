using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistoMovimentosSrJoaquim.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClientEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentos_Clientes_IdClienteId",
                table: "Movimentos");

            migrationBuilder.RenameColumn(
                name: "IdClienteId",
                table: "Movimentos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentos_IdClienteId",
                table: "Movimentos",
                newName: "IX_Movimentos_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentos_Clientes_ClienteId",
                table: "Movimentos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentos_Clientes_ClienteId",
                table: "Movimentos");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Movimentos",
                newName: "IdClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentos_ClienteId",
                table: "Movimentos",
                newName: "IX_Movimentos_IdClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentos_Clientes_IdClienteId",
                table: "Movimentos",
                column: "IdClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
