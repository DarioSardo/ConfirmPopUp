using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace ConfirmPopUp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopUpOk : PopupPage
	{
		public PopUpOk ()
		{
			InitializeComponent ();
		}

        public delegate void CallbackDelegate();
        public CallbackDelegate CallbackMethod { get; set; }

        private void InvoceCallback()
        {
            CallbackMethod?.Invoke();
        }

        private void OnClose()
        {
            PopupNavigation.Instance.PopAsync();
            InvoceCallback();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}