using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public Produto(string nome, int quantidade, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
