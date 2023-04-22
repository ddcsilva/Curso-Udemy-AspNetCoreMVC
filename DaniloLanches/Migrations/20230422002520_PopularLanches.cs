using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaniloLanches.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, LanchePreferido, EmEstoque) VALUES (1, 'Hambúrguer Clássico', 'Hambúrguer com alface, queijo e tomate', 'Hambúrguer com pão, alface, queijo, tomate, carne e molho especial', 4.95, 'https://l1nq.com/HTJsc', 'https://l1nq.com/HTJsc', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, LanchePreferido, EmEstoque) VALUES (1, 'X-Salada', 'Hambúrguer com alface e tomate', 'Hambúrguer com pão, alface, tomate, carne e molho especial', 5.95, 'https://l1nq.com/oSfDw', 'https://l1nq.com/oSfDw', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, LanchePreferido, EmEstoque) VALUES (1, 'X-Bacon', 'Hambúrguer com bacon', 'Hambúrguer com pão, bacon, carne e molho especial', 6.95, 'https://l1nq.com/c1THE', 'https://l1nq.com/c1THE', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, LanchePreferido, EmEstoque) VALUES (2, 'Coca-Cola', 'Refrigerante de cola', 'Refrigerante de cola', 2.95, 'https://l1nq.com/lBOkX', 'https://l1nq.com/lBOkX', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, LanchePreferido, EmEstoque) VALUES (2, 'Guaraná Antártica', 'Refrigerante de guaraná', 'Refrigerante de guaraná', 2.95, 'https://l1nq.com/qQcvk', 'https://l1nq.com/qQcvk', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, LanchePreferido, EmEstoque) VALUES (2, 'Fanta Uva', 'Refrigerante de uva', 'Refrigerante de uva', 2.95, 'https://l1nq.com/LzZXS', 'https://l1nq.com/LzZXS', 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
