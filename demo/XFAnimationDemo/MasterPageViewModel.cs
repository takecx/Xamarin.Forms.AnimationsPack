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
			m_DetailPages.Add(new MasterPageItem { Title = "(△)ActivityIndicator", IconSource = "star.png", TargetType = typeof(ActivityIndicatorDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "BoxView", IconSource = "star.png", TargetType = typeof(BoxViewDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Button", IconSource = "star.png", TargetType = typeof(ButtonDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "DatePicker", IconSource = "star.png", TargetType = typeof(DatePickerDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Layout", IconSource = "star.png", TargetType = typeof(LayoutDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "(X)Grid", IconSource = "star.png", TargetType = typeof(GridDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "StackLayout", IconSource = "star.png", TargetType = typeof(StackLayoutDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Picker", IconSource = "star.png", TargetType = typeof(PickerDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "ProgressBar", IconSource = "star.png", TargetType = typeof(ProgressBarDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Slider", IconSource = "star.png", TargetType = typeof(SliderDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Switch", IconSource = "star.png", TargetType = typeof(SwitchDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "TimePicker", IconSource = "star.png", TargetType = typeof(TimePickerDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Editor", IconSource = "star.png", TargetType = typeof(EditorDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "(△)ListView", IconSource = "star.png", TargetType = typeof(ListViewDemo) });
			m_DetailPages.Add(new MasterPageItem { Title = "Frame", IconSource = "star.png", TargetType = typeof(FrameDemo) });
		}
	}
}
