using practica_1_IPC2;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<MaterialBiblioteca> materiales = new List<MaterialBiblioteca>();
        int opciones;
        do 
        {
            Console.WriteLine("\n--- SISTEMA DE BIBLIOTECA ---");
            Console.WriteLine("1. Registrar Libro Físico");
            Console.WriteLine("2. Registrar Libro Digital");
            Console.WriteLine("3. Mostrar Materiales");
            Console.WriteLine("4. Prestar Material");
            Console.WriteLine("5. Devolver Material");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione opción: ");

            opciones = int.Parse(Console.ReadLine());


    }
}
