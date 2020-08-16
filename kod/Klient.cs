using System;
using System.Collections.Generic;
namespace Package8 {
	public class Klient : Osoba  {
		private int id;
		private string adres;
		private int telefon;
		private string email;
		private int liczba_wypo¿yczonych_urz¹dzeñ = 0;
		private static int max_liczba_wypo¿yczonych_urz¹dzeñ = 3; // atrybut max liczba wypo¿yczonych urz¹dzeñ z klasy Klient; zgodnie z wymaganiami wartoœæ pocz¹tkowa atrybutu zosta³a ustalona na 3
		private DateTime data_urodzenia = null; // atrybut data_urodzenia z klasy Klient
		

		private static Dictionary<int, Klient> ekstensja = new Dictionary<int, Klient>();
		private int[] kupna;
		private int[] wypo¿yczenia;

		private Osoba osoba;

        public string Adres
        {
            get
            {
                return adres;
            }

            set
            {
                adres = value;
            }
        }

        public int Telefon
        {
            get
            {
                return telefon;
            }

            set
            {
                telefon = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Data_urodzenia
        {
            get
            {
                return data_urodzenia;
            }

            set
            {
                data_urodzenia = value;
            }
        }

        public static void ZmieñMaxLiczbaWypUrz¹dzeñ() {
			throw new System.Exception("Not implemented");
		}
		public int ZwróæWiek() {
            if (data_urodzenia == null)
                return -1;
            return DateTime.Now.Year - data_urodzenia.Year;
		} // metoda ZwróæWiek() z klasy Klient

		


		private Klient(Osoba osoba, int id, string adres, int telefon, string email, int[] kupnaIds, int[] wypo¿yczeniaIds) {
			this.osoba = osoba;
			this.id = id;
			this.adres = adres;
			this.telefon = telefon;
			this.email = email;
            this.kupna = kupnaIds;
            this.wypo¿yczenia = wypo¿yczeniaIds;
            DodajKlienta(id, this);
		}
		public static Klient UtwórzKlienta(Osoba osoba, int id, string adres, int telefon, string email, DateTime data_urodzenia, int[] kupnaIds, int[] wypo¿yczeniaIds) {
			if(osoba == null)
				throw new Exception("Osoba nie istnieje");
			Klient k = new Klient(osoba, id, adres, telefon, email, data_urodzenia, kupnaIds, wypo¿yczeniaIds);
			osoba.DodajKlienta(k);
			return k;
		}

        private static void DodajKlienta(int id, Klient klient)
        {
            ekstensja.Add(id, klient);
        }
        private static void UsuñKlienta(int id)
        {
            ekstensja.Remove(id);
        }
        public static Klient ZnajdŸKlienta(int id) {
            return ekstensja[id];
		}

		

	}

}
