using System;
using System.Collections.Generic;

namespace GymLife.DOMAIN.Core.Entities
{
    public partial class Areas
    {
        public Areas()
        {
            Puesto = new HashSet<Puesto>();
        }

        public int IdAreas { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Puesto> Puesto { get; set; }
    }
}
