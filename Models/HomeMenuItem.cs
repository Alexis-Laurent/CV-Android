using System;
using System.Collections.Generic;
using System.Text;

namespace CV_xamarin.Models
{
    public enum MenuItemType
    {
        Accueil,
        Domaines,
        Projets,
        Formations,
        Experiences,
        Contact
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
