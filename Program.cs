using Practica01.Domain;
using Practica01.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instanciamos el Service
            ProductoService oService = new ProductoService();

            // Obtener todos los productos - GetAll
            Console.WriteLine("Obtener todos los productos - GetAll");

            // Llamamos al Service
            List<Productos> lp = oService.GetAllProductos();

            // Manejamos la respuesta
            if (lp.Count > 0)
                foreach (Productos p in lp)
                    Console.WriteLine(p);
            else
                Console.WriteLine("No hay productos...");

            // Obtener un producto por id - GetById
            Console.WriteLine("\nObtener un producto por id - GetById");

            // Llamamos al Service
            Productos producto5 = oService.GetProductosById(0);

            // Manejamos la respuesta
            if (producto5 != null)
            {
                Console.WriteLine(producto5);
            }
            else
            {
                Console.WriteLine("No hay un producto con Código = 5.");
            }



            // Actualizar datos de un producto - SaveProduct
            Console.WriteLine("\nActualizar datos de un producto - SaveProduct");

            // Creamos el objeto - es importante establecerle Codigo
            Productos myProduct2 = new Productos();
            myProduct2.Id = 10;
            myProduct2.Nombre = "Gilada";
            myProduct2.Stock = 0;



            // Guardar un producto y sus ingredientes - ExecuteTransaction
            Console.WriteLine("\nGuardar un producto y sus ingredientes - ExecuteTransaction");

            // Creamos el producto y sus ingredientes
            Productos complexProduct = new Productos()
            {
                Nombre = "Monster Watermelon",
                Precio = 2500,
                Stock = 50,
            };

        }
    }
}
      