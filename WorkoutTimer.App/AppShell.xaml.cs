using System.Windows.Input;

namespace WorkoutTimer.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Settings", typeof(Views.Settings));

            NavigateToSettingsCommand = new Command(async() => {
                //await DisplayAlert("Menu Item", "Settings selected", "OK");
                await GoToAsync("Settings");
                this.FlyoutIsPresented = this.FlyoutBehavior != FlyoutBehavior.Flyout;
            });
            BindingContext = this;
        }

        public ICommand NavigateToSettingsCommand { get; private set; }
    }
}
