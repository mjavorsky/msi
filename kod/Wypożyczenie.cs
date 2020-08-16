using System;
using System.Collections.Generic;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie Wypo¿yczenie
    public enum StatusWypo¿yczenia { wypo¿yczony, zwrócony };

	public class Wypo¿yczenie : Transakcja  {
        private DateTime data_zwrotu;
		private static int max_czas_wypo¿yczenia = 180; // atrybut max czas wypo¿yczenia z klasy Wypo¿yczenie; zgodnie z wymaganiami jego wartoœæ pocz¹tkowa zosta³a ustalona na 180
		private StatusWypo¿yczenia status_wypo¿yczenia; // atrybut status_wypo¿yczenia z klasy Wypo¿yczenie o typie StatusWypo¿yczenia


        private static Dictionary<int, Wypo¿yczenie> ekstensja = new Dictionary<int, Wypo¿yczenie>(); // ekstensja klasy Wypo¿yczenie
        private int urz¹dzenie;
		private int klient;

        

        public static void ZmieñMaxCzasWypo¿yczenia() {
			throw new System.Exception("Not implemented");
		}
		
		

		public Wypo¿yczenie(int id, DateTime data_transakcji, StatusWypo¿yczenia status_wypo¿yczenia, int urz¹dzenieId, int klientId) : base(id, data_transakcji) {
            this.status_wypo¿yczenia = status_wypo¿yczenia;
            if (Urz¹dzenie.ZnajdŸUrz¹dzenie(urz¹dzenieId).Przeznaczenie != Przeznaczenie.Wypo¿yczenie)
                throw new Exception("Urz¹dzenie nie jest przeznaczone do wypo¿yczenia");
            this.urz¹dzenie = urz¹dzenieId;
            this.klient = klientId;
            DodajWypo¿yczenie(id, this); // dodanie do ekstensji
		}

        private static void DodajWypo¿yczenie(int id, Wypo¿yczenie wypo¿yczenie)
        {
            ekstensja.Add(id, wypo¿yczenie);
        }
        private static void UsuñWypo¿yczenie(int id)
        {
            ekstensja.Remove(id);
        }
        public static Wypo¿yczenie ZnajdŸWypo¿yczenie(int id)
        {
            return ekstensja[id];
        }

        // przes³oniona metoda ZwróæStatus() w klasie Wypo¿yczenie
        public override string ZwróæStatus() {
            return status_wypo¿yczenia.ToString();
		}

        public DateTime Data_zwrotu
        {
            get
            {
                return data_zwrotu;
            }

            set
            {
                data_zwrotu = value;
            }
        }

        public StatusWypo¿yczenia Status_wypo¿yczenia
        {
            set
            {
                status_wypo¿yczenia = value;
            }
        }

        public static int Max_czas_wypo¿yczenia
        {
            get
            {
                return max_czas_wypo¿yczenia;
            }
        }
    }

}
