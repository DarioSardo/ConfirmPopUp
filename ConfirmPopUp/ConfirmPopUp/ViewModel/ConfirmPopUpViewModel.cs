using System;
using System.Collections.Generic;
using System.Text;

namespace ConfirmPopUp
{
    public class ConfirmPopUpViewModel : BaseViewModel
    {
        string _title;

        public User User { get; set; }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public ConfirmPopUpViewModel()
        {
            Title = "Confirm PopUp Example";
        }
    }
}
