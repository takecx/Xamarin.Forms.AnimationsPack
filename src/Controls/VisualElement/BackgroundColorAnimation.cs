// Official Sample
// https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/triggers#enterexit

using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class BackgroundColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke VisualElement BackgroundColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded(sender.BackgroundColor);

			sender.Animate(nameof(BackgroundColorAnimation), new Animation((d) =>
			{
				sender.BackgroundColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
