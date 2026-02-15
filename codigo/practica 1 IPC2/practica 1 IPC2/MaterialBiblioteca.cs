using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace practica_1_IPC2
{
    public abstract class MaterialBiblioteca
    {
        private String titulo;
        private String autor;
        private String codigo;
        private bool prestamo;
        
        protected MaterialBiblioteca(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.codigo = GenerarCodigo();
            this.prestamo = false;
        }

        public String GenerarCodigo()
        {
            return Random.Shared.Next(1000, 9999);
        }

        public void prestarMaterial() 
        {
            if (!prestamo) 
            {
                Console.WriteLine("Material prestado exitosamente.");
                prestamo = true;
            }
            else 
            {
                Console.WriteLine("El material ya está prestado.");
            }
        }

        public void devolverMaterial() 
        {
            Console.WriteLine("El material fue devuelto exitosamente");
            prestamo=false;
        }

        public void mostrarInformacion() 
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Estado de préstamo: {(prestamo ? "Prestado" : "Disponible")}");
        }
        public string GetCodigo()
        {
            return codigo;
        }
    }
}
 