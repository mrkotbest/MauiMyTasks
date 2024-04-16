using MauiMyTasks.ViewModel;

namespace MauiMyTasks;

public sealed partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}