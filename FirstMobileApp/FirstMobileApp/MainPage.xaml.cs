using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;

namespace FirstMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            message.Text = "Loading item...";

            //MobileServiceClient client = new MobileServiceClient("http://localhost:49366");
            //var items = await client.GetTable<TodoItem>().ReadAsync();
            //var item = items.First();

            message.Text = "Test Android";
        }
    }
}
