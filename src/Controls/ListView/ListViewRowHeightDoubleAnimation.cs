using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class ListViewRowHeightDoubleAnimation : AnimationBase<int>
	{
		/// <summary>
		/// Invoke ListView RowHeight animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as ListView).RowHeight);

			var animation = new Animation((d) =>
			{
				(sender as ListView).RowHeight = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(ListViewRowHeightDoubleAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
