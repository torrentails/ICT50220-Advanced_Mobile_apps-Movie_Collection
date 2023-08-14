using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieCollection_AlexS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            TestMovieOwner tests = new TestMovieOwner();
            tests.RunTests();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
