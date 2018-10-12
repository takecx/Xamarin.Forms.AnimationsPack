using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class ButtonCornerRadiusAnimation : AnimationBase<int>
	{
		/// <summary>
		/// Invoke Button CornerRadius animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Button).CornerRadius);

			sender.Animate(nameof(ButtonCornerRadiusAnimation), new Animation((d) =>
			{
				(sender as Button).CornerRadius = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
