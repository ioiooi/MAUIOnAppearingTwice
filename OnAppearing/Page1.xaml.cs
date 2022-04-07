namespace OnAppearing;

public partial class Page1 : ContentPage
{
	public Page1()
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
}
