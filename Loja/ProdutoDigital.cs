using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class ProdutoDigital 
    {
        private double TmArquivo{ get; set; }
        private string Formato { get; set; }


        public ProdutoDigital(double TmArquivo, string Formato)
        {
            this.TmArquivo = TmArquivo;
            this.Formato = Formato;
        }
        public void Lincar()
        {

        }
    }
}
