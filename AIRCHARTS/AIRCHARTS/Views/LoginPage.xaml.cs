﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIRCHARTS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        void RegisterLabel_Tapped(object sender, System.EventArgs args)
        {

            registerStackLayout.IsVisible = true;
            loginStackLayout.IsVisible = false;

        }

        void LoginLabel_Tapped(object sender, System.EventArgs args)
        {

            registerStackLayout.IsVisible = false;
            loginStackLayout.IsVisible = true;

        }
    }
}