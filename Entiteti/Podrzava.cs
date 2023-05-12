using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class Podrzava
    {
        public virtual int Id { get; set; }
        public virtual ZatvorskaJedinica SifraZJ { get; set; }
        public virtual Rezim IdRezim { get; set; }
        
    }
}
