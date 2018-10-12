using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class ProgressBarColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke ProgressBar ProgressColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as ProgressBar).ProgressColor);

			sender.Animate(nameof(ProgressBarColorAnimation), new Animation((d) =>
			{
				(sender as ProgressBar).ProgressColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
