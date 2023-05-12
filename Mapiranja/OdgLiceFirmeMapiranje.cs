using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;

namespace Zatvor.Mapiranje 
{
    class OdgLiceFirmeMapiranje : ClassMap<OdgLiceFirme>
    {
        public OdgLiceFirmeMapiranje()
        {
            //Mapiranje tabele
            Table("ODG_LICE_FIRMA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.PibFirme, "PIB_FIRME");
            Map(x => x.OdgovornoLice, "ODG_LICE_FIRME");




        }
    }
}
