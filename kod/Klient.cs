using System;
using System.Collections.Generic;
namespace Package8 {
	public class Klient : Osoba  {
		private int id;
		private string adres;
		private int telefon;
		private string email;
		private int liczba_wypo�yczonych_urz�dze� = 0;
		private static int max_liczba_wypo�yczonych_urz�dze� = 3; // atrybut max liczba wypo�yczonych urz�dze� z klasy Klient; zgodnie z wymaganiami warto�� pocz�tkowa atrybutu zosta�a ustalona na 3
		private DateTime data_urodzenia = null; // atrybut data_urodzenia z klasy Klient
		

		private static Dictionary<int, Klient> ekstensja = new Dictionary<int, Klient>();
		private int[] kupna;
		private int[] wypo�yczenia;

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

        public static void Zmie�MaxLiczbaWypUrz�dze�() {
			throw new System.Exception("Not implemented");
		}
		public int Zwr��Wiek() {
            if (data_urodzenia == null)
                return -1;
            return DateTime.Now.Year - data_urodzenia.Year;
		} // metoda Zwr��Wiek() z klasy Klient

		


		private Klient(Osoba osoba, int id, string adres, int telefon, string email, int[] kupnaIds, int[] wypo�yczeniaIds) {
			this.osoba = osoba;
			this.id = id;
			this.adres = adres;
			this.telefon = telefon;
			this.email = email;
            this.kupna = kupnaIds;
            this.wypo�yczenia = wypo�yczeniaIds;
            DodajKlienta(id, this);
		}
		public static Klient Utw�rzKlienta(Osoba osoba, int id, string adres, int telefon, string email, DateTime data_urodzenia, int[] kupnaIds, int[] wypo�yczeniaIds) {
			if(osoba == null)
				throw new Exception("Osoba nie istnieje");
			Klient k = new Klient(osoba, id, adres, telefon, email, data_urodzenia, kupnaIds, wypo�yczeniaIds);
			osoba.DodajKlienta(k);
			return k;
		}

        private static void DodajKlienta(int id, Klient klient)
        {
            ekstensja.Add(id, klient);
        }
        private static void Usu�Klienta(int id)
        {
            ekstensja.Remove(id);
        }
        public static Klient Znajd�Klienta(int id) {
            return ekstensja[id];
		}

		

	}

}
