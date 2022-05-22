using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraPage : ContentPage
    {
		int currentState = 1;
		string mathOperator;
		double firstNumber, secondNumber;

		public CalculadoraPage()
        {
			InitializeComponent();

        }
        private void AtraparNumero(object sender, EventArgs e)
        {
				Button b = (Button)sender;
				string presionado = b.Text;

				if (this.resultNum.Text == "0" || currentState < 0)
				{
					this.resultNum.Text = "";
					if (currentState < 0)
						currentState *= -1;
				}

				this.resultNum.Text += presionado;

				double number;
				if (double.TryParse(this.resultNum.Text, out number))
				{
					this.resultNum.Text = number.ToString("N0");
					if (currentState == 1)
					{
						firstNumber = number;
					}
					else
					{
						secondNumber = number;
					}
				}
	    }
        private void AtraparOperador(object sender, EventArgs e)
        {
			currentState = -2;
			Button b = (Button)sender;
			string presionado = b.Text;
			mathOperator = presionado;


		}

		private void LimpiarOperador(object sender, EventArgs e)
        {
			firstNumber = 0;
			secondNumber = 0;
			currentState = 1;
			this.resultNum.Text = "0";

        }

		private void AtraparCalculo(object sender, EventArgs e)
		{
			if (currentState == 2)
            {
				var result = SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

				this.resultNum.Text = result.ToString();
				firstNumber = result;
				currentState = -1;
            }
		}

	}
}