using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class AdvokatMapiranje : ClassMap<Advokat>
    {
        public AdvokatMapiranje()
        {
            Table("ADVOKAT");

            Id(x => x.Jmbg, "JMBG").GeneratedBy.SequenceIdentity("S18359.ADVOKAT_JMBG_SEQ");

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumPostankaZastupnika, "DATUM_POSTANKA_ZASTUPNIKA");

            HasMany(x => x.Zatvorenik).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();

        }
    }
}
