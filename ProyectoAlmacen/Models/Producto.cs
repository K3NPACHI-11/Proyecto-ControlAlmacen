using System;

namespace ProyectoAlmacen.Models
{
    public class Producto
    {
        private int id;
        private string nombre;
        private int cantidad;
        private decimal precio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value >= 0)
                    cantidad = value;
            }
        }

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value >= 0)
                    precio = value;
            }
        }

        public Producto(int id, string nombre, int cantidad, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Precio: {Precio:C}");
        }
    }
}
