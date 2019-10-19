using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfirmPopUp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfirmPopUpPage : ContentPage
	{
		public ConfirmPopUpPage ()
		{
			InitializeComponent ();
            BindingContext = new ConfirmPopUpViewModel(this);
		}
	}
}