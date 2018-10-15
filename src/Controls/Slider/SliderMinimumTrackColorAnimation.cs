using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class SliderMinimumTrackColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Slider MinimumTrackColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Slider).MinimumTrackColor);

			sender.Animate(nameof(SliderMinimumTrackColorAnimation), new Animation((d) =>
			{
				(sender as Slider).MinimumTrackColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
