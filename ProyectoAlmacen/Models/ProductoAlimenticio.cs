using System;

namespace ProyectoAlmacen.Models
{
    public class ProductoAlimenticio : Producto
    {
        private DateTime fechaVencimiento;

        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public ProductoAlimenticio(int id, string nombre, int cantidad, decimal precio, DateTime fechaVencimiento)
            : base(id, nombre, cantidad, precio)
        {
            FechaVencimiento = fechaVencimiento;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Fecha de vencimiento: {FechaVencimiento.ToShortDateString()}");
            Console.WriteLine("-----------------------------");
        }
    }
}
