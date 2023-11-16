using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser.Models
{
    public class StarModel
    {
        [Key]
        public int Id { get; set; }
        public double RightAscension { get; set; }
        public double Declination { get; set; }
        public double DistanceFromSolInParsecs { get; set; }
        public double ProperMotionRightAscension { get; set; }
        public double ProperMotionDeclination { get; set; }
        public double RadialVelocityKmPerSecond { get; set; }
        public double V_Magnitude { get; set; }
        public double AbsoluteMagnitude { get; set; }
        public string MKSpectralType { get; set; }
        public string ColorIndex { get; set; }
        public double Luminosity { get; set; }
    }
}
