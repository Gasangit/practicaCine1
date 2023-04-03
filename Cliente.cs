using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaCine1
{
    internal class Cliente
    {

        public String nombreCliente { get;}
        public String apellidoCliente { get; }
        public String dniCliente { get; }
        public String generoDniCliente { get; }

        public Cliente(string nombre, string apellido, string dni, string genero)
        {
            this.nombreCliente = nombre;
            this.apellidoCliente = apellido;
            this.dniCliente = dni;
            this.generoDniCliente = genero;
        }
    }
}
