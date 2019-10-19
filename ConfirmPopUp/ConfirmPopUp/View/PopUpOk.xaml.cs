using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace ConfirmPopUp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopUpOk : PopupPage
	{
        string _text;
        string _title;
        User _user;

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

        public PopUpOk (User user)
		{
			InitializeComponent();
            BindingContext = this;
            Title = String.Format("Well done {0}!", user.Name);
            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        }

        public delegate void CallbackDelegate();
        public CallbackDelegate CallbackMethod { get; set; }

        private void InvoceCallback()
        {
            CallbackMethod?.Invoke();
        }

        private void OnClose()
        {
            PopupNavigation.Instance.PopAsync(false);
            InvoceCallback();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}