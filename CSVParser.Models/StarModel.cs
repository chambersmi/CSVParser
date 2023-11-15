using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser.Models
{
    public class StarModel
    {
        public int Id { get; set; }
        public float? RightAscension { get; set; }
        public float? Declination { get; set; }
        public float? DistanceFromSolInParsecs { get; set; }
        public float? ProperMotionRightAscension { get; set; }
        public float? ProperMotionDeclination { get; set; }
        public float? RadialVelocityKmPerSecond { get; set; }
        public float? V_Magnitude { get; set; }
        public float? AbsoluteMagnitude { get; set; }
        public string? MKSpectralType { get; set; }
        public float? ColorIndex { get; set; }
        public float? Luminosity { get; set; }
    }

}
