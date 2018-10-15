using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class TimePickerFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke TimePicker FontSize animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as TimePicker).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as TimePicker).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(TimePickerFontSizeDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
