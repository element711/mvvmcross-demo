using Cirrious.MvvmCross.ViewModels;
using MvvmCross_Demo.Core.Managers;
using MvvmCross_Demo.Core.Models;
using MvvmCross_Demo.Core.Persistance;
using System;
using System.Windows.Input;

namespace MvvmCross_Demo.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        public event EventHandler<string> ErrorOccurred;

        #region Properties

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; RaisePropertyChanged(() => Username); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(() => Password); }
        }

		private bool _validUsername = true;
        public bool ValidUsername
        {
            get { return _validUsername; }
            set { _validUsername = value; RaisePropertyChanged(() => ValidUsername); }
        }

		private bool _validPassword = true;
        public bool ValidPassword
        {
            get { return _validPassword; }
            set { _validPassword = value; RaisePropertyChanged(() => ValidPassword); }
        }

        private bool _saveCredentials;
        public bool SaveCredentials
        {
            get { return _saveCredentials; }
            set { _saveCredentials = value; RaisePropertyChanged(() => SaveCredentials); }
        }

        #endregion


        #region Commands

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new MvxCommand(Login);
                }
                return _loginCommand;
            }
        }

        #endregion


        #region Private Fields

        private IAuthenticationManager _authenticationManager;
        private IPersistanceRepository _persistanceRepository;

        #endregion


        #region Lifecycle

        public LoginViewModel(IPersistanceRepository persistanceRepository, IAuthenticationManager authenticationManager)
        {
            _persistanceRepository = persistanceRepository;
            _authenticationManager = authenticationManager;
        }

        public void Init()
        {
            var savedInfo = _persistanceRepository.GetSavedCredentials();
            if (savedInfo != null)
            {
                Username = savedInfo.Username;
                Password = savedInfo.Password;
            }
        }

        #endregion


        #region Command Methods

        private void Login()
        {
			var credentials = new UserCredentials(Username, Password);
			_authenticationManager.Credentials = credentials;

            if (SaveCredentials)
            {
                _persistanceRepository.SaveUserCredentials(credentials);
            }
        }

        #endregion

        private bool ValidateCredentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }
    }
}
