using System;
using ProyectoAlmacen.Models;
using ProyectoAlmacen.Services;

class Program
{
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n===== SISTEMA DE INVENTARIO =====");
            Console.WriteLine("1. Agregar Producto Electrónico");
            Console.WriteLine("2. Agregar Producto Alimenticio");
            Console.WriteLine("3. Listar Productos");
            Console.WriteLine("4. Eliminar Producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("ID: ");
                    int idE = int.Parse(Console.ReadLine());

                    Console.Write("Nombre: ");
                    string nombreE = Console.ReadLine();

                    Console.Write("Cantidad: ");
                    int cantidadE = int.Parse(Console.ReadLine());

                    Console.Write("Precio: ");
                    decimal precioE = decimal.Parse(Console.ReadLine());

                    Console.Write("Garantía (meses): ");
                    int garantia = int.Parse(Console.ReadLine());

                    ProductoElectronico pe = new ProductoElectronico(idE, nombreE, cantidadE, precioE, garantia);
                    inventario.AgregarProducto(pe);
                    break;

                case "2":
                    Console.Write("ID: ");
                    int idA = int.Parse(Console.ReadLine());

                    Console.Write("Nombre: ");
                    string nombreA = Console.ReadLine();

                    Console.Write("Cantidad: ");
                    int cantidadA = int.Parse(Console.ReadLine());

                    Console.Write("Precio: ");
                    decimal precioA = decimal.Parse(Console.ReadLine());

                    Console.Write("Fecha de vencimiento (yyyy-mm-dd): ");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());

                    ProductoAlimenticio pa = new ProductoAlimenticio(idA, nombreA, cantidadA, precioA, fecha);
                    inventario.AgregarProducto(pa);
                    break;

                case "3":
                    inventario.ListarProductos();
                    break;

                case "4":
                    Console.Write("ID a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    inventario.EliminarProducto(idEliminar);
                    break;

                case "5":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
