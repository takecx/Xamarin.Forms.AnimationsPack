using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class ListViewSeparatorColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke ListView SeparatorColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as ListView).SeparatorColor);

			sender.Animate(nameof(ListViewSeparatorColorAnimation), new Animation((d) =>
			{
				(sender as ListView).SeparatorColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
