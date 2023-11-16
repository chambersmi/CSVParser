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
            //Map(m => m.Id).Name("id");
            Map(m => m.RightAscension).Name("ra");
            Map(m => m.Declination).Name("dec");
            Map(m => m.DistanceFromSolInParsecs).Name("dist");
            Map(m => m.ProperMotionRightAscension).Name("pmra");
            Map(m => m.ProperMotionDeclination).Name("pmdec");
            Map(m => m.RadialVelocityKmPerSecond).Name("rv");
            Map(m => m.V_Magnitude).Name("mag");
            Map(m => m.AbsoluteMagnitude).Name("absmag");
            Map(m => m.MKSpectralType).Name("spect").Default("");
            Map(m => m.ColorIndex).Name("ci");
            Map(m => m.Luminosity).Name("lum");
        }
    }
}
