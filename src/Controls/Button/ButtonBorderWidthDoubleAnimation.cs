using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class ButtonBorderWidthDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke Button BorderWidth animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Button).BorderWidth);

			var animation = new Animation((d) =>
			{
				(sender as Button).BorderWidth = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(ButtonBorderWidthDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
