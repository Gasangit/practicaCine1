using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaCine1
{
    internal class Prompt
    {

        public static Cliente datosClientePrompt() {

            String nombreClientePrompt;
            String apellidoClientePrompt;
            String dniClientePrompt;
            String generoDniClientePrompt;

            String[] clientePromptArray = new string[4];

            

            while (nombreClientePrompt is null or "")
            {
                Console.WriteLine("<<Ingrese el NOMBRE de usuario : >>");
                nombreClientePrompt = Console.ReadLine();
            }

            while (apellidoClientePrompt is null or "")
            {
                Console.WriteLine("<<Ingrese el APELLIDO de usuario : >>");
                apellidoClientePrompt = Console.ReadLine();
            }

            while (dniClientePrompt is null or "" or dniClientePrompt.Length > 8 or dniClientePrompt.Length < 7)
            {
                Console.WriteLine("<<Ingrese el DNI de usuario : >>");
                dniClientePrompt = Console.ReadLine();
                if (dniClientePrompt.Length is < 7 or > 8) Console.WriteLine("El DNI debe tener 7 u 8 dígitos");
            }

            while (generoDniClientePrompt is null or "")
            {
                Console.WriteLine("<<Ingrese el GENERO de usuario según como figura en el DNI (F (f) o M (m): >>");
                generoDniClientePrompt = Console.ReadLine();
                generoDniClientePrompt = generoDniClientePrompt.ToUpper();
                if (generoDniClientePrompt == null) Console.WriteLine("No ha ingresado el GENERO");
            }





            Cliente cliente = new Cliente(nombreClientePrompt, apellidoClientePrompt, dniClientePrompt, generoDniClientePrompt);

            return cliente;
        }
    }
}
