using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class EntryPlaceholderColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Entry PlaceholderColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Entry).PlaceholderColor);

			sender.Animate(nameof(EntryPlaceholderColorAnimation), new Animation((d) =>
			{
				(sender as Entry).PlaceholderColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
