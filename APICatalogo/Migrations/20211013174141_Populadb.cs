using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome) Values('Bebidas')");
            mb.Sql("Insert into Categorias(Nome) Values('Lanches')");
            mb.Sql("Insert into Categorias(Nome) Values('Sobremesa')");

            mb.Sql("Insert into Produtos(Nome, Preco, Estoque, DataCadastro, CategoriaId) Values('Coca Zelo 320ml', '4.00', 1, now()," + "(Select CategoriaId from Categorias where Nome = 'Bebidas'))");
            mb.Sql("Insert into Produtos(Nome, Preco, Estoque, DataCadastro, CategoriaId) Values('Sanduiche de atum', '7.00', 1, now()," + "(Select CategoriaId from Categorias where Nome = 'Lanches'))");
            mb.Sql("Insert into Produtos(Nome, Preco, Estoque, DataCadastro, CategoriaId) Values('Pudim', '6.00', 1, now()," + "(Select CategoriaId from Categorias where Nome = 'Sobremesa'))");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
            mb.Sql("Delete from Produtos");
        }
    }
}
