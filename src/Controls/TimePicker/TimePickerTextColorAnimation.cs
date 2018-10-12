using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class TimePickerTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke TimePicker TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as TimePicker).TextColor);

			sender.Animate(nameof(TimePickerTextColorAnimation), new Animation((d) =>
			{
				(sender as TimePicker).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
