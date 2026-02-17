using System;

namespace ProyectoAlmacen.Models
{
    public class ProductoElectronico : Producto
    {
        private int garantiaMeses;

        public int GarantiaMeses
        {
            get { return garantiaMeses; }
            set
            {
                if (value >= 0)
                    garantiaMeses = value;
            }
        }

        public ProductoElectronico(int id, string nombre, int cantidad, decimal precio, int garantiaMeses)
            : base(id, nombre, cantidad, precio)
        {
            GarantiaMeses = garantiaMeses;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Garantía: {GarantiaMeses} meses");
            Console.WriteLine("-----------------------------");
        }
    }
}
