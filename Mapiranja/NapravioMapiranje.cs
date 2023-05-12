using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class NapravioMapiranje : ClassMap<Napravio>
    {
        public NapravioMapiranje()
        {
            Table("NAPRAVIO");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Mesto, "MESTO_PRESTUPA");
            Map(x => x.DatumPrestupa, "DATUM_PRESTUPA");

            References(x => x.BrojZatvorenika).Column("BROJ_ZATVORENIKA");
            References(x => x.SifraPrestupa).Column("SIFRA_PRESTUPA");





        }
    }
}
