using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoBlazorBackEnd.Data.Entities
{
    public class Vehiculo
    {
        [Key]
        public Int32 IDVehiculo { get; set; }
        public Int32 IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public String Patente { get; set; }
        public String Marca { get; set; }
        public String Observaciones { get; set; }
        public List<Lavado> Lavados { get; set; }
    }
}
