using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class AngazujeMapiranje : ClassMap<Angazuje>
    {
        public AngazujeMapiranje()
        {
            Table("ANGAZUJE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.IdRezima).Column("ID_REZIMA");
            References(x => x.PibFirme).Column("PIB_FIRME");





        }
    }
}
