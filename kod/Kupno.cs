using System;
using System.Collections.Generic;
namespace Package8 {
    //typ enumeryczny wykorzystywany w klasie Kupno
    public enum StatusP³atnoœci { nieop³acone, op³acone };

	public class Kupno : Transakcja  {
        private StatusP³atnoœci status_p³atnoœci; // atrybut status_p³atnoœci z klasy Kupno o typie StatusP³atnoœci
		private string metoda_p³atnoœci;
		private string sposób_dostawy;
		private string daneAdresowe;


        private static Dictionary<int, Kupno> ekstensja = new Dictionary<int, Kupno>(); // ekstensja klasy Kupno
        private int[] urz¹dzenia;
		private int klient;

        public StatusP³atnoœci Status_p³atnoœci
        {
            set
            {
                status_p³atnoœci = value;
            }
        }

        public string Metoda_p³atnoœci
        {
            get
            {
                return metoda_p³atnoœci;
            }

            set
            {
                metoda_p³atnoœci = value;
            }
        }

        public string Sposób_dostawy
        {
            get
            {
                return sposób_dostawy;
            }

            set
            {
                sposób_dostawy = value;
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

        public Kupno(int id, DateTime data_transakcji, StatusP³atnoœci status_p³atnoœci, string metoda_p³atnoœci, 
            string sposób_dostawy, string daneAdresowe, int[] urz¹dzeniaIds, int klientId) : base(id, data_transakcji) {
			this.status_p³atnoœci = status_p³atnoœci;
			this.metoda_p³atnoœci = metoda_p³atnoœci;
			this.sposób_dostawy = sposób_dostawy;
			this.daneAdresowe = daneAdresowe;
            foreach (int item in urz¹dzenia)
                if (Urz¹dzenie.ZnajdŸUrz¹dzenie(urz¹dzenieId).Przeznaczenie != Przeznaczenie.Kupno)
                    throw new Exception("Niektóre z urz¹dzeñ nie s¹ przeznaczone do kupna");
            this.urz¹dzenia = urz¹dzeniaIds;
			this.klient = klientId;
            DodajKupno(id, this); // dodanie do ekstensji
        }
        private static void DodajKupno(int id, Kupno kupno)
        {
            ekstensja.Add(id, kupno);
        }
        private static void UsuñKupno(int id)
        {
            ekstensja.Remove(id);
        }
        public static Kupno ZnajdŸKupno(int id)
        {
            return ekstensja[id];
        }


        public override string ZwróæStatus() {
            return status_p³atnoœci.ToString();
		}

	}

}
