using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFAnimationDemo
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		#region Property
		protected bool _isAnimationWorking;
		public bool IsAnimationWorking
		{
			get { return _isAnimationWorking; }
			set
			{
				_isAnimationWorking = value;
				OnPropertyChanged(nameof(IsAnimationWorking));
			}
		}
		#endregion

		#region Commands
		public ICommand RunAnimation { get; private set; }
		#endregion

		public MainPageViewModel()
		{
			// Create commands
			RunAnimation = new RunAnimationCommand(this);

			// Initialize
			IsAnimationWorking = false;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
