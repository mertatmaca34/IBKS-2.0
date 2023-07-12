using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DB41 : IEntity
    {
        public int Id { get; set; }
        public double TesisDebi { get; set; }
        public double TesisGünlükDebi { get; set; }
        public double DesarjDebi { get; set; }
        public double HariciDebi { get; set; }
        public double HariciDebi2 { get; set; }
        public double NumuneHiz { get; set; }
        public double NumuneDebi { get; set; }
        public double Ph { get; set; }
        public double Iletkenlik { get; set; }
        public double CozunmusOksijen { get; set; }
        public double NumuneSicaklik { get; set; }
        public double Koi { get; set; }
        public double Akm { get; set; }
        public double KabinNem { get; set; }
        public double KabinSicaklik { get; set; }
        public double Pompa1Hz { get; set; }
        public double Pompa2Hz { get; set; }
        public double UpsGirisVolt { get; set; }
        public double UpsCikisVolt { get; set; }
        public double UpsKapasite { get; set; }
        public double UpsSicaklik { get; set; }
        public double UpsYuk { get; set; }
    }
}
