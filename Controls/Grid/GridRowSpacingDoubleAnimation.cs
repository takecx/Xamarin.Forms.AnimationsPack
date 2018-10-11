using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class GridRowSpacingDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke Grid RowSpacing animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Grid).RowSpacing);

			var animation = new Animation((d) =>
			{
				(sender as Grid).RowSpacing = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(GridRowSpacingDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
