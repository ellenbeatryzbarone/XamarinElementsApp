using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinElementsApp.Views;

namespace XamarinElementsApp
{
    public partial class App : Application
    {
      
        public App()
        {
            InitializeComponent();
            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new Elementspage1());
            carouselPage.Children.Add(new ElementsPage2());

            MainPage = carouselPage;
        } 

        protected override void OnSleep()
        {
        }

        protected override void OnStart()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
