using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Classes;
namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
		public List<Contacts> tempdata;

		public Page5 ()
		{
			InitializeComponent ();
			data();
			list.ItemsSource = tempdata;
		}
		public void data()
        {
			tempdata = new List<Contacts>
			{
				new Contacts(){Name="Eswar",Num="123" },
				new Contacts(){Name="anjali",Num="60" },
				new Contacts(){Name="Eswar",Num="123" },
				new Contacts(){Name="Eswar3",Num="321" },
				new Contacts(){Name="Eswar1",Num="123" },
				new Contacts(){Name="anjali2",Num="60" },
				new Contacts(){Name="Eswar",Num="123" },
				new Contacts(){Name="Eswar3",Num="321" },

			};
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
list.ItemsSource = tempdata;
            }
            else
            {
				list.ItemsSource = tempdata.Where(x => x.Name.StartsWith(e.NewTextValue));
            }

        }
    }
}