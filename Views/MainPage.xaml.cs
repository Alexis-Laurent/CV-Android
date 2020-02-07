using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CV_xamarin.Models;

namespace CV_xamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Accueil, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Accueil:
                        MenuPages.Add(id, new NavigationPage(new AccueilPage()));
                        break;
                    case (int)MenuItemType.Domaines:
                        MenuPages.Add(id, new NavigationPage(new DomainesPage()));
                        break;
                    case (int)MenuItemType.Projets:
                        MenuPages.Add(id, new NavigationPage(new ProjetsPage()));
                        break;
                    case (int)MenuItemType.Formations:
                        MenuPages.Add(id, new NavigationPage(new FormationsPage()));
                        break;
                    case (int)MenuItemType.Experiences:
                        MenuPages.Add(id, new NavigationPage(new ExperiencesPage()));
                        break;
                    case (int)MenuItemType.Contact:
                        MenuPages.Add(id, new NavigationPage(new ContactPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}