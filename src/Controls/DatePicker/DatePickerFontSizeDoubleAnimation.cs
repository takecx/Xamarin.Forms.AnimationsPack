using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class DatePickerFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke DatePicker FontSize animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as DatePicker).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as DatePicker).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(DatePickerFontSizeDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
