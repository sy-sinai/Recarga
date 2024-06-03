namespace Recarga.Models;

public partial class Recarga : ContentPage
{
	public Recarga()
	{
		InitializeComponent();
	}
    async void SaveButton_Clicked(object sender, EventArgs args)
    {
        Navigation.PushAsync(new Models.Recarga());
    }
}