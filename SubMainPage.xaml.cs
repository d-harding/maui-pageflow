using System.Windows.Input;

namespace MauiApp_PageFlow
{
    public partial class SubMainPage : ContentPage
    {
        public SubMainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Console.WriteLine("==============================================");
            Console.WriteLine("OnAppearing: SubMainPage");
        }

        public ICommand MainPageCommand => new Command(async () =>
        {
            await Application.Current.Dispatcher.DispatchAsync(async () =>
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                //await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
            });
        });
    }
}
