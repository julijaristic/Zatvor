using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class UslovniOtpust
    {
        public virtual int ID { get; set; }
        public virtual Zatvorenik BrojZatvorenika { get; set; }
        public virtual string Status { get; set; }
    }
}
