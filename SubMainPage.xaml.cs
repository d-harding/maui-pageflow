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
    }
}
