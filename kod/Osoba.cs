using System;
using System.Collections.Generic;
namespace Package8 {
	public class Osoba {
		private List<string> imiê; // atrybut imiê z klasy Osoba
		private string nazwisko;

        private static List<Osoba> ekstensja = new List<Osoba>();

        private Klient klient;
		private Pracownik pracownik;

		private static List<Klient> wszyscyKlienci = new List<Klient>();
		private static List<Pracownik> wszyscyPracownicy = new List<Pracownik>();

        public Osoba(List<string> imiê, string nazwisko)
        {
            this.imiê = imiê;
            this.nazwisko = nazwisko;

            DodajOsobê(this);
        }

        public Klient Klient
        {
            get
            {
                return klient;
            }
        }

        public Pracownik Pracownik
        {
            get
            {
                return pracownik;
            }
        }

        public List<string> Imiê
        {
            get
            {
                return imiê;
            }

            set
            {
                imiê = value;
            }
        }

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }

            set
            {
                nazwisko = value;
            }
        }

        private static void DodajOsobê(Osoba osoba)
        {
            ekstensja.Add(osoba);
        }
        private static void UsuñOsobê(Osoba osoba)
        {
            ekstensja.Remove(osoba);
        }

        
		public void DodajKlienta(Klient klient) {
			if(wszyscyKlienci.Contains(klient))
				throw new Exception("Klient nale¿y ju¿ do innej osoby");
			this.klient = klient;
			wszyscyKlienci.Add(klient);
		}
		public void DodajPracownika(Pracownik pracownik) {
			if(wszyscyPracownicy.Contains(pracownik))
				throw new Exception("Pracownik nale¿y ju¿ do innej osoby");
			this.pracownik = pracownik;
			wszyscyPracownicy.Add(pracownik);
		}

	}

}
