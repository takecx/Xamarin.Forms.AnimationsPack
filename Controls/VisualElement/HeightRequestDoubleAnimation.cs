using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class HeightRequestDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke VisualElement HeightRequest animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded(sender.Height);

			sender.Animate(nameof(HeightRequestDoubleAnimation), new Animation((d) =>
			{
				sender.HeightRequest = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
