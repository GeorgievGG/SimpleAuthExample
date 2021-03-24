using SimpleAuthExampleUWP.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleAuthExampleUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            this.ViewModel = new MainPageViewModel();
            this.DataContext = this.ViewModel;
        }

        public MainPageViewModel ViewModel { get; }

        private void OnLoginButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.UpdateLoginNotification();
        }
    }
}
