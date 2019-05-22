using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrzApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrzApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MrzPage : ContentPage
	{
        readonly RestService _restService;

        public MrzPage()
        {
            InitializeComponent();
            _restService = new RestService();
        }

        public async void OnGetMrzButtonClicked(object sender, EventArgs e)
        {
            MrzData mrzData = await _restService.GetMrzData();
            BindingContext = mrzData;
        }
    }
}