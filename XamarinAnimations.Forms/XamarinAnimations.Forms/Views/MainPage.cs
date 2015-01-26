using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAnimations.Forms.Views
{
    public class MainPage : ContentPage
    {
        Label sampleLabel;

        public MainPage()
        {
            sampleLabel = new Label
            {
                Text = "Hello Xamarin.Forms animations!",
                TextColor = Color.Blue,
                XAlign = TextAlignment.Center,
                Opacity = 0
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = 
                {
                    sampleLabel
		        }
            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            sampleLabel.FadeTo(1, 750, Easing.Linear);

            await sampleLabel.ScaleTo(2, 1500, Easing.CubicInOut);
            await sampleLabel.ScaleTo(1, 500, Easing.Linear);
        }
    }
}
