namespace MauiApp_TARgv23
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            MainPage =new NavigationPage( new AppShell());
        }
    }
}
