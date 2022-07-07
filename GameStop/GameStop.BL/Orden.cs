using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
   public class Orden
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public List<OrdenDetalle> ListadeOrdenDetalle { get; set; }

        public Orden()
        {
            Activo = true;
            Fecha = DateTime.Now;

            ListadeOrdenDetalle = new List<OrdenDetalle>();
        }
    }
}
