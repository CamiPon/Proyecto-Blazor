using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoBlazorBackEnd.Data.Entities
{
    public class Cliente
    {
        [Key]
        public Int64 IDCliente { get; set; }
        public String ApellidoNomrbre { get; set; }
        public String Telefono { get; set; }
        public String Observaciones { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
