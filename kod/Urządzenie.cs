using System;
using System.Collections.Generic;
namespace Package8 {
    // typy enumeryczne wykorzystywane w klasie Urz�dzenie
    public enum Przeznaczenie { kupno, wypo�yczenie };
    public enum StatusUrz�dzenia { dost�pny, kupiony, wypo�yczony };

	public abstract class Urz�dzenie {
		private int id;
		private string nazwa;
		private double cena_regularna;
		private static int rabat = 0; // atrybut rabat z klasy Urz�dzenie; jego warto�� pocz�tkowa wynosi 0
		private string opis = null; // atrybut opis z klasy Urz�dzenie
		private List<string> zdj�cie; // atrybut zdj�cie z klasy Urz�dzenie
		private string nazwa_systemu_operacyjnego;
		private int szeroko��;
		private int d�ugo��;
		private int wysoko��;
		private Przeznaczenie przeznaczenie; // atrybut przeznaczenie z klasy Urz�dzenie o typie Przeznaczenie
		private StatusUrz�dzenia status = StatusUrz�dzenia.dost�pny; // atrybut status z klasy Urz�dzenie o typie StatusUrz�dzenia

        // implementacja ekstensji klasy Urz�dzenie
        private static Dictionary<int, Urz�dzenie> ekstensja = new Dictionary<int, Urz�dzenie>();

		private int[] kupna;
		private int[] wypo�yczenia;

        public Urz�dzenie(int id, string nazwa, double cena_regularna, string opis, List<string> zdj�cie, 
            string nazwa_systemu_operacyjnego, int szeroko��, int d�ugo��, int wysoko��, Przeznaczenie przeznaczenie, int[] kupnaIds, int[] wypo�yczeniaIds)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.cena_regularna = cena_regularna;
            this.opis = opis;
            this.zdj�cie = zdj�cie;
            this.nazwa_systemu_operacyjnego = nazwa_systemu_operacyjnego;
            this.szeroko�� = szeroko��;
            this.d�ugo�� = d�ugo��;
            this.wysoko�� = wysoko��;
            this.przeznaczenie = przeznaczenie;
            this.kupna = kupnaIds;
            this.wypo�yczenia = wypo�yczeniaIds;
            DodajUrz�dzenie(this);
        }

        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {
                nazwa = value;
            }
        }

        public double Cena_regularna
        {
            get
            {
                return cena_regularna;
            }

            set
            {
                cena_regularna = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public string Nazwa_systemu_operacyjnego
        {
            get
            {
                return nazwa_systemu_operacyjnego;
            }

            set
            {
                nazwa_systemu_operacyjnego = value;
            }
        }

        public int Szeroko��
        {
            get
            {
                return szeroko��;
            }

            set
            {
                szeroko�� = value;
            }
        }

        public int D�ugo��
        {
            get
            {
                return d�ugo��;
            }

            set
            {
                d�ugo�� = value;
            }
        }

        public int Wysoko��
        {
            get
            {
                return wysoko��;
            }

            set
            {
                wysoko�� = value;
            }
        }

        public Przeznaczenie Przeznaczenie
        {
            get
            {
                return przeznaczenie;
            }

            set
            {
                przeznaczenie = value;
            }
        }

        public StatusUrz�dzenia Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int[] Kupna
        {
            get
            {
                return kupna;
            }

            set
            {
                kupna = value;
            }
        }

        public int[] Wypo�yczenia
        {
            get
            {
                return wypo�yczenia;
            }

            set
            {
                wypo�yczenia = value;
            }
        }

        public static List<Urz�dzenie> Przegl�dajUrz�dzenia()
        {
            List<Urz�dzenie> l = new List<Urz�dzenie>();
            foreach (var item in ekstensja)
                l.Add(item.Value);
            return l;
        }
        public static List<Urz�dzenie> Przegl�dajUrz�dzenia(Przeznaczenie przeznaczenie)
        {
            List<Urz�dzenie> l = new List<Urz�dzenie>();
            foreach (var item in ekstensja)
            {
                if(item.Value.Przeznaczenie == przeznaczenie)
                    l.Add(item.Value);
            }
            return l;
        }

        // metoda Zmie�Rabat ustawiaj�ca warto�� atrybutu klasowego Rabat z klasy Urz�dzenie; metoda sprawdza, czy nowa warto�� rabatu nie r�ni si� wi�cej ni� o 5% aktualnej warto�ci rabatu
        public static void Zmie�Rabat(int nowy_rabat) {
			if(nowy_rabat > this.rabat * 1.05 || nowy_rabat < this.rabat * 0.95)
				throw new Exception("Zmiana rabatu wi�ksza ni� 5%");
			rabat = nowy_rabat;
		}
		public double Zwr��Cen�ZRabatem() {
			return cena_regularna - rabat * cena_regularna;
        } // metoda Zwr��Cen�ZRabatem() z klasy Urz�dzenie
        public void DodajDoListyDost�pnych() {
			throw new System.Exception("Not implemented");
		}
		public void Usu�ZListyDost�pnych() {
			throw new System.Exception("Not implemented");
		}



		private static void DodajUrz�dzenie(int id, Urz�dzenie urz�dzenie) {
            ekstensja.Add(id, urz�dzenie);
		}
		private static void Usu�Urz�dzenie(int id) {
            ekstensja.Remove(id);
		}
        public static Urz�dzenie Znajd�Urz�dzenie(int id)
        {
            return ekstensja[id];
        }





    }

}
