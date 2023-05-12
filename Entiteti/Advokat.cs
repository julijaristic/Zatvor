using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class Advokat
    {
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumPostankaZastupnika { get; set; }
        public virtual IList<Zatvorenik> Zatvorenik { get; set; }

        public Advokat()
        {
            Zatvorenik = new List<Zatvorenik>();
        }

    }
}
