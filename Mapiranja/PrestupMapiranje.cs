using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class PrestupMapiranje : ClassMap<Prestup>
    {
        public PrestupMapiranje()
        {
            Table("PRESTUP");

            Id(x => x.Sifra, "SIFRA").GeneratedBy.SequenceIdentity("S18359.PRESTUP_SIFRA_SEQ");

            Map(x => x.PunNaziv, "PUN_NAZIV");
            Map(x => x.Opis, "OPIS");
            Map(x => x.MinKazna, "MIN_KAZNA");
            Map(x => x.MaxKazna, "MAX_KAZNA");
            Map(x => x.Kategorija, "KATEGORIJA");

            HasManyToMany(x => x.ZatvorenikNapravio)
                .Table("NAPRAVIO")
                .ParentKeyColumn("SIFRA_PRESTUPA")
                .ChildKeyColumn("BROJ_ZATVORENIKA")
                .Cascade.All();
        }
    
    }
}
