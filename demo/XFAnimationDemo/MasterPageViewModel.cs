using System;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using Xamarin.Forms;

namespace XFAnimationDemo
{
	public class MasterPageViewModel : BindableBase
	{
		#region Notifiable Property
		private ObservableCollection<MasterPageItem> _DetailPages = new ObservableCollection<MasterPageItem>();
		public ObservableCollection<MasterPageItem> m_DetailPages
		{
			get { return _DetailPages; }
			set { this.SetProperty(ref this._DetailPages, value); }
		}

		#endregion

		public MasterPageViewModel()
		{
			m_DetailPages.Add(new MasterPageItem { Title = "VisualElement", IconSource = "star.png", TargetType = typeof(VisualElementDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "View", IconSource = "star.png", TargetType = typeof(ViewDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Label", IconSource = "star.png", TargetType = typeof(LabelDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Entry", IconSource = "star.png", TargetType = typeof(EntryDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "ActivityIndicator", IconSource = "star.png", TargetType = typeof(ActivityIndicatorDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "BoxView", IconSource = "star.png", TargetType = typeof(BoxViewDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Button", IconSource = "star.png", TargetType = typeof(ButtonDemo) });
		}
	}
}
