using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class ProdutoFisico 
    {
        private double peso { get; set; }
        private string dimensoes { get; set; }

        public ProdutoFisico(double peso, string dimensoes)
        {
            this.peso = peso;
            this.dimensoes= dimensoes;
        }

        private void AdicionarEstoque()
        {

        }
        public void ListarItem()
        {

        }
        private void Quant_estoque()
        {

        }
    }
}
