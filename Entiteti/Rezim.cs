using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class Rezim
    {
        public virtual int Id { get; set; }
        public virtual string TipRezima { get; set; }
        public virtual DateTime VremePocetkaPosete { get; set; }
        public virtual string DanPosete { get; set; }
        public virtual DateTime VremeKrajaPosete { get; set; }
        public virtual DateTime VremeUCelijiOd { get; set; }
        public virtual DateTime VremeUCelijiDo { get; set; }
        public virtual DateTime VremeSetnjeOd { get; set; }
        public virtual DateTime VremeSetnjeDo { get; set; }
        public virtual string DanSetnje { get; set; }
        public virtual IList<Podrzava> PodrzavaRezim { get; set; }
        public virtual IList<Angazuje> FirmaAngazuje { get; set; }

        public Rezim()
        {
            PodrzavaRezim = new List<Podrzava>();
            FirmaAngazuje = new List<Angazuje>();

        }
    }
}
