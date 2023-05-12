using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class Napravio
    {
        public virtual int Id { get; set; }
        public virtual Zatvorenik BrojZatvorenika { get; set; }
        public virtual Prestup SifraPrestupa { get; set; }
        public virtual string Mesto { get; set; }
        public virtual DateTime DatumPrestupa { get; set; }
    }
}
