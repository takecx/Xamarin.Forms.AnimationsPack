using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class LabelLineHeightDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke Label LineHeight animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Label).LineHeight);

			var animation = new Animation((d) =>
			{
				(sender as Label).LineHeight = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(LabelLineHeightDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
