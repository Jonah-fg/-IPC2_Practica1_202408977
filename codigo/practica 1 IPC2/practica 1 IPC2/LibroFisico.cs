using System;
using System.Collections.Generic;
using System.Text;

namespace practica_1_IPC2
{
    internal class LibroFisico : MaterialBiblioteca
    {
        private int NumEjemplar;

        public LibroFisico(string titulo, string autor, int numEjemplar) : base(titulo, autor)
        {
            this.NumEjemplar = numEjemplar;
        }
        public void mostrarInformacion() 
        {
           base.mostrarInformacion();
           Console.WriteLine($"Número de ejemplar: {NumEjemplar}");
           Console.WriteLine("Tiempo macimo de prestamo: 7 dias");
        }

    }
}
