using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace CV_xamarin.ViewModels
{
    public class ProjetsViewModel : BaseViewModel
    {
        public ProjetsViewModel()
        {
            Title = "PROJETS WEB";

            Open_elfoual = new Command(() => Device.OpenUri(new Uri("http://elfouad.fr")));
            Open_girgravure = new Command(() => Device.OpenUri(new Uri("http://girgravure.com")));
        }
        public ICommand Open_elfoual { get; }
        public ICommand Open_girgravure { get; }
    }
}