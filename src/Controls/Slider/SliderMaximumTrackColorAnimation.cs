using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class SliderMaximumTrackColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Slider MaximumTrackColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Slider).MaximumTrackColor);

			sender.Animate(nameof(SliderMaximumTrackColorAnimation), new Animation((d) =>
			{
				(sender as Slider).MaximumTrackColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
