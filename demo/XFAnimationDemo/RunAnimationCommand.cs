using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XFAnimationDemo
{
	internal class RunAnimationCommanda : ICommand
	{
		private MainPageViewModel mainPageViewModel;

		public RunAnimationCommanda(MainPageViewModel mainPageViewModel)
		{
			this.mainPageViewModel = mainPageViewModel;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			Task.Run(() =>
			{
				mainPageViewModel.IsAnimationWorking = true;
				Thread.Sleep(2000);
			}).ContinueWith((r) =>
			{
				mainPageViewModel.IsAnimationWorking = false;
			});
		}
	}
}