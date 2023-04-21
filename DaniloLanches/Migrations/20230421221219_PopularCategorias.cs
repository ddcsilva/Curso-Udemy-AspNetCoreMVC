using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaniloLanches.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, Descricao) VALUES ('Bebidas', 'Bebidas geladas, cervejas e refrigerantes')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, Descricao) VALUES ('Lanches', 'Lanches variados')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, Descricao) VALUES ('Sobremesas', 'Sobremesas variadas')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, Descricao) VALUES ('Salgados', 'Salgados variados')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
