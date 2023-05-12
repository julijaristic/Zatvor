using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;

namespace Zatvor.Mapiranje
{
    class TelefonFirmaMapiranje : ClassMap<TelefonFIrma>
    {
        public TelefonFirmaMapiranje()
        {
            Table("TELEFON");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.PibFirme, "PIB_FIRME");
            Map(x => x.Telefon, "TELEFON");
        }
    
    }
}
