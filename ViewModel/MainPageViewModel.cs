using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiMyTasks.ViewModel;

public sealed partial class MainPageViewModel : ObservableObject
{
	IConnectivity _connectivity;

	[ObservableProperty]
	ObservableCollection<string> _items;

	[ObservableProperty]
	string _text;

	public MainPageViewModel(IConnectivity connectivity)
	{
		Items = [];
		_connectivity = connectivity;
	}

	[RelayCommand]
	async void Add()
	{
		if (string.IsNullOrWhiteSpace(Text))
			return;

		if (_connectivity.NetworkAccess != NetworkAccess.Internet)
		{
			await Shell.Current.DisplayAlert("Uh Oh!", "No Internet Connection", "OK");
			return;
		}

		Items.Add(Text);
		Text = string.Empty;
	}

	[RelayCommand]
	void Remove(string item)
	{
		if (!Items.Contains(item))
			return;
		Items.Remove(item);
	}

	[RelayCommand]
	async Task Tap(string item)
	{
		await Shell.Current.GoToAsync($"{nameof(DetailPage)}?TextStr={item}");
			
			// IF WE WANT TO SHART OBJECTS:

			//new Dictionary<string, object>
			//{
			//	{ nameof(DetailPage), new object() }
			//});
	}
}