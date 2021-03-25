using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1DDD.RestauranteDomain
{
    public class ProductoCompuesto : producto 
    {
        public ProductoCompuesto(List<ProductoSimple> productoSimples) : base(productoSimples) { }
       
        
        public override string RegistrarProducto(string nombre, decimal costo, int cantidad)
        {
            throw new NotImplementedException();

        }

        public override string VenderProducto(int cantidad, int cantidadvendida)
        {
            throw new NotImplementedException();
        }
    }
    
}
