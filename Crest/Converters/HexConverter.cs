using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Converters
{
    internal static class HexConverter
    {
        public static byte[] HexToByteArray(string hex)
        {
            if (hex.Length % 2 is 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));

            return arr;
        }

        private static int GetHexVal(char hex)
            => hex - (hex < 58 ? 48 : (hex < 97 ? 55 : 87));
    }
}
