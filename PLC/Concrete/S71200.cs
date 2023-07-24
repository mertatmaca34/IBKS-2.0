namespace Entities.Concrete
{
    public class S71200
    {
        public DB4 DB4 { get; set; }
        public DB12 DB12 { get; set; }
        public DB41 DB41 { get; set; }
        public InputTags InputTags { get; set; }
        public MBTags MBTags { get; set; }

        public byte[] Buffer4 { get; set; }
        public byte[] Buffer12 { get; set; }
        public byte[] Buffer41 { get; set; }
        public byte[] InputTagsBuffer { get; set; }
        public byte[] MBTagsBuffer { get; set; }

        public S71200()
        {
            DB4 = new DB4();
            DB12 = new DB12();
            DB41 = new DB41();
            InputTags = new InputTags();
            MBTags = new MBTags();

            Buffer4 = new byte[12];
            Buffer12 = new byte[28];
            Buffer41 = new byte[248];
            InputTagsBuffer = new byte[30];
            MBTagsBuffer = new byte[102];
        }
    }
}
