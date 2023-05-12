using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class UslovniOtpusMapiranje : ClassMap<UslovniOtpust>
    {
        public UslovniOtpusMapiranje()
        {
            Table("USLOVNI_OTPUST");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Status, "STATUS");

            References(x => x.BrojZatvorenika).Column("BROJ").LazyLoad();



        }
    }
    
}
