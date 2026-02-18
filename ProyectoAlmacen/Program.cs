using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAlmacen.Models;
using ProyectoAlmacen.Services;

namespace ProyectoAlmacen
{
    internal class Program
    {
        static Inventario inventario = new Inventario();

        static void Main(string[] args)
        {
            bool salir = false; 

            while (!salir) 
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarElectronico();
                        break;

                    case "2":
                        AgregarAlimenticio();
                        break;

                    case "3":
                        inventario.ListarProductos();
                        break;

                    case "4":
                        EliminarProducto();
                        break;

                    case "5":
                        salir = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Elija del 1 al 5");
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Sistema de inventario:");
            Console.WriteLine("1. Agregar producto electrónico");
            Console.WriteLine("2. Agregar producto alimenticio");
            Console.WriteLine("3. Listar productos.");
            Console.WriteLine("4. Eliminar Producto");
            Console.WriteLine("5. Salir");
        }

        static int LeerEntero(string mensaje)
        {
            int valor;
            Console.WriteLine(mensaje);

            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Valor inválido. Intente de nuevo");
            }

            return valor;
        }

        static decimal LeerDecimal(string mensaje)
        {
            decimal valor;
            Console.Write(mensaje);

            while (!decimal.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Número inválido. Intente de nuevo");
            }

            return valor;
        }

        static DateTime LeerFecha(string mensaje)
        {
            DateTime fecha;
            Console.Write(mensaje);

            while (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.Write("Fecha inválido. Intente de nuevo");
            }

            return fecha;
        }

        static void AgregarElectronico()
        {
            Console.WriteLine("Nuevo producto electrónico: ");

            int id = LeerEntero("ID: ");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            int cantidad = LeerEntero("Cantidad: ");
            decimal precio = LeerDecimal("Precio: ");
            int garantia = LeerEntero("Garantía (meses): ");

            ProductoElectronico p = new ProductoElectronico(id, nombre, cantidad, precio, garantia);
            inventario.AgregarProducto(p);

            Console.WriteLine("Producto electrónico agregado correctamente.");
        } 

        static void AgregarAlimenticio()
        {
            Console.WriteLine("Nuevo producto alimenticio: ");

            int id = LeerEntero("ID: ");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            int cantidad = LeerEntero("Cantidad: ");
            decimal precio = LeerDecimal("Precio: ");
            DateTime Fecha = LeerFecha("Fecha vencimiento: ");

            ProductoAlimenticio p = new ProductoAlimenticio(id, nombre, cantidad, precio, Fecha);
            inventario.AgregarProducto(p);

            Console.WriteLine("Producto alimenticio agregado correctamente.");
        }

        static void EliminarProducto()
        {
            Console.WriteLine("Eliminar producto: ");

            int id = LeerEntero("ID a eliminar");

            Console.Write("¿Seguro? (s/n): ");
            string confirm = Console.ReadLine().ToLower();

            if (confirm == "S")
            {
                inventario.EliminarProducto(id);
                Console.WriteLine("EL producto se ha eliminado correctamente";
            }
            else
            {
                Console.WriteLine("Cancelado");
            }
        }
    }
}
