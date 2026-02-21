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

            switch (opciones)
            {
                case 1:
                    Console.WriteLine("Titulo: ");
                    String tituloFisico = Console.ReadLine();
                    Console.WriteLine("Autor: ");
                    String autorFisico = Console.ReadLine();
                    Console.WriteLine("Número de ejemplar: ");
                    int num = int.Parse(Console.ReadLine());
                    materiales.Add(new LibroFisico(tituloFisico, autorFisico, num));
                    Console.WriteLine("Libro físico registrado exitosamente.");
                    break;

                case 2:
                    Console.WriteLine("Titulo: ");
                    String tituloDigital = Console.ReadLine();
                    Console.WriteLine("Autor: ");
                    String autorDigital = Console.ReadLine();
                    Console.WriteLine("Tamaño en MB: ");
                    double tamaño = double.Parse(Console.ReadLine());
                    materiales.Add(new LibroDigital(tituloDigital, autorDigital, tamaño));
                    break;

                case 3:
                    if (materiales.Count == 0)
                    {
                        Console.WriteLine("No hay materiales registrados.");
                    }
                    else
                    {
                        foreach (var material in materiales)
                        {
                            material.MostrarInformacion();
                            Console.WriteLine();
                        }
                    }
                    break;


                case 4:
                    Console.Write("Ingrese el código del material: ");
                    string codigoP = Console.ReadLine();

                    bool encontradoP = false;

                    foreach (var material in materiales)
                    {
                        if (material.GetCodigo()==codigoP)
                        {
                            material.prestarMaterial();
                            encontradoP=true;
                            break;
                        }
                    }
                    if (!encontradoP)
                        Console.WriteLine("Material no encontrado.");

                    break;


                case 5:
                    Console.Write("Ingrese el código del material: ");
                    string codigoD =Console.ReadLine();

                    bool encontradoD=false;

                    foreach(var material in materiales)
                    {
                        if (material.GetCodigo()==codigoD)
                        {
                            material.devolverMaterial();
                            encontradoD = true;
                            break;
                        }
                    }
                    if (!encontradoD)
                        Console.WriteLine("Material no encontrado.");
                    break;

                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida, ingrese una opcion valida.");
                    break;
            }

        }
        while (opciones!=6);
    }
}
