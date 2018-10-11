using System;
using Xamarin.Forms;

namespace Xamarin.Forms.AnimationsPack.Utils
{
	public static class AnimationUtil
	{
		public static double CalcCurrentValue(double from, double to, double animationRatio)
		{
			var gap = to - from;
			return from + gap * animationRatio;
		}

		public static Color CalcCurrentValue(Color from, Color to, double animationRatio)
		{
			var rVal = (to.R - from.R) * animationRatio;
			var gVal = (to.G - from.G) * animationRatio;
			var bVal = (to.B - from.B) * animationRatio;
			return Color.FromRgb(from.R + rVal, from.G + gVal, from.B + bVal);
		}

		public static Thickness CalcCurrentValue(Thickness from, Thickness to, double animationRatio)
		{
			return new Thickness(from.Left + (to.Left - from.Left) * animationRatio,
								 from.Top + (to.Top - from.Top) * animationRatio,
								 from.Right + (to.Right - from.Right) * animationRatio,
								 from.Bottom + (to.Bottom - from.Bottom) * animationRatio);
		}

		public static Rectangle CalcCurrentValue(Rectangle from, Rectangle to, double animationRatio)
		{
			return new Rectangle(from.Left + (to.Left - from.Left) * animationRatio,
								 from.Top + (to.Top - from.Top) * animationRatio,
								 from.Right + (to.Right - from.Right) * animationRatio,
								 from.Bottom + (to.Bottom - from.Bottom) * animationRatio);
		}

		public static int CalcCurrentValue(int from, int to, double animationRatio)
		{
			return (int)(from + (to - from) * animationRatio);
		}

		public static CornerRadius CalcCurrentValue(CornerRadius from, CornerRadius to, double animationRatio)
		{
			return new CornerRadius(from.TopLeft + (to.TopLeft - from.TopLeft) * animationRatio,
								   from.TopRight + (to.TopRight - from.TopRight) * animationRatio,
								   from.BottomLeft + (to.BottomLeft - from.BottomLeft) * animationRatio,
									from.BottomRight + (to.BottomRight - from.BottomRight) * animationRatio);
		}

		public static float CalcCurrentValue(float from, float to, double animationRatio)
		{
			return (float)(from + (to - from) * animationRatio);
		}
	}
}
