
namespace Estoque.Models;

public class EstoqueLoja
{
    public List<Produto> Produtos { get; set; }

    public EstoqueLoja()
    {
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
    }

    public void RemoverProdutoPeloNome(string nome)
    {
        var produto = BuscarProdutoPeloNome(nome);
        if (produto != null)
        {
            Produtos.Remove(produto);
        }
        else
        {
            throw new Exception("Produto não encontrado");
        }
    }

    public Produto BuscarProdutoPeloNome(string nome)
    {
        return Produtos.FirstOrDefault(p => p.Nome == nome);
    }

    public int ContarProdutos()
    {
        int soma = 0;
        foreach (var produto in Produtos)
        {
            soma += produto.Quantidade;
        }

        return soma;
    }
}

