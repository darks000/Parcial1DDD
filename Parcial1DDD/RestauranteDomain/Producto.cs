using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1DDD.RestauranteDomain
{
    public abstract class producto 
    {
        private List<ProductoSimple> productoSimples;

        protected producto(List<ProductoSimple> productoSimples)
        {
            this.productoSimples = productoSimples;
        }

        protected producto(string nombre, decimal costo, int cantidad )
        {
            Nombre = nombre;
            Costo = costo;
            Cantidad = 0;
        }

            public string Nombre { get; private set; }
            public decimal Costo { get; protected set; }
            public int Cantidad { get; protected set; }

        public abstract string RegistrarProducto(String nombre, decimal costo, int cantidad);
        public abstract string VenderProducto(decimal cantidad , decimal cantidadvendida, decimal precio);

        public abstract string RegistrarCompuesto(List<ProductoSimple> productoSimples,decimal precio);
    }

}


   

