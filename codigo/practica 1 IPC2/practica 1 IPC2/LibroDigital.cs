using System;
using System.Collections.Generic;
using System.Text;

namespace practica_1_IPC2
{
    public class LibroDigital : MaterialBiblioteca
    {
        private double TamañoArchivo;

        public LibroDigital(string titulo, string autor, double tamañoArchivo) : base(titulo, autor)
        {
            this.TamañoArchivo = tamañoArchivo;
        }

        public override int DiasPrestamo()
        {
            return 3;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Estado: {(prestamo ? "Prestado" : "Disponible")}");
            Console.WriteLine($"Tamaño del archivo: {TamañoArchivo} MB");
            Console.WriteLine("Tipo: Libro Digital");
            Console.WriteLine("Tiempo máximo: 3 días");
        }

    }
}
