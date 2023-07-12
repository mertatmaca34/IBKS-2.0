using Core.Entities;

namespace Entities.Concrete
{
    public class InputTags : IEntity
    {
        public int Id { get; set; }
        public DateTime ReadTime { get; set; }
        public bool Kapi { get; set; }
        public bool Duman { get; set; }
        public bool SuBaskini { get; set; }
        public bool AcilStop { get; set; }
        public bool Pompa1Termik { get; set; }
        public bool Pompa2Termik { get; set; }
        public bool TemizSuTermik { get; set; }
        public bool YikamaTanki { get; set; }
        public bool Enerji { get; set; }
        public bool Pompa1CalisiyorMu { get; set; }
        public bool Pompa2CalisiyorMu { get; set; }
    }
}
