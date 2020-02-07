using CV_xamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CV_xamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Accueil, Title="ACCUEIL" },
                new HomeMenuItem {Id = MenuItemType.Domaines, Title="DOMAINES" },
                new HomeMenuItem {Id = MenuItemType.Projets, Title="PROJETS WEB" },
                new HomeMenuItem {Id = MenuItemType.Formations, Title="FORMATIONS" },
                new HomeMenuItem {Id = MenuItemType.Experiences, Title="EXPÉRIENCES" },
                new HomeMenuItem {Id = MenuItemType.Contact, Title="CONTACT" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}