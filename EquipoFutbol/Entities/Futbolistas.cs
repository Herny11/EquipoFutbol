using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol.Entities
{
    [Table("Futbolistas")]
    public class Futbolistas
    {
        

        [Key]
        public int FutbolistasID { get; set; }

        [Required (ErrorMessage = "El campo Nombre es requerido")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string Apellidos { get; set; }

        public int PosicionID { get; set; }

        public int? Edad { get; set; }

        public DateTime? FechaRegristro { get; set; }


    }
}
