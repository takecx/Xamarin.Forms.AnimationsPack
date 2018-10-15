using System;
using Xamarin.Forms;

namespace Xamarin.Forms.AnimationsPack.Base
{
	public class AnimationBase<T> : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public T From { get; set; } = default(T);
		public T To { get; set; } = default(T);
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		protected override void Invoke(VisualElement sender)
		{
			throw new NotImplementedException("Please Implement Invoke() in derived-class");
		}

		protected void SetDefaultValueIfNeeded(T property)
		{
			From = From.Equals(default(T)) ? property : From;
		}
	}
}
