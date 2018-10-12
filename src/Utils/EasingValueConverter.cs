using System;
using Xamarin.Forms;

namespace Xamarin.Forms.AnimationsPack.Utils
{
	public static class EasingValueConverter
	{
		public static Easing Convert(string inEasingStr)
		{
			var easing = inEasingStr.ToLower();
			switch (easing)
			{
				case "bouncein":
					return Easing.BounceIn;
				case "bounceout":
					return Easing.BounceOut;
				case "cubicin":
					return Easing.CubicIn;
				case "cubicout":
					return Easing.CubicOut;
				case "cubicinout":
					return Easing.CubicInOut;
				case "linear":
					return Easing.Linear;
				case "sinin":
					return Easing.SinIn;
				case "sinout":
					return Easing.SinOut;
				case "sininout":
					return Easing.SinInOut;
				case "springin":
					return Easing.SpringIn;
				case "springout":
					return Easing.SpringOut;
				default:
					Console.WriteLine("There is no Easing named " + easing);
					return Easing.Linear;
			}
		}
	}
}
