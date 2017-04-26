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
    public partial class ViewSize : ContentPage
    {
        public ViewSize()
        {
            InitializeComponent();
        }

        private async void rightone(object sender, EventArgs e)
        {
           await pic3.RotateTo(360, 500);
        }

        private async  void Next(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new usinghorzontaloptions());
        }
    }
}
