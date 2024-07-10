using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Cupom
    {
        private string CodigoCupom { get; set; }
        private int  Id { get; set; }
    public Cupom(int id, string codCupom)
        {
            Id = id;
            CodigoCupom = codCupom;

        }

        public int PegarID()
        {
            return Id;
        }

        public string PegarCupom()
        {
            return CodigoCupom;
        }

        public void ExibirCupomDisponivel()
        {
            Console.WriteLine($"--------------- Cupom {Id} ---------------" +
                              $"\nCodigo de Cupom Valido: {CodigoCupom}" +
                              $"\n----------------------------------------");
        }

    }
}
