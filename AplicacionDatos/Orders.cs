using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDatos
{
    class Orders
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; } // se pone ? para que acepte null
        public DateTime? FilledDate { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }

    }
}
