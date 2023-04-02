using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaCine1

{
    internal class Sucursal
    {
        private String calleSucursal;
        private String alturaSucursal;
        private Sala[] salasSucursal;

        public Sucursal(String calleSucursal, String alturaSucursal, Sala[] salasSucursal)
        {
            this.calleSucursal = calleSucursal;
            this.alturaSucursal = alturaSucursal;
            this.salasSucursal = salasSucursal;
        }

    }
}
