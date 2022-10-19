using Invento.XamarinFormsIconCreator.Pages;

namespace Invento.XamarinFormsIconCreator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }
    }
}