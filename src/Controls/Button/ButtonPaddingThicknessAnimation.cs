using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class ButtonPaddingThicknessAnimation : AnimationBase<Thickness>
	{
		/// <summary>
		/// Invoke Button Padding Animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Button).Padding);

			sender.Animate(nameof(ButtonPaddingThicknessAnimation), new Animation((d) =>
			{
				(sender as Button).Padding = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
