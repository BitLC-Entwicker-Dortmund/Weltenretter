using System;
using System.Collections.Generic;

namespace Weltenretter.Models
{
    public partial class Held
    {
        public Held()
        {
            Bedrohungs = new HashSet<Bedrohung>();
        }

        public int HeldId { get; set; }
        public string Vorname { get; set; } = null!;
        public string Nachname { get; set; } = null!;
        public string? Beruf { get; set; }

        public virtual ICollection<Bedrohung> Bedrohungs { get; set; }
    }
}
