using System;
using System.Collections.Generic;
namespace Package8 {
    // typy enumeryczne wykorzystywane w klasie Urz¹dzenie
    public enum Przeznaczenie { kupno, wypo¿yczenie };
    public enum StatusUrz¹dzenia { dostêpny, kupiony, wypo¿yczony };

	public abstract class Urz¹dzenie {
		private int id;
		private string nazwa;
		private double cena_regularna;
		private static int rabat = 0; // atrybut rabat z klasy Urz¹dzenie; jego wartoœæ pocz¹tkowa wynosi 0
		private string opis = null; // atrybut opis z klasy Urz¹dzenie
		private List<string> zdjêcie; // atrybut zdjêcie z klasy Urz¹dzenie
		private string nazwa_systemu_operacyjnego;
		private int szerokoœæ;
		private int d³ugoœæ;
		private int wysokoœæ;
		private Przeznaczenie przeznaczenie; // atrybut przeznaczenie z klasy Urz¹dzenie o typie Przeznaczenie
		private StatusUrz¹dzenia status = StatusUrz¹dzenia.dostêpny; // atrybut status z klasy Urz¹dzenie o typie StatusUrz¹dzenia

        // implementacja ekstensji klasy Urz¹dzenie
        private static Dictionary<int, Urz¹dzenie> ekstensja = new Dictionary<int, Urz¹dzenie>();

		private int[] kupna;
		private int[] wypo¿yczenia;

        public Urz¹dzenie(int id, string nazwa, double cena_regularna, string opis, List<string> zdjêcie, 
            string nazwa_systemu_operacyjnego, int szerokoœæ, int d³ugoœæ, int wysokoœæ, Przeznaczenie przeznaczenie, int[] kupnaIds, int[] wypo¿yczeniaIds)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.cena_regularna = cena_regularna;
            this.opis = opis;
            this.zdjêcie = zdjêcie;
            this.nazwa_systemu_operacyjnego = nazwa_systemu_operacyjnego;
            this.szerokoœæ = szerokoœæ;
            this.d³ugoœæ = d³ugoœæ;
            this.wysokoœæ = wysokoœæ;
            this.przeznaczenie = przeznaczenie;
            this.kupna = kupnaIds;
            this.wypo¿yczenia = wypo¿yczeniaIds;
            DodajUrz¹dzenie(this);
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

        public int Szerokoœæ
        {
            get
            {
                return szerokoœæ;
            }

            set
            {
                szerokoœæ = value;
            }
        }

        public int D³ugoœæ
        {
            get
            {
                return d³ugoœæ;
            }

            set
            {
                d³ugoœæ = value;
            }
        }

        public int Wysokoœæ
        {
            get
            {
                return wysokoœæ;
            }

            set
            {
                wysokoœæ = value;
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

        public StatusUrz¹dzenia Status
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

        public int[] Wypo¿yczenia
        {
            get
            {
                return wypo¿yczenia;
            }

            set
            {
                wypo¿yczenia = value;
            }
        }

        public static List<Urz¹dzenie> Przegl¹dajUrz¹dzenia()
        {
            List<Urz¹dzenie> l = new List<Urz¹dzenie>();
            foreach (var item in ekstensja)
                l.Add(item.Value);
            return l;
        }
        public static List<Urz¹dzenie> Przegl¹dajUrz¹dzenia(Przeznaczenie przeznaczenie)
        {
            List<Urz¹dzenie> l = new List<Urz¹dzenie>();
            foreach (var item in ekstensja)
            {
                if(item.Value.Przeznaczenie == przeznaczenie)
                    l.Add(item.Value);
            }
            return l;
        }

        // metoda ZmieñRabat ustawiaj¹ca wartoœæ atrybutu klasowego Rabat z klasy Urz¹dzenie; metoda sprawdza, czy nowa wartoœæ rabatu nie ró¿ni siê wiêcej ni¿ o 5% aktualnej wartoœci rabatu
        public static void ZmieñRabat(int nowy_rabat) {
			if(nowy_rabat > this.rabat * 1.05 || nowy_rabat < this.rabat * 0.95)
				throw new Exception("Zmiana rabatu wiêksza ni¿ 5%");
			rabat = nowy_rabat;
		}
		public double ZwróæCenêZRabatem() {
			return cena_regularna - rabat * cena_regularna;
        } // metoda ZwróæCenêZRabatem() z klasy Urz¹dzenie
        public void DodajDoListyDostêpnych() {
			throw new System.Exception("Not implemented");
		}
		public void UsuñZListyDostêpnych() {
			throw new System.Exception("Not implemented");
		}



		private static void DodajUrz¹dzenie(int id, Urz¹dzenie urz¹dzenie) {
            ekstensja.Add(id, urz¹dzenie);
		}
		private static void UsuñUrz¹dzenie(int id) {
            ekstensja.Remove(id);
		}
        public static Urz¹dzenie ZnajdŸUrz¹dzenie(int id)
        {
            return ekstensja[id];
        }





    }

}
