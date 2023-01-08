namespace Ohis.MauiBlazor
{
    public partial class App : IApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}