using System.Windows.Input;

namespace MauiApp_PageFlow
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Console.WriteLine("==============================================");
            Console.WriteLine("OnAppearing: Page2");
        }

        public ICommand NextPageCommand => new Command(async () =>
        {
            await Application.Current.Dispatcher.DispatchAsync(async () =>
            {
                await Shell.Current.GoToAsync($"//{nameof(SubMainPage)}");
            });
        });
    }
}
