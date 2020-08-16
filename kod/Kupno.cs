using System;
using System.Collections.Generic;
namespace Package8 {
    //typ enumeryczny wykorzystywany w klasie Kupno
    public enum StatusP�atno�ci { nieop�acone, op�acone };

	public class Kupno : Transakcja  {
        private StatusP�atno�ci status_p�atno�ci; // atrybut status_p�atno�ci z klasy Kupno o typie StatusP�atno�ci
		private string metoda_p�atno�ci;
		private string spos�b_dostawy;
		private string daneAdresowe;


        private static Dictionary<int, Kupno> ekstensja = new Dictionary<int, Kupno>(); // ekstensja klasy Kupno
        private int[] urz�dzenia;
		private int klient;

        public StatusP�atno�ci Status_p�atno�ci
        {
            set
            {
                status_p�atno�ci = value;
            }
        }

        public string Metoda_p�atno�ci
        {
            get
            {
                return metoda_p�atno�ci;
            }

            set
            {
                metoda_p�atno�ci = value;
            }
        }

        public string Spos�b_dostawy
        {
            get
            {
                return spos�b_dostawy;
            }

            set
            {
                spos�b_dostawy = value;
            }
        }

        public string DaneAdresowe
        {
            get
            {
                return daneAdresowe;
            }

            set
            {
                daneAdresowe = value;
            }
        }

        public Kupno(int id, DateTime data_transakcji, StatusP�atno�ci status_p�atno�ci, string metoda_p�atno�ci, 
            string spos�b_dostawy, string daneAdresowe, int[] urz�dzeniaIds, int klientId) : base(id, data_transakcji) {
			this.status_p�atno�ci = status_p�atno�ci;
			this.metoda_p�atno�ci = metoda_p�atno�ci;
			this.spos�b_dostawy = spos�b_dostawy;
			this.daneAdresowe = daneAdresowe;
            foreach (int item in urz�dzenia)
                if (Urz�dzenie.Znajd�Urz�dzenie(urz�dzenieId).Przeznaczenie != Przeznaczenie.Kupno)
                    throw new Exception("Niekt�re z urz�dze� nie s� przeznaczone do kupna");
            this.urz�dzenia = urz�dzeniaIds;
			this.klient = klientId;
            DodajKupno(id, this); // dodanie do ekstensji
        }
        private static void DodajKupno(int id, Kupno kupno)
        {
            ekstensja.Add(id, kupno);
        }
        private static void Usu�Kupno(int id)
        {
            ekstensja.Remove(id);
        }
        public static Kupno Znajd�Kupno(int id)
        {
            return ekstensja[id];
        }


        public override string Zwr��Status() {
            return status_p�atno�ci.ToString();
		}

	}

}
