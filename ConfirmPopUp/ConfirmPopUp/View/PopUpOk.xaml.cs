using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace ConfirmPopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpOk : PopupPage
    {

        public PopUpOk(User user)
        {
            InitializeComponent();
            BindingContext = new PopUpPageViewModel(user);
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