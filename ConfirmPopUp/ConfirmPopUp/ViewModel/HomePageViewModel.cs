namespace ConfirmPopUp
{
    public class HomePageViewModel : BaseViewModel
    {
        User _user;
        string _title;

        public HomePageViewModel(User user)
        {
            _user = new User();
            Title = "Home Page";
            _user = user;
        }


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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }
    }
}
