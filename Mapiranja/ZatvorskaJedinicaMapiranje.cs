using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class ZatvorskaJedinicaMapiranje : ClassMap<ZatvorskaJedinica>
    {

        public ZatvorskaJedinicaMapiranje()
        {
            Table("ZATVORSKA_JEDINICA");

            Id(x => x.Sifra, "SIFRA").GeneratedBy.SequenceIdentity("S18359.ZATVORSKA_JEDINICA_SIFRA_SEQ");

            Map(x => x.Kapacitet).Column("KAPACITET");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Grad).Column("GRAD");
            Map(x => x.Ulica).Column("ULICA");

            HasMany(x => x.Zaposleni).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Zatvorenik).KeyColumn("BROJ").LazyLoad().Cascade.All().Inverse();
            HasOne(x => x.Zaposleni).Cascade.SaveUpdate();

            HasManyToMany(x => x.PodrzavaRezim)
                .Table("PODRZAVA")
                .ParentKeyColumn("SIFRA_ZAT_JED")
                .ChildKeyColumn("ID_REZIMA")
                .Inverse()
                .Cascade.All();
        }
    }
}
