using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class TelefonFIrma
    {
        public virtual int Id { get; set; }
        public virtual Firma PibFirme { get; set; }
        public virtual string Telefon { get; set; }

        public override string ToString()
        {
            return Telefon;
        }
    }
}
