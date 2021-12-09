using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListviewPage : ContentPage
    {
        public ListviewPage()
        {
            InitializeComponent();
            MainListView.ItemsSource = new List<ListViewTemplate>
            {
                new ListViewTemplate
                {
                   Name="first data",
                   Description="first data description",
                   OrderNumber=1
                },
                new ListViewTemplate
                {
                   Name="first data",
                   Description="first data description",
            OrderNumber=2
                },
                new ListViewTemplate
                {
                   Name="first data",
                   Description="first data description",
                    OrderNumber=3
                }
            };
        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
    var Selected = e.Item as ListViewTemplate;
            switch (Selected.OrderNumber)
            {
                case 1:
                    await Navigation.PushAsync(new Page4());
                    break;
                case 2:
                    break;
                case 3:
                    break;
                    default:
                    break;
            }
        }
    }
}