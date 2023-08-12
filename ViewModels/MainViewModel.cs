﻿using Diseno_Moderno_WPF.Models;
using Diseno_Moderno_WPF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Diseno_Moderno_WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private UserAccountModel _currentUserAccount;
        private IUserRepository userRepository;

        public UserAccountModel CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }
            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }

        //Constructor
        public MainViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            LoadCurrentUserData();
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUserName(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                
                {
                    CurrentUserAccount.Username = user.Username;
                    CurrentUserAccount.DisplayName = $"Welcome {user.Name} {user.LastName}";
                    CurrentUserAccount.ProfilePicture = null;
                };
            }
            else
            {
                CurrentUserAccount.DisplayName = "Invalid user, not logged in";
                
            }
        }
    }
}
