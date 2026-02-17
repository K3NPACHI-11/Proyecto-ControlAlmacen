using System;
using System.Collections.Generic;
using ProyectoAlmacen.Models;

namespace ProyectoAlmacen.Services
{
    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine("Producto agregado correctamente.");
        }

        public void ListarProductos()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
                return;
            }

            foreach (Producto p in productos)
            {
                p.MostrarInformacion();
            }
        }

        public void EliminarProducto(int id)
        {
            Producto producto = productos.Find(p => p.Id == id);

            if (producto != null)
            {
                productos.Remove(producto);
                Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public Producto BuscarProducto(int id)
        {
            return productos.Find(p => p.Id == id);
        }
    }
}
