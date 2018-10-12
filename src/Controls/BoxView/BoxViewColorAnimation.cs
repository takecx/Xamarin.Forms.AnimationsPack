using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class BoxViewColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke BoxView Color animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as BoxView).Color);

			sender.Animate(nameof(BoxViewColorAnimation), new Animation((d) =>
			{
				(sender as BoxView).Color = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
