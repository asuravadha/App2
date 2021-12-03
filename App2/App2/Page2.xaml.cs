using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            WebView.Source = "https://www.google.com/";
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await progress.ProgressTo(0.7, 100, Easing.SpringIn);
        }
        protected void OnNavigating(object sender,WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
        }
        protected void OnNavigated(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = false;
        }
    }
}