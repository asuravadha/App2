using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App2.Model;
using SQLite;

namespace App2
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Title = title_name.Text
            };
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);
           
                if (rows > 0)
                {
                    DisplayAlert("Success", "Title successfully inserted " + rows, "ok");
                }
                else
                {
                    DisplayAlert("Failure", "Title  insertion failed ", "ok");
                }
            }
            
        }
        
    }
}