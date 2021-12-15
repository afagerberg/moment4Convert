using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace moment4Convert
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}
		//funktion konvertera och beräkna
		private void OnConverterClicked(object sender, EventArgs e)
		{
			
			// Kontroll om inputfälten är tomma eller inte
			if (!String.IsNullOrEmpty(liters.Text) || !String.IsNullOrEmpty(kilometers.Text))
			{
				// Om de är ifyllda

				//Variabler konvertera och beräkna
				var miles = (1 / 1.609) * int.Parse(kilometers.Text);
				var gallons = (1 / 3.785) * int.Parse(liters.Text);

				var Myresult =  miles / gallons;

				

				//Skriver ut resultat
				result.Text = liters.Text + " liters and " + kilometers.Text + $" kilometers converts to {Math.Round(Myresult, 2)} miles per gallon";
				SemanticScreenReader.Announce(result.Text);
				SemanticScreenReader.Announce(liters.Text = "");
				SemanticScreenReader.Announce(kilometers.Text = "");



				
			}
			else //Om de är tomma - skriv ut ett meddelande
				result.Text = "Write a value in both fields...";
			SemanticScreenReader.Announce(result.Text = result.Text);
		}
	}
}
