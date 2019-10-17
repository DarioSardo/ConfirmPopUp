using System;
using System.Collections.Generic;
using System.Text;

namespace ConfirmPopUp
{
    public class User
    {
        string _name;
        string _email;

        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public string Email
        {
            set
            {
                _email = value;
            }
            get
            {
                return _email;
            }
        }
    }
}
