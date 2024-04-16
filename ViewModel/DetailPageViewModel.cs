using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiMyTasks.ViewModel;

[QueryProperty("Text", "TextStr")]
public sealed partial class DetailPageViewModel : ObservableObject
{
	[ObservableProperty]
	string _text;

	[RelayCommand]
	async Task GoBack()
	{
		await Shell.Current.GoToAsync("..");
	}
}