using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol.Models
{
    public class FutbolModels
    {
        public virtual int PosicionID { get; set; }
        public virtual string Posicion { get; set; }

        public List<SelectListItem> ListPosicion { get; set; }

        //public List<Listados> Listados { get; set; }

    }
    public class Listados
    {
        public virtual int PosicionID { get; set; }
        public virtual string Posicion { get; set; }
    }
    
}
