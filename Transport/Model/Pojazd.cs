using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class Pojazd
    {
        public int Id { get; set; }
        public string NumerRejestracyjny { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string RodzajPojazdu { get; set; }
        public int RokProdukcji { get; set; }
        public int PojemnoscZaladunku { get; set; }
        public bool CzyJestWydawka { get; set; }
        public bool CzyWlasny { get; set; }

        public Pojazd()
        {

        }
    }
}
