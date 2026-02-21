using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace practica_1_IPC2
{
    public abstract class MaterialBiblioteca
    {
        protected String titulo;
        protected String autor;
        protected String codigo;
        protected bool prestamo;
        
        protected MaterialBiblioteca(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.codigo = GenerarCodigo();
            this.prestamo = false;
        }

        public String GenerarCodigo()
        {
            const string caracteres="ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder resultado =new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                resultado.Append(caracteres[random.Next(caracteres.Length)]);
            }
            return resultado.ToString();
        }

        public abstract int DiasPrestamo();

        public virtual void prestarMaterial() 
        {
            if (!prestamo) 
            {
                Console.WriteLine($"Material prestado por{DiasPrestamo()} días.");
                prestamo=true;
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

        public abstract void MostrarInformacion(); 

        public string GetCodigo()
        {
            return codigo;
        }
    }
}
 