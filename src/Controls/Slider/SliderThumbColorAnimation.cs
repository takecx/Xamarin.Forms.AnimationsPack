using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class SliderThumbColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Slider MinimumTrackColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Slider).ThumbColor);

			sender.Animate(nameof(SliderThumbColorAnimation), new Animation((d) =>
			{
				(sender as Slider).ThumbColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
