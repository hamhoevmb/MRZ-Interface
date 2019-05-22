using MrzApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrzApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MrzItemPage : ContentPage
	{
		public MrzItemPage ()
		{
			InitializeComponent ();
		}

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (MrzItem)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (MrzItem)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }
    }
}