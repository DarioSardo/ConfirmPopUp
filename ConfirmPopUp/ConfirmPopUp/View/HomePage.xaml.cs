using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfirmPopUp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
    {
		public HomePage (User user)
		{
			InitializeComponent ();
            BindingContext = new HomePageViewModel(user);
		}
    }
}