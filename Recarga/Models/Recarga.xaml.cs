using System.Diagnostics;

namespace Recarga.Models;

public partial class Recarga : ContentPage
{
    int uno = 1;
	public Recarga()
	{
		InitializeComponent();
        var monkeyList = new List<string>();
        monkeyList.Add("Tuenti");
        monkeyList.Add("Movistar");
        monkeyList.Add("Claro");
        monkeyList.Add("Maxiplus");
        
        Picker picker = new Picker { Title = "Select a monkey" };
        picker.ItemsSource = monkeyList;
    }

    
    async void SaveButton_Clicked(object sender, EventArgs args)
    {
  
        bool answer = await DisplayAlert("Confirmacion", "Desea recargar", "Si", "No");
        Debug.WriteLine("Answer: " + answer);

      
        if (answer=true)
        {
            await DisplayAlert("Operacion finalizada", "Recarga exitosa", "OK");

        }

        
       StreamWriter archivo = new StreamWriter(@"C:\Users\laboratorio\source\repos\Recarga\Recarga\Archivos\",true);
        await archivo.WriteLineAsync();
        archivo.Close();


    }
}