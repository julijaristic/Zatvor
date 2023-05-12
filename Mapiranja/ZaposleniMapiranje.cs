using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;
namespace Zatvor.Mapiranje
{
    class ZaposleniMapiranje : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranje()
        {
            Table("ZAPOSLENI");

            DiscriminateSubClassesOnColumn("TIP_ZAPOSLENOG");

            Id(x => x.Jmbg, "JMBG").GeneratedBy.SequenceIdentity("S18359.ZAPOSLENI_JMBG_SEQ");

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Pol).Column("POL");
            Map(x => x.Datum_poslednje_obuke).Column("DATUM_POSLEDNJE_OBUKE");
            Map(x => x.DatumPocetkaRada).Column("DATUM_POC_RADA");


            References(x => x.SifraZJ).Column("SIFRA").LazyLoad();
        }
    }
}
class PsihologMapiranje : SubclassMap<Psiholog>
{
    public PsihologMapiranje()
    {
        DiscriminatorValue("PSIHOLOG");
        Map(x => x.ImeLekara).Column("IME_LEKARA");
        Map(x => x.PrezimeLekara).Column("PREZIME_LEKARA");
        Map(x => x.NazivUstanove).Column("NAZIV_USTANOVE");
        Map(x => x.GradUstanove).Column("GRAD_USTANOVE");
        Map(x => x.UlicaUstanove).Column("ULICA_USTANOVE");
        Map(x => x.DatumPregleda).Column("DATUM_PREGLEDA");
    }
}

class AdministratorMapiranje : SubclassMap<Administrator>
{
    public AdministratorMapiranje()
    {
        DiscriminatorValue("ADMINISTRACIJA");
        Map(x => x.Strucna_sprema).Column("STRUCNA_SPREMA");
        Map(x => x.Pozicija).Column("POZICIJA");
        Map(x => x.Zanimanje).Column("ZANIMANJE");
    }
}

class UpravnikMapiranje : SubclassMap<Upravnik>
{
    public UpravnikMapiranje()
    {
        DiscriminatorValue("UPRAVNIK");
        References(x => x.SifraZJ).Column("SIFRA").LazyLoad();
    }
}

class ObezbedjenjeMapiranje : SubclassMap<Obezbedjenje>
{
    public ObezbedjenjeMapiranje()
    {
        DiscriminatorValue("OBEZBEDJENJE");

        Map(x => x.ImeLekara).Column("IME_LEKARA");
        Map(x => x.PrezimeLekara).Column("PREZIME_LEKARA");
        Map(x => x.NazivUstanove).Column("NAZIV_USTANOVE");
        Map(x => x.GradUstanove).Column("GRAD_USTANOVE");
        Map(x => x.UlicaUstanove).Column("ULICA_USTANOVE");
        Map(x => x.DatumPregleda).Column("DATUM_PREGLEDA");
        Map(x => x.DatumIzdavanja).Column("DATUM_IZDAVANJA");
        Map(x => x.PU).Column("PU");
        Map(x => x.SifraSertifikata).Column("SIFRA_SERIFIKATA");
    }
}
