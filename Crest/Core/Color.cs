namespace Crest
{
    public readonly struct Color
    {
        public uint RawValue { get; }

        private readonly string _hexValue { get; }

        private Color(uint value)
        {
            RawValue = value;
            _hexValue = null!;
        }

        public static implicit operator Color(uint rawValue)
            => new Color(rawValue);

        public static implicit operator Color(string hex)
            => FromHex(hex);

        public static Color FromHex(string hex)
            => new(Convert.ToUInt32(hex, 16));

        public static Color FromRGB(int r, int g, int b)
            => new((uint)(r << 16 | g << 8 | b));

        public static Color FromRawValue(uint rawValue)
            => new(rawValue);

        public static Color Blue
            => new(132246u);

        public override string ToString()
            => $"#{_hexValue}";
    }
}
