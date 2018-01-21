using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControlTemplatesLearning
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        void Handle_Master_Clicked(object sender, System.EventArgs e)
        {
            this.ControlTemplate = (ControlTemplate)App.Current.Resources["ThemeMaster"];

        }

        void Handle_Blue_Clicked(object sender, System.EventArgs e)
        {
            this.ControlTemplate = (ControlTemplate)App.Current.Resources["ThemeBlue"];
        }
    }
}
