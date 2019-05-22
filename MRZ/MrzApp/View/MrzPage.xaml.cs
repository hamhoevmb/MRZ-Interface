using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrzApp;
using MrzApp.Data;
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
            MrzDto mrzData = await _restService.GetMrzData();
            BindingContext = mrzData;
            if (mrzData == null)
                await DisplayAlert("Ошибка", "Попробуйте сделать снимок снова...", "OK");
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var mrzDto = (MrzDto)BindingContext;

            var mrzItem = new MrzItem()
            {
                Country = mrzDto.Country,
                DateOfBirth = mrzDto.DateOfBirth,
                Names = mrzDto.Names,
                Nationality = mrzDto.Nationality,
                Number = mrzDto.Number,
                PersonalNumber = mrzDto.PersonalNumber,
                Sex = mrzDto.Sex,
                Surname = mrzDto.Surname
            };

            await App.Database.SaveItemAsync(mrzItem);

            await DisplayAlert("Сохранено", "Данные паспорта удачно сохранены", "OK");
        }
    }
}