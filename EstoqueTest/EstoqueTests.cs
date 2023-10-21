using Estoque.Models;

namespace EstoqueTest
{
    public class EstoqueTests
    {
        [Fact]
        public void TesteContarProdutosComSucesso()
        {
            // Arrange
            Produto prod = new Produto("Arroz", 3, 20.0);
            Produto prod2 = new Produto("Feijão", 2, 10.0);
            EstoqueLoja estoque = new EstoqueLoja();
            // Act
            estoque.AdicionarProduto(prod);
            estoque.AdicionarProduto(prod2);
            // Assert
            Assert.Equal(5, estoque.ContarProdutos());
        }

        [Fact]
        public void TesteAdicaoProdutoComSucesso()
        {   
            // Arrange
             Produto prod = new Produto("Arroz", 3, 20.0);
             EstoqueLoja estoque = new EstoqueLoja();
            // Act
             estoque.AdicionarProduto(prod);
            // Assert
             Assert.Equal(3, estoque.ContarProdutos());

        }

        [Fact]
        public void TesteRemocaoProdutoComSucesso()
        {
            // Arrange
            Produto prod = new Produto("Arroz", 3, 20.0);
            Produto prod2 = new Produto("Feijão", 2, 10.0);
            EstoqueLoja estoque = new EstoqueLoja();
            // Act
            estoque.AdicionarProduto(prod);
            estoque.AdicionarProduto(prod2);
            estoque.RemoverProduto(prod);
            // Assert
            Assert.Equal(2, estoque.ContarProdutos());
        }

        [Fact]
        public void TesteRemocaoProdutoPeloNomeComSucesso()
        {
            // Arrange
            Produto prod = new Produto("Arroz", 3, 20.0);
            Produto prod2 = new Produto("Feijão", 2, 10.0);
            EstoqueLoja estoque = new EstoqueLoja();
            // Act
            estoque.AdicionarProduto(prod);
            estoque.AdicionarProduto(prod2);
            estoque.RemoverProdutoPeloNome("Arroz");
            // Assert
            Assert.Equal(2, estoque.ContarProdutos());
        }

        [Fact]
        public void TestarProdutoNaoEncontrado()
        {
            // Arrange
            Produto prod = new Produto("Arroz", 3, 20.0);
            Produto prod2 = new Produto("Feijão", 2, 10.0);
            EstoqueLoja estoque = new EstoqueLoja();
            // Act
            estoque.AdicionarProduto(prod);
            estoque.AdicionarProduto(prod2);
            // Assert
            Assert.Throws<Exception>(() => estoque.RemoverProdutoPeloNome("Macarrão"));
        }   

    }
}