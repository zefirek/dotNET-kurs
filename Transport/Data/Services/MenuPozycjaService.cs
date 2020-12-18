using System;
using System.Collections.Generic;
using System.Text;
using Transport.Data.Models;

namespace Transport.Data.Services
{
    public class MenuPozycjaService
    {
        private List<MenuPozycja> menuPozycje;
        public MenuPozycjaService()
        {
            menuPozycje = new List<MenuPozycja>();
        }
        public void DodajNowaPozycje(int id, string tekst, string pozycja)
        {
            MenuPozycja menuPozycja = new MenuPozycja(id, tekst) { Pozycja = pozycja };
            menuPozycje.Add(menuPozycja);
        }

    }
}
