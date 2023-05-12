using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class Prestup
    {
        public virtual int Sifra { get; set; }
        public virtual string PunNaziv { get; set; }
        public virtual string Opis { get; set; }
        public virtual int MinKazna { get; set; }
        public virtual int MaxKazna { get; set; }
        public virtual string Kategorija { get; set; }
        public virtual IList<Napravio> ZatvorenikNapravio { get; set; }

        public Prestup()
        {
            ZatvorenikNapravio = new List<Napravio>();
          
        }


    }
}
