using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace SharpColor
{
    public class MySharpColor
    {
        //Colors
        public Color SharpRed { get { return Color.FromArgb(255, 0, 0); } }
        public Color Sharporange { get { return Color.FromArgb(255, 0, 0); } }
        public Color SharpBlue { get { return Color.FromArgb(100, 170, 200); } }
        public Color SharpPurple { get { return Color.FromArgb(255, 0, 0); } }
        public Color SharpGreen { get { return Color.FromArgb(255, 0, 0); } }
        public Color SharpSalmon{ get { return Color.FromArgb(250, 128,114); } }
        public Color SharpDarkRed{ get { return Color.FromArgb(139, 0,0); } }
        public Color SharpMaroon{ get { return Color.FromArgb(128, 0,0); } }
        public Color SharpTomato{ get { return Color.FromArgb(255, 99,71); } }
        public Color SharpVioletRed{ get { return Color.FromArgb(208, 32,144); } }
        public Color SharpPaleVioletRed{ get { return Color.FromArgb(219, 112,147); } }
        public Color SharpMediumVioletRed{ get { return Color.FromArgb(199, 21,133); } }
        public Color SharpIndianRed{ get { return Color.FromArgb(205, 92,92); } }
        public Color SharpFireBrick{ get { return Color.FromArgb(178, 34,34); } }
        public Color SharpSienna{ get { return Color.FromArgb(160, 82,45); } }
        public Color SharpOrangeRed{ get { return Color.FromArgb(255, 62,0); } }
        public Color SharpOrange{ get { return Color.FromArgb(255, 165,0); } }
        public Color SharpDarkOrange{ get { return Color.FromArgb(255, 140,0); } }
        public Color SharpCoral{ get { return Color.FromArgb(255, 127,80); } }
        public Color SharpLightCoral{ get { return Color.FromArgb(240, 240,240); } }
        public Color SharpPeach{ get { return Color.FromArgb(254, 240,219); } }
        public Color SharpPeachPuff{ get { return Color.FromArgb(255, 218,185); } }
        public Color SharpPapayawhip{ get { return Color.FromArgb(255, 239,213); } }
        public Color SharpYellow{ get { return Color.FromArgb(255, 255,0); } }
        public Color SharpLightYellow{ get { return Color.FromArgb(255, 255,224); } }
        public Color SharpLemonChiffon{ get { return Color.FromArgb(255, 250,205); } }
        public Color SharpGreenYellow{ get { return Color.FromArgb(173, 255,47); } }
        public Color SharpSunflower{ get { return Color.FromArgb(246,166 ,0); } }
        public Color SharpGoldenrod{ get { return Color.FromArgb(218, 165,32); } }
        public Color SharpDarkGoldenrod{ get { return Color.FromArgb(184, 134,11); } }
        public Color SharpLightGoldenrod{ get { return Color.FromArgb(238,221,130); } }
        public Color SharpLightGoldenrodYellow{ get { return Color.FromArgb(250, 250,210); } }
        public Color SharpPaleGoldenrod{ get { return Color.FromArgb(238, 232,170); } }
        public Color SharpPink{ get { return Color.FromArgb(255, 193,203); } }
        public Color SharpLightPink{ get { return Color.FromArgb(255, 182,193); } }
        public Color SharpHotPink{ get { return Color.FromArgb(255, 105,180); } }
        public Color SharpFuchsia{ get { return Color.FromArgb(255, 0,255); } }
        public Color SharpDeepPink{ get { return Color.FromArgb(255,20 ,147); } }
        public Color SharpMistyRose{ get { return Color.FromArgb(255, 228,225); } }
        public Color SharpLightSalmon{ get { return Color.FromArgb(255, 160,122); } }
        public Color SharpDarkSalmon{ get { return Color.FromArgb(233, 150,122); } }
        public Color SharpYellowGreen{ get { return Color.FromArgb(154, 205,50); } }
        public Color SharpPaleGreen{ get { return Color.FromArgb(152, 251,152); } }
        public Color SharpLightGreen{ get { return Color.FromArgb(144, 238,144); } }
        public Color SharpDarkGreen{ get { return Color.FromArgb(0, 128,8); } }
        public Color SharpOlive{ get { return Color.FromArgb(128, 128,0); } }
        public Color SharpOliveDrab{ get { return Color.FromArgb(107, 142,35); } }
        public Color SharpDraOliveGreen { get { return Color.FromArgb(85, 107,47); } }
        public Color SharpChareuse{ get { return Color.FromArgb(127, 255,0); } }
        public Color SharpForestGreen{ get { return Color.FromArgb(34, 139, 34); } }
        public Color SharpGainBoro{ get { return Color.FromArgb(220, 220,220); } }
        public Color SharpSpringGreen{ get { return Color.FromArgb(0, 255,127); } }
        public Color SharpmediumSpringGreen{ get { return Color.FromArgb(0, 250,154); } }
        public Color SharpLawnGreen{ get { return Color.FromArgb(124, 252,0); } }
        public Color SharpMintCream{ get { return Color.FromArgb(245, 255,250); } }
        public Color SharpHoneyDew{ get { return Color.FromArgb(240, 255,240); } }
        public Color SharpLightSeaGreen{ get { return Color.FromArgb(32, 178,170); } }
        public Color SharpDrakSeaGreen{ get { return Color.FromArgb(143, 188,143); } }
        public Color SharpMediumSeaGreen{ get { return Color.FromArgb(60, 179,113); } }
        public Color SharpLime{ get { return Color.FromArgb(0, 255,0); } }
        public Color SharpLimeGreen{ get { return Color.FromArgb(50, 205,50); } }
        public Color SharpTeal{ get { return Color.FromArgb(0, 128,128); } }
        public Color SharpTurquoise { get { return Color.FromArgb(64, 224,208); } }
        public Color SharpPaleTurquoise{ get { return Color.FromArgb(175, 238,238); } }
        public Color SharpMediumTurquoise{ get { return Color.FromArgb(72, 209,204); } }
        public Color SharpDrakTurquoise{ get { return Color.FromArgb(0, 206,209); } }
        public Color SharpAqua{ get { return Color.FromArgb(0,255 ,255); } }
        public Color SharpMediumAquamarine{ get { return Color.FromArgb(102,205 ,170); } }
        public Color SharpMediumBlue{ get { return Color.FromArgb(0,0 ,205 ); } }
        public Color SharpDrakBlue{ get { return Color.FromArgb(0,0 ,139 ); } }
        public Color SharpLightBlue{ get { return Color.FromArgb(173,216 ,230 ); } }
        public Color SharpAliceBlue{ get { return Color.FromArgb(240, 248,255); } }
        public Color SharpNavy{ get { return Color.FromArgb(0, 0,128); } }
        public Color SharpNavyBlue{ get { return Color.FromArgb(159,175 ,223); } }
        public Color SharpAzure{ get { return Color.FromArgb(240,255 ,255); } }
        public Color SharpCadetBlue{ get { return Color.FromArgb(95, 158,160); } }
        public Color SharpCyan{ get { return Color.FromArgb(0, 255,255); } }
        public Color SharpLightCyan{ get { return Color.FromArgb(224, 255,255); } }
        public Color SharpDarkCyan{ get { return Color.FromArgb(0, 139,139); } }
        public Color SharpSlateBlue{ get { return Color.FromArgb(106, 90,205); } }
        public Color SharpLightSlateBlue{ get { return Color.FromArgb(132, 112,255); } }
        public Color SharpMediumSlateBlue{ get { return Color.FromArgb(123, 104,238); } }
        public Color SharpDrakSlateBlue{ get { return Color.FromArgb(72, 61,139); } }
        public Color SharpPowerBlue{ get { return Color.FromArgb(176, 224,230); } }
        public Color SharpSkyBlue{ get { return Color.FromArgb(135, 206,235); } }
        public Color SharpDeepSlateBlue{ get { return Color.FromArgb(0, 191,255); } }
        public Color SharpMindnightBlue{ get { return Color.FromArgb(25, 25,112); } }
        public Color SharpSteelBlue{ get { return Color.FromArgb(70, 130,180); } }
        public Color SharpLightSteelBlue{ get { return Color.FromArgb(176, 196,222); } }
        public Color SharpRoyalBlue{ get { return Color.FromArgb(65, 105,255); } }
        public Color SharpCornflowerBlue{ get { return Color.FromArgb(100, 149,237); } }
        public Color SharpDodgerBlue{ get { return Color.FromArgb(30, 144,255); } }
        public Color SharpBlueViolet{ get { return Color.FromArgb(138, 43,226); } }
        public Color SharpIndigo{ get { return Color.FromArgb(75, 0,130); } }
        public Color Sharppurle{ get { return Color.FromArgb(128, 0,128); } }
        public Color SharpMediumPurple{ get { return Color.FromArgb(147, 112,219); } }
        public Color Sharplavender{ get { return Color.FromArgb(230,230 ,250); } }
        public Color SharpLavenderBlush{ get { return Color.FromArgb(230,230 ,250); } }
        public Color SharpOrchid{ get { return Color.FromArgb(255,240 ,245); } }
        public Color SharpMediumOrchid{ get { return Color.FromArgb(186,85 ,211); } }
        public Color SharpThistle{ get { return Color.FromArgb(153,50 ,204); } }
        public Color SharpPlum{ get { return Color.FromArgb(221,160 ,221); } }
        public Color SharpViolet{ get { return Color.FromArgb(238,130 ,238); } }
        public Color SharpDrakViolet{ get { return Color.FromArgb(148,0 ,211); } }
        public Color SharpMagenta{ get { return Color.FromArgb(255,0 ,255); } }
        public Color SharpDrakMagenta{ get { return Color.FromArgb(139, 0,139); } }
        public Color SharpWhite{ get { return Color.FromArgb(255, 255,255); } }
        public Color SharpAntiqueWhite{ get { return Color.FromArgb(250, 235,215); } }
        public Color SharpFloralWhite{ get { return Color.FromArgb(255, 250,240); } }
        public Color SharpGhostWhite{ get { return Color.FromArgb(248, 248,255); } }
        public Color SharpIvory{ get { return Color.FromArgb(255, 255,240); } }
        public Color SharpNavjoWhite{ get { return Color.FromArgb(255, 222,173); } }
        public Color SharpSnow{ get { return Color.FromArgb(255, 250,255); } }
        public Color SharpWhiteSmoke{ get { return Color.FromArgb(245, 245,245); } }
        public Color SharpGray{ get { return Color.FromArgb(128, 128,128); } }
        public Color SharpDrakGray{ get { return Color.FromArgb(169, 169,139); } }
        public Color SharpDrakSlateGray{ get { return Color.FromArgb(47, 79,79); } }
        public Color SharpDimGray{ get { return Color.FromArgb(105, 105,105); } }
        public Color SharpLightGray{ get { return Color.FromArgb(211, 211,211); } }
        public Color SharpSlateGray{ get { return Color.FromArgb(112, 128,144); } }
        public Color SharpLightSlateGray{ get { return Color.FromArgb(119,136,153); } }
        public Color SharpBrown{ get { return Color.FromArgb(165,42,42); } }
        public Color SharpChocolate{ get { return Color.FromArgb(210, 105,30); } }
        public Color SharpRosyBrown{ get { return Color.FromArgb(188,143,143); } }
        public Color SharpSaddleBrown{ get { return Color.FromArgb(139, 69,19); } }
        public Color SharpSandyBrown{ get { return Color.FromArgb(244,164,96); } }
        public Color SharpSeashell{ get { return Color.FromArgb(255, 245,238); } }
        public Color SharpBeige{ get { return Color.FromArgb(245, 245,220); } }
        public Color SharpLinen{ get { return Color.FromArgb(250, 240,230); } }
        public Color SharpOldLace{ get { return Color.FromArgb(253, 245,230); } }
        public Color SharpWheat{ get { return Color.FromArgb(245, 222,279); } }
        public Color SharpBlanchedAlmond{ get { return Color.FromArgb(255, 235,205); } }


    }
}
