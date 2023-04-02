using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaCine1
{
    internal class Pelicula
    {
        String tituloPelicula;
        String anioPelicula;
        String directorPelicula;

        public Pelicula(String titulo, String anio, String director) { 
        
            this.tituloPelicula = titulo;
            this.anioPelicula = anio;
            this.directorPelicula = director;
            
        }
    }
}
