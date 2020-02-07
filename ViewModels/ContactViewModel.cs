using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace CV_xamarin.ViewModels
{
    public class ContactViewModel : BaseViewModel
    {
        public ContactViewModel()
        {
            Title = "CONTACT";

            Open_map = new Command(() => Device.OpenUri(new Uri("https://www.google.fr/maps/place/Avion/@50.4035443,2.8285385,13z/data=!4m5!3m4!1s0x47dd30d1b058c733:0x40af13e816400f0!8m2!3d50.412326!4d2.824277")));
            Open_linkedin = new Command(() => Device.OpenUri(new Uri("https://www.linkedin.com/in/alexis-laurent-0b7939162/")));
            Open_email = new Command(() => Device.OpenUri(new Uri("mailto:Alexis.developpeur@gmail.com")));
            Open_phone = new Command(() => Device.OpenUri(new Uri("tel:+33767172862")));
        }
        public ICommand Open_map { get; }
        public ICommand Open_linkedin { get; }
        public ICommand Open_email { get; }
        public ICommand Open_phone { get; }
    }
}