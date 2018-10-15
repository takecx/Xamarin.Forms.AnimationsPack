using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class LabelTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Label TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Label).TextColor);

			sender.Animate(nameof(LabelTextColorAnimation), new Animation((d) =>
			{
				(sender as Label).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
