using System;
using System.Collections.Generic;
using System.Text;

namespace practica_1_IPC2
{
    internal class LibroDigital : MaterialBiblioteca
    {
        private double tamañoArchivo;

        public LibroDigital(string titulo, string autor, double tamañoArchivo) : base(titulo, autor)
        {
            this.tamañoArchivo = tamañoArchivo;
        }

        public void MostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Tamaño del archivo: " + tamañoArchivo + " MB");
            Console.WriteLine("Tiempo máximo de préstamo: 3 días");

        }

    }
}
