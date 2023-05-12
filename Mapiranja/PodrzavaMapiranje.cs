using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class PodrzavaMapiranje : ClassMap<Podrzava>
    {
        public PodrzavaMapiranje()
        {
            Table("PODRZAVA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.IdRezim).Column("ID_REZIMA");
            References(x => x.SifraZJ).Column("SIFRA_ZAT_JED");

        }
    }
}
