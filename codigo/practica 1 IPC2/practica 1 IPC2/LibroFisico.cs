using System;
using System.Collections.Generic;
using System.Text;

namespace practica_1_IPC2
{
    public class LibroFisico : MaterialBiblioteca
    {
        private int NumEjemplar;

        public LibroFisico(string titulo, string autor, int numEjemplar) : base(titulo, autor)
        {
            this.NumEjemplar=numEjemplar;
        }

        public override int DiasPrestamo()
        {
            return 7;
        }

        public override void MostrarInformacion() 
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Estado: {(prestamo ? "Prestado" : "Disponible")}");
            Console.WriteLine($"Número de ejemplar:{NumEjemplar}");
            Console.WriteLine("Tipo: Libro Físico");
            Console.WriteLine("Tiempo máximo: 7 días");
        }

    }
}
