namespace OnAppearing;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync($"//{nameof(Page2)}");
	}

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync($"//{nameof(Page1)}");
	}
}
