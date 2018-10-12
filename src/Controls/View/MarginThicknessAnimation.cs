using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class MarginThicknessAnimation : AnimationBase<Thickness>
	{
		/// <summary>
		/// Invoke View Margin Animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as View).Margin);

			sender.Animate(nameof(MarginThicknessAnimation), new Animation((d) =>
			{
				(sender as View).Margin = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
