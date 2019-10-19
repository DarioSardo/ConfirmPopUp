using System;
using System.Collections.Generic;
using System.Text;

namespace ConfirmPopUp
{
    public class PopUpPageViewModel : BaseViewModel
    {
        string _text;
        string _title;
        User _user;

        public PopUpPageViewModel(User user)
        {
            Title = String.Format("Well done {0}!", user.Name);
            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        public string Body
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }
    }
}
