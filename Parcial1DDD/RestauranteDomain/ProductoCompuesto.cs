using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1DDD.RestauranteDomain
{
    public class ProductoCompuesto : producto 
    {
        public ProductoCompuesto(List<ProductoSimple> productoSimples, decimal precio, string nombre) : base(productoSimples) { }

       
        public override string RegistrarCompuesto(List<ProductoSimple> listaproductoSimples, decimal precio)
        {
         decimal   valorproducto = 0;
            bool CreacionProducto = true;

            foreach (var costo in listaproductoSimples)
            {
                if (costo.Cantidad <= 0)
                {
                    CreacionProducto = false;
                    return "no hay producto en inventario";
                    break;
                }
                valorproducto = costo.Costo + valorproducto;
            }
            
            if (CreacionProducto == true && precio>=valorproducto)
            {
                decimal utilidad = precio - valorproducto;
                return "creacion del producto exitoso";
            }
            else 
            { 
                return "No se pudo crear producto";
            }
            throw new NotImplementedException();
        }
        public override string VenderProducto(int cantidad, int cantidadvendida)
        {
            throw new NotImplementedException();
        }

        public override string RegistrarProducto(string nombre, decimal costo, int cantidad)
        {
            
            throw new NotImplementedException();

        }

       
    }
    
}
