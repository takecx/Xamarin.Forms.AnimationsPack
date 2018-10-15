using System;
using Xamarin.Forms;
using Xamarin.Forms.AnimationsPack.Base;
using Xamarin.Forms.AnimationsPack.Utils;

namespace Xamarin.Forms.AnimationsPack
{
	public class TableViewRowHeightIntAnimation : AnimationBase<int>
	{
		/// <summary>
		/// Invoke TableView RowHeight animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as TableView).RowHeight);

			var animation = new Animation((d) =>
			{
				(sender as TableView).RowHeight = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate(nameof(TableViewRowHeightIntAnimation), animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
