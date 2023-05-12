using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class RezimMapiranje : ClassMap<Rezim>
    {

        public RezimMapiranje()
        {
            Table("REZIM");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.TipRezima).Column("TIP_REZIMA");
            Map(x => x.VremePocetkaPosete).Column("VREME_POCETKA_POSETE");
            Map(x => x.DanPosete).Column("DAN_POSETE");
            Map(x => x.VremeKrajaPosete).Column("VREME_KRAJA_POSETE");
            Map(x => x.VremeUCelijiOd).Column("VREME_U_CELIJI_OD");
            Map(x => x.VremeUCelijiDo).Column("VREME_U_CELIJI_DO");
            Map(x => x.VremeSetnjeOd).Column("VREME_SETNJE_OD");
            Map(x => x.VremeSetnjeDo).Column("VREME_SETNJE_DO");
            Map(x => x.DanSetnje).Column("DAN_SETNJE");
       

            HasManyToMany(x => x.FirmaAngazuje)
                .Table("ANGAZUJE")
                .ParentKeyColumn("ID_REZIMA")
                .ChildKeyColumn("PIB_FIRME")
                .Cascade.All();

            HasManyToMany(x => x.PodrzavaRezim)
                .Table("PODRZAVA")
                .ParentKeyColumn("ID_REZIMA")
                .ChildKeyColumn("SIFRA_ZAT_JED")
                .Cascade.All();
        }
    }
}
