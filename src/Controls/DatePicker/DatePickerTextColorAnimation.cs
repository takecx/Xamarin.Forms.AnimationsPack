using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class DatePickerTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke DatePicker TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as DatePicker).TextColor);

			sender.Animate(nameof(DatePickerTextColorAnimation), new Animation((d) =>
			{
				(sender as DatePicker).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
