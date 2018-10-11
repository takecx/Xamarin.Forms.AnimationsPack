using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class SwitchOnColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Switch OnColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Switch).OnColor);

			sender.Animate(nameof(SwitchOnColorAnimation), new Animation((d) =>
			{
				(sender as Switch).OnColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
