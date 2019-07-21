using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            foreach (var producto in listadeProductos)
            {
                Console.WriteLine(producto.Id +" "+ producto.Descripcion +" "+ producto.Precio);
                                                       
            }

            Console.ReadLine (); 
        }
    }
}
