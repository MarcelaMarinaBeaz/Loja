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
        private double Valor { get; set; }
    public Cupom(int id, string codCupom, double valor)
        {
            Id = id;
            CodigoCupom = codCupom;
          Valor= valor;
        }


        public int PegarID()
        {
            return Id;
        }

        public void AlterarId(int id)
        {
            Id = id;
        }

        public string PegarCupom()
        {
            return CodigoCupom;
        }

        public void ExibirCupomDisponivel()
        {
            Console.WriteLine($"--------------- Cupom {Id} ---------------" +
                              $"\nCupom Valido: {CodigoCupom}" +
                              $"\nValor de desconto: {Valor}"+
                              $"\n----------------------------------------");
        }

        public static void Add(Cupom cupom)
        {
            throw new NotImplementedException();
        }
    }
}
