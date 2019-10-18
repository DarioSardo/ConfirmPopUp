﻿using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ConfirmPopUp
{
    public class ConfirmPopUpViewModel : BaseViewModel
    {
        Page _currentPage;
        string _title;
        public ICommand AuthenticateCommand { get; set; }
        User _user;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get
            {
                return _user.Name;
            }
            set
            {
                _user.Name = value;
            }
        }

        public string Email
        {
            get
            {
                return _user.Email;
            }
            set
            {
                _user.Email = value;
            }
        }

        public ConfirmPopUpViewModel(Page currentPage)
        {
            _currentPage = currentPage;
            _user = new User();
            Title = "Confirm PopUp Example";
            AuthenticateCommand = new Command(async () => await doLoginAsync());
        }

        private async Task doLoginAsync()
        {
            var page = new PopUpOk(_user)
            {
                CallbackMethod = ConfirmPopupEndedWithSuccessAsync
            };
            await _currentPage?.Navigation.PushPopupAsync(page);
        }

        private void ConfirmPopupEndedWithSuccessAsync()
        {
            _currentPage?.Navigation.PushAsync(new HomePage());
        }
    }
}
