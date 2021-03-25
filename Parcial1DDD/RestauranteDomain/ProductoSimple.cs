using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1DDD.RestauranteDomain
{
    public class ProductoSimple : producto
    {
        public ProductoSimple(string nombre,  decimal costo, int cantidad ) : base(nombre, costo, cantidad) { }

        public override string RegistrarCompuesto(List<ProductoSimple> productoSimples, decimal precio)
        {
            throw new NotImplementedException();
        }

        public override string RegistrarProducto(string nombre, decimal costo, int cantidad)
        {
            if (cantidad < 0)
            {
                return "debe registrar mas de un producto";
            }
            else
            {
               
                cantidad += cantidad;
                return "Registro exitoso";
            }

            throw new NotImplementedException();
        }
        public override string VenderProducto(decimal cantidad, decimal cantidadvendida, decimal precio)
        {
            if (cantidad < cantidadvendida && cantidadvendida<=0)
            {
                return "No se realizo venta";
            }
            else
            {
                cantidad = cantidad*precio - cantidadvendida*precio;
                return "venta exitosa";
            }


            throw new NotImplementedException();
        }

    }
}
