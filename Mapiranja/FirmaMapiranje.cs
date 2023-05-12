using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;

namespace Zatvor.Mapiranje
{
    class FirmaMapiranje : ClassMap<Firma>
    {
        public FirmaMapiranje()
        {
            Table("FIRMA");

            Id(x => x.Pib, "PIB").GeneratedBy.SequenceIdentity("S18359.FIRMA_PIB_SEQ");

            Map(x => x.Ime, "IME");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Ulica, "ULICA");

            HasMany(x => x.Zatvorenik).KeyColumn("PIB").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.FirmaAngazuje)
                .Table("ANGAZUJE")
                .ParentKeyColumn("PIB_FIRME")
                .ChildKeyColumn("ID_REZIMA")
                .Inverse()
                .Cascade.All();


        }
    }
}
