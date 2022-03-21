using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol.Entities
{
    public class View_Futbolistas

    {
        [Key()]

        public int FutbolistasID { get; set; }

        
        public string Nombres { get; set; }

        
        public string Apellidos { get; set; }

        public int PosicionID { get; set; }
        public string Posicion { get; set; }

        public int Edad { get; set; }

        public DateTime? FechaRegristro { get; set; }
    }
}
