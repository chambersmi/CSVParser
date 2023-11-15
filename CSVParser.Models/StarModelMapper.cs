using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser.Models
{
    public class StarModelMapper : ClassMap<StarModel>
    {
        public StarModelMapper()
        {
            Map(m => m.Id).Name("id").Default(0);
            Map(m => m.RightAscension).Name("ra").Default(0);
            Map(m => m.Declination).Name("dec").Default(0);
            Map(m => m.DistanceFromSolInParsecs).Name("dist").Default(0);
            Map(m => m.ProperMotionRightAscension).Name("pmra").Default(0);
            Map(m => m.ProperMotionDeclination).Name("pmdec").Default(0);
            Map(m => m.RadialVelocityKmPerSecond).Name("rv").Default(0);
            Map(m => m.V_Magnitude).Name("mag").Default(0);
            Map(m => m.AbsoluteMagnitude).Name("absmag").Default(0);
            Map(m => m.MKSpectralType).Name("spect").Default("");
            Map(m => m.ColorIndex).Name("ci").Default(0);
            Map(m => m.Luminosity).Name("lum").Default(0);
        }
    }
}
