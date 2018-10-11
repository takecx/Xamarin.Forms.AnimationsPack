using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class EntryTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Entry TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Entry).TextColor);

			sender.Animate(nameof(EntryTextColorAnimation), new Animation((d) =>
			{
				(sender as Entry).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
