using System.Windows.Input;

namespace MauiApp_PageFlow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Console.WriteLine("==============================================");
            Console.WriteLine("OnAppearing: MainPage");
        }

        public ICommand NextPageCommand => new Command(async () =>
        {
            await Application.Current.Dispatcher.DispatchAsync(async () =>
            {
                await Shell.Current.GoToAsync(nameof(Page1));
            });
        });
    }
}
