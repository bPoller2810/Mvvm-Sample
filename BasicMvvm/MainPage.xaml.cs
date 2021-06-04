using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicMvvm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HandleAppearing(object sender, EventArgs args)
        {
            _ = Task.Run(_vm.Appearing);
        }
    }
}
