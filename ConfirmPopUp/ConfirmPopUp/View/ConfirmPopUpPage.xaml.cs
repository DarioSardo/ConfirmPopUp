﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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