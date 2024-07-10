using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public  class Cupom
    {
        private string Codigo_Cupom { get; set; }

        public Cupom(string cod_cupom)
        { 
            Codigo_Cupom= cod_cupom;
        }

        public string PegarCupom()
        {
            return Codigo_Cupom;
        }


    }
}
