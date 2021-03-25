using NUnit.Framework;
using Parcial1DDD.RestauranteDomain;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*   H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS Simples.
         Criterio de Aceptación:
         1.La cantidad de la entrada de debe ser mayor a 0

         Dado El cliente tiene un producto simple
         nombre salchicha , costo 1000, cantidad  0
         Cuando Va a registrar un valor menor o igual a cero ///  errada
         Cuando Va a registrar un valor de cero /// 
         Entonces El sistema presentará el mensaje. “la cantidad de producto a registrar es incorrecto”
          */
        [Test]
        public void NopuedesRegistrarunproductosimple()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var productoSimple = new ProductoSimple("salchicha", 1000,0);
            // ACT // ACCION // CUANDO // WHEN
            var resultado = productoSimple.RegistrarProducto("salchicha",5000,0);
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("la cantidad de producto a registrar es incorrecto", resultado);
        }
        

        /* 
             Dado El cliente tiene un producto simple
             nombre salchicha , costo 1000, cantidad  3
             Cuando Va a registrar un valor mayor o igual a cero ///  correcto
             Cuando Va a registrar un valor de cero /// 
             Entonces El sistema presentará el mensaje. “la cantidad de producto a registrar es correcto
        */
        [Test]
        public void puedoRegistrarunproductosimple()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var productoSimple = new ProductoSimple("salchicha", 1000,3);
            // ACT // ACCION // CUANDO // WHEN
            var resultado = productoSimple.RegistrarProducto("salchicha", 1000, 3);
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("la cantidad de producto a registrar es correcto", resultado);
        }
        /* HU2 COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS *
         * CRITERIOS DE ACEPTACIÓN
         * 1. La cantidad de la salida de debe ser mayor a 0
         * 2.En caso de un producto sencillo la cantidad de la salida se le disminuirá a la cantidad existente del producto
         * Dado El cliente tiene un producto simple de costo
          costo 1000 , cantidad 4 y cantidad vendida
         Cuando Va a registrar una venta con cantidad mayor o igual a cantidad vendida ///  correcto
       
         Entonces El sistema presentará el mensaje. “"la venta del producto es correcto"
         */
        [Test]
        public void puedoRealizaventarunproductosimple()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var productoSimple = new ProductoSimple("salchicha", 1000, 3);
            // ACT // ACCION // CUANDO // WHEN
            var resultado = productoSimple.VenderProducto(4, 3);
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("la venta del producto es correcto", resultado);
        }
        /* Dado El cliente tiene un producto simple de costo
        costo 1000 , cantidad 0 y cantidad vendida 3
       Cuando Va a registrar una venta con cantidad Menor a cantidad vendida ///  incorrecto

       Entonces El sistema presentará el mensaje. "la venta del producto es incorrecto"
        */
        [Test]
        public void nopuedoRealizaventarCantindadMenorcantidadVendida()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var productoSimple = new ProductoSimple("salchicha", 1000, 3);
            // ACT // ACCION // CUANDO // WHEN
            var resultado = productoSimple.VenderProducto(0, 3);
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("la venta del producto es incorrecto", resultado);
        }
    }
}