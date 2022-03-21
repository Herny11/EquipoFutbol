using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol.Entities
{
    [Table("Posiciones")]
    public class Posiciones
    {
        

        [Key]
        public int PosicionID { get; set; }

        
        public virtual string Posicion { get; set; }

       
    }
}
