using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Data.Models
{
    public class MenuPozycja
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
        public string Pozycja { get; set; }

        public MenuPozycja(int id)
        {
            Id = id;
        }

        public MenuPozycja(int id, string tekst)
        {
            Id = id;
            Tekst = tekst;
        }


    }
}
