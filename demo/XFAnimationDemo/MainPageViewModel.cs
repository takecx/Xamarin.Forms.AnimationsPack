using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Xamarin.Forms;

namespace XFAnimationDemo
{
	public class MainPageViewModel : BindableBase
	{
		#region Property
		private bool _IsAnimationWorking;
		public bool IsAnimationWorking
		{
			get { return _IsAnimationWorking; }
			set { this.SetProperty(ref this._IsAnimationWorking, value); }
		}
		private ObservableCollection<string> _Properties;
		public ObservableCollection<string> Properties
		{
			get { return _Properties; }
			set { this.SetProperty(ref this._Properties, value); }
		}

		#endregion

		#region Commands
		public DelegateCommand RunAnimation { get; private set; }
		#endregion

		public MainPageViewModel()
		{
			// Create commands
			RunAnimation = new DelegateCommand(RunAnimationCommand);

			// Initialize
			IsAnimationWorking = false;
			_Properties = new ObservableCollection<string> { "" };
		}

		private void RunAnimationCommand()
		{
			Task.Run(() =>
			{
				IsAnimationWorking = true;
				Thread.Sleep(2000);
			}).ContinueWith((r) =>
			{
				IsAnimationWorking = false;
			});
		}
	}
}
