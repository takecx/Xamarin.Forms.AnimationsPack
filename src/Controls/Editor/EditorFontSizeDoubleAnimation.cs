using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class EditorFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke Editor FontSize animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Editor).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as Editor).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(EditorFontSizeDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
