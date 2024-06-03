using System.Diagnostics;

namespace Recarga.Models;

public partial class Recarga : ContentPage
{
	public Recarga()
	{
		InitializeComponent();
	}
    async void SaveButton_Clicked(object sender, EventArgs args)
    {
        bool answer = await DisplayAlert("Confirmacion", "Desea recargar", "Si", "No");
        Debug.WriteLine("Answer: " + answer);
        if (answer=true)
        {
            await DisplayAlert("Operacion finalizada", "Recarga exitosa", "OK");

        }




    }
}