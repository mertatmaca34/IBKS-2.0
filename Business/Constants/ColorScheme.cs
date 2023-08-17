using System.Drawing;

namespace Business.Constants
{
    public static class ColorScheme
    {
        public static readonly Color Black = Color.FromArgb(18,18,18);
        public static readonly Color SimpleBlack = Color.FromArgb(24,24,24);
        public static readonly Color DarkGray = Color.FromArgb(28,28,28);
        public static readonly Color Gray = Color.FromArgb(64,64,64);
        public static readonly Color White = Color.White;


        public readonly static Color PanelBgLight = Color.WhiteSmoke;
        public readonly static Color PanelFgLight = Color.Black;

        public readonly static Color PanelBgDark = Black;
        public readonly static Color PanelFgDark = White;

        public readonly static Color ButtonBgDark = DarkGray;
        public readonly static Color ButtonFgDark = White;
    }
}
