using MauiMyTasks.ViewModel;

namespace MauiMyTasks;

public sealed partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}