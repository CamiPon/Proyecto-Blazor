using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoBlazorBackEnd.Data.Entities
{
    public class Lavado
    {
        [Key]
        public Int32 IDLavado { get; set; }
        public Int32 IDVehiculo { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime FechaLavado { get; set; }
        public Boolean Promocion { get; set; }
        public Boolean SinCargo { get; set; }
        public Boolean Pagado { get; set; }
        public Decimal Importe { get; set; }
        public String Observaciones { get; set; }
        public Boolean Entregado { get; set; }
    }
}
