﻿namespace Crest.Core
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

        public static implicit operator Color(string hex)
            => GetFromHex(hex);

        public static Color GetFromHex(string hex)
            => new(Convert.ToUInt32(hex, 16));

        public static Color GetFromRGB(int r, int g, int b)
            => new((uint)(r << 16 | g << 8 | b));

        public static Color Blue
            => new(132246u);

        public override string ToString()
            => $"#{_hexValue}";
    }
}
