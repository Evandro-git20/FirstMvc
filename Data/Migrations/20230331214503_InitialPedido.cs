using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FistMvc.Data.Migrations
{
    public partial class InitialPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "Pedidos",
                newName: "Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cliente",
                table: "Pedidos",
                newName: "User");
        }
    }
}
