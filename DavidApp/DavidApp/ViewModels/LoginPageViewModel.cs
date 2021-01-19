using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private string username;
        private string password;
        private DelegateCommand _loginCommand;

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            //Title = "Main Page";
            _loginCommand = new DelegateCommand(Login);
        }

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }


        public DelegateCommand LoginCommand => _loginCommand;

        async void Login()
        {
            var parametros = new NavigationParameters();
            parametros.Add("username",username);
            parametros.Add("password", password);

            await NavigationService.NavigateAsync("ListaProdutoPage", parametros);
        }
    }
}
