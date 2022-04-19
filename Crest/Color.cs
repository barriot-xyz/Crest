using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public readonly struct Color
    {
        public uint RawValue { get; }

        private string _hexValue { get; }

        private Color(uint value)
        {
            RawValue = value;
            _hexValue = null!;
        }

        public Color GetFromHex(string hex)
        {
            throw new NotImplementedException();
        }

        public Color GetFromRGB(int r, int g, int b)
        {
            throw new NotImplementedException();
        }

        public static Color Blue
            => new(132246u);

        public override string ToString()
            => $"#{_hexValue}";
    }
}
