using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaCine1
{
    internal class Funcion
    {
        private Pelicula peliculaFuncion;
        private Sala salaFuncion;
        Dictionary<String,String> clientesFuncion = new Dictionary<String,String>();

        public Funcion(Pelicula peliculaFuncion, Sala salaFuncion)
        {
            this.peliculaFuncion = peliculaFuncion;
            this.salaFuncion = salaFuncion;
        }

        public void agregarClienteAFuncion(Cliente cliente)
        {
            String clave = cliente.generoDniCliente + cliente.dniCliente;
            String valor = cliente.nombreCliente + " " + cliente.apellidoCliente;

            this.clientesFuncion.Add(clave, valor);
        }

    }
}
