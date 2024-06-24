using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Venda
    {
        private int id { get; set; }
        List<Produto> produtos { get; set; } 
        private string Usuario { get; set; }
        private int DataVenda { get; set; }
        private double ValorTotal { get; set; }

        public Venda(int id, string usuario, int datavenda, double valortotal)
        {
            this.id = id;
            this.DataVenda = datavenda;
            this.Usuario = usuario;
            this.ValorTotal = valortotal;
        }

    }
}
