using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class Angazuje
    {
        public virtual int Id { get; set; }
        public virtual Rezim IdRezima { get; set; }
        public virtual Firma PibFirme { get; set; }
    }
}
