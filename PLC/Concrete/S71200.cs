namespace Entities.Concrete
{
    public class S71200
    {
        public DB41 DB41 { get; set; }
        public DB42 DB42 { get; set; }
        public DB43 DB43 { get; set; }

        public byte[] Buffer41 { get; set; }
        public byte[] Buffer42 { get; set; }
        public byte[] Buffer43 { get; set; }


        public S71200()
        {
            DB41 = new DB41();
            DB42 = new DB42();
            DB43 = new DB43();

            Buffer41 = new byte[248];
            Buffer42 = new byte[3];
            Buffer43 = new byte[19];
        }
    }
}
