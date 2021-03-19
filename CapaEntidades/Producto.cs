using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int Id { get; set; }

        public string NombreProducto { get; set; }

        public int codigo { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string Categoria { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }

        public decimal Stock { get; set; }
    }
}
