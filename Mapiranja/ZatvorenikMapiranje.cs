using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class ZatvorenikMapiranje : ClassMap<Zatvorenik>
    {
        public ZatvorenikMapiranje()
        {
            Table("ZATVORENIK");

            Id(x => x.Broj, "BROJ").GeneratedBy.SequenceIdentity("S18359.ZATVORENIK_BROJ_SEQ");

            Map(x => x.Ime, "IME");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Prezime, "IME");
            Map(x => x.Pol, "GRAD");
            Map(x => x.DatumSaslusanja, "ULICA");
            Map(x => x.DatumPosete, "IME");
            Map(x => x.VremePocetkaPosete, "GRAD");
            Map(x => x.VremeKrajaPosete, "ULICA");

            References(x => x.JmbgAdv).Column("JMBG").LazyLoad();
            References(x => x.PibFirme).Column("PIB").LazyLoad();
            References(x => x.SifraZJ).Column("SIFRA").LazyLoad();

            HasManyToMany(x => x.NapravioPrestup)
                .Table("NAPRAVIO")
                .ParentKeyColumn("BROJ_ZATVORENIKA")
                .ChildKeyColumn("SIFRA_PRESTUPA")
                .Inverse()
                .Cascade.All();

        }

        
    }
}
