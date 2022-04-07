namespace OnAppearing;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		await Shell.Current.GoToAsync($"//{nameof(Page3)}");
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
	}
}
