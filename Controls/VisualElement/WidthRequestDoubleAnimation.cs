using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class WidthRequestDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke VisualElement WidthRequest animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded(sender.WidthRequest);

			sender.Animate(nameof(WidthRequestDoubleAnimation), new Animation((d) =>
			{
				sender.WidthRequest = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
