using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void login(object l,EventArgs e)
        {
            bool ISEmailEmpty = string.IsNullOrEmpty(Username.Text);
            bool ISPwdEmpty=string.IsNullOrEmpty(Password.Text);
            if(ISEmailEmpty || ISPwdEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());

            }
        }

    }
}
