using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthfitness.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class bmicalc : ContentPage
	{
		public bmicalc ()
		{
			InitializeComponent ();
		}

        public void calculateBMI(object sender, System.EventArgs e)
        {
            double h = System.Convert.ToDouble(Height.Text);
            double w = System.Convert.ToDouble(Weight.Text);
            double bmi = (w / h)/h;
            bmi = Math.Round(bmi, 2);
            String category="";
            if (bmi < 18.5)
                category = "Under weight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                category = "Normal";
            else if (bmi >= 25.0 && bmi <= 29.9)
                category = "Overweight";
            else if (bmi >= 30.0 && bmi <= 34.9)
                category = "Class I Obesity";
            else if (bmi >= 35.0 && bmi <= 39.9)
                category = "Class II Obesity";
            else if (bmi >= 40.0 )
                category = "Class III extreme Obesity";

            String fbmi = bmi + "Kg/m2";
            
            yourbmi.Text = fbmi;
            yourCategory.Text = category;



        }
    }
}