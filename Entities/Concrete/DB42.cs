using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DB42 : IEntity
    {
        public int Id { get; set; }
        public bool Kabin_Oto { get; set; }
        public bool Kabin_Bakim { get; set; }
        public bool Kabin_Kalibrasyon { get; set; }
        public bool Kabin_Duman { get; set; }
        public bool Kabin_SuBaskini { get; set; }
        public bool Kabin_KapiAcildi { get; set; }
        public bool Kabin_EnerjiYok { get; set; }
        public bool Kabin_AcilStopBasili { get; set; }
        public bool Kabin_HaftalikYikamada { get; set; }
        public bool Kabin_SaatlikYikamada { get; set; }
        public bool Pompa1Termik { get; set; }
        public bool Pompa2Termik { get; set; }
        public bool Pompa3Termik { get; set; }
        public bool TankDolu { get; set; }
        public bool Pompa1Calisiyor { get; set; }
        public bool Pompa2Calisiyor { get; set; }
        public bool Pompa3Calisiyor { get; set; }
        public bool AkmTetik { get; set; }
        public bool KoiTetik { get; set; }
        public bool PhTetik { get; set; }
        public bool ManuelTetik { get; set; }
        public bool SimNumuneTetik { get; set; }
    }
}
