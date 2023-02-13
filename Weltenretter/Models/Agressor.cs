using System;
using System.Collections.Generic;

namespace Weltenretter.Models
{
    public partial class Agressor
    {
        public Agressor()
        {
            Bedrohungs = new HashSet<Bedrohung>();
        }

        public int AgressorId { get; set; }
        public string Vorname { get; set; } = null!;
        public string Nachname { get; set; } = null!;
        public string? Spezialitaet { get; set; }

        public virtual ICollection<Bedrohung> Bedrohungs { get; set; }
    }
}
