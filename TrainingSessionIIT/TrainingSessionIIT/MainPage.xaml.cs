using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingSessionIIT.ViewSize;
using Xamarin.Forms;

namespace TrainingSessionIIT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Xamlpageclikced(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CSpageclikced(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Pickerstandadclikced(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void ViewSize(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ViewSize.ViewSize());
        }

        private async void arrange(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new TipCalculator());
        }
    }
}
