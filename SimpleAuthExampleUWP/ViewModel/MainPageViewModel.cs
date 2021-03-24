using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleAuthExampleUWP.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _loginNotification;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string LoginNotification
        {
            get => _loginNotification;
            set
            {
                _loginNotification = value;
                OnPropertyChanged(nameof(LoginNotification));
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
