using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "minecraft";
            producto1.Precio = 29.99;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "spider man";
            producto2.Precio = 39.49;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Dragon ball z tenkashi";
            producto3.Precio = 10.99;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
