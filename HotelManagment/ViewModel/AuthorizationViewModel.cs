﻿using HotelManagment.Model.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManagment.ViewModel
{
    internal class AuthorizationViewModel : BaseViewModel
    {
        private string _login;
        private string _password;
        private string _buttonSignIn = "Войти";

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string ButtonSignIn
        {
            get => _buttonSignIn;
            set
            {
                _buttonSignIn = value;
                OnPropertyChanged(nameof(ButtonSignIn));
            }
        }

        public async Task<bool> ValidateUserLoginAndPassword()
        {
            try
            {

                ButtonSignIn = "Подождите...";
                using (var context = new HotelDBEntities())
                {
                    var user = await context.HotelAdmin.FirstOrDefaultAsync(u => u.Login == _login && u.Password == _password);

                    if (user != null)
                        return true;
                    else
                    {
                        return false;
                    }

                }
            ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка соединения с базой данных", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }
            finally
            {
                ButtonSignIn = "Войти";
            }

        }
    
    }
}
