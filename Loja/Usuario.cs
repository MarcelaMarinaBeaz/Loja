using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Usuario
    {
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string endereco { get; set; }

        public Usuario(int id, string name, string email, string endereco)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.endereco = endereco;
        }
        public void LoginCliente()
        {

        }
        public void EditarUsuario()
        {

        }
    }
}
