using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC.Sharp7.Utils
{
    public static class Get
    {
        static public double Real(byte[] buffer, int offset, int? divider = null)
        {
            if (divider.HasValue)
            {
                return Math.Round((double)(S7.GetRealAt(buffer, offset) / divider), 2);
            }
            else
            {
                return Math.Round(S7.GetRealAt(buffer, offset), 2);
            }
        }
        static public Byte Byte(byte[] buffer, int offset)
        {
            return S7.GetByteAt(buffer, offset);
        }
        static public DateTime Time(byte[] buffer, int offset)
        {
            return S7.GetDTLAt(buffer, offset);
        }
        static public Boolean Input(byte[] buffer, int pos, int bit)
        {
            return S7.GetBitAt(buffer, pos, bit);
        }
        static public Boolean MB(byte[] buffer, int pos, int bit)
        {
            return S7.GetBitAt(buffer, pos, bit);
        }
        static public Boolean Bit(byte[] buffer, int pos, int bit)
        {
            return S7.GetBitAt(buffer, pos, bit);
        }
    }
}
