using System;
using System.Collections.Generic;
namespace Package8 {
	public class Pracownik {
		private int id;
        private string stanowisko;


		private static Dictionary<int, Pracownik> ekstensja = new Dictionary<int, Pracownik>();

		private Osoba osoba;


        public string Stanowisko
        {
            get
            {
                return stanowisko;
            }

            set
            {
                stanowisko = value;
            }
        }

        private Pracownik(Osoba osoba, int id, string stanowisko)
        {
            this.osoba = osoba;
            this.id = id;
            this.stanowisko = stanowisko;
            DodajPracownika(id, this);
        }

  
		
		
		public static Pracownik UtwórzPracownika(Osoba osoba, int id, string stanowisko) {
			if(osoba == null)
				throw new Exception("Osoba nie istnieje");
			Pracownik p = new Pracownik(osoba, id, stanowisko);
			osoba.DodajPracownika(p);
			return p;
		}


		

        private static void DodajPracownika(int id, Pracownik pracownik)
        {
            ekstensja.Add(id, pracownik);
        }
        private static void UsuñPracownika(int id)
        {
            ekstensja.Remove(id);
        }
        public static Pracownik ZnajdŸPracownika(int id)
        {
            return ekstensja[id];
        }

    }

}
