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
        public INavigation Navigation { get; set; }
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

        public ConfirmPopUpViewModel()
        {
            _user = new User();
            Title = "Confirm PopUp Example";
            AuthenticateCommand = new Command(async () => await doLoginAsync());
        }

        private async Task doLoginAsync()
        {
            var page = new PopUpOk()
            {
                CallbackMethod = ConfirmPopupEndedWithSuccessAsync
            };
            await Navigation.PushAsync(page);
        }

        private void ConfirmPopupEndedWithSuccessAsync()
        {
            Navigation.PushAsync(new HomePage()).Wait();
        }
    }
}
