using System.Windows.Input;

namespace MauiApp_PageFlow
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Console.WriteLine("==============================================");
            Console.WriteLine("OnAppearing: Page1");
        }

        public ICommand NextPageCommand => new Command(async () =>
        {
            await Application.Current.Dispatcher.DispatchAsync(async () =>
            {
                await Shell.Current.GoToAsync(nameof(Page2));
            });
        });
    }
}
