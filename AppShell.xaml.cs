using System.Windows.Input;

namespace MauiApp_PageFlow
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;

            RegisterRoute();
        }

        private void RegisterRoute()
        {
            // Generic detail pages
            Routing.RegisterRoute(nameof(Page1), typeof(Page1));
            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"Current: {args?.Current?.Location?.OriginalString}");
            Console.WriteLine($"Target : {args?.Target?.Location?.OriginalString}");

            base.OnNavigating(args);
        }

        public ICommand TestCommand => new Command(async () =>
        {
            await Application.Current.Dispatcher.DispatchAsync(async () =>
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                //await Shell.Current.GoToAsync("..");
            });
        });
    }
}