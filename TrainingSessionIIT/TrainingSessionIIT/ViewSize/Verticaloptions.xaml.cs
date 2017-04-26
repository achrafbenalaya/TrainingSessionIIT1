using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingSessionIIT.ViewSize
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verticaloptions : ContentPage
    {
        public Verticaloptions()
        {
            InitializeComponent();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                //Image.ScaleTo(2, 2000);
                //Image.RelScaleTo(1, 1000);
                Image.BackgroundColor =Color.Green;
                Image1.BackgroundColor =Color.Red;

            };
            Image.GestureRecognizers.Add(tapGestureRecognizer);
            Image1.GestureRecognizers.Add(tapGestureRecognizer);

        }

    }

}
