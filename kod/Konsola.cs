using System;
namespace Package8 {
	public class Konsola : Urz�dzenie_stacjonarne  {
		private int generacja;
		private int liczba_kontroler�w;

		public Konsola(int id, string nazwa, double cena_regularna, string opis, List<string> zdj�cie, string nazwa_systemu_operacyjnego, int szeroko��, int d�ugo��, int wysoko��, string przeznaczenie, int[] kupnaIds, int[] wypo�yczeniaIds, 
            Ustawienie ustawienie, bool monta�_na_�cianie, int generacja, int liczba_kontroler�w) : base(id, nazwa, cena_regularna, opis, zdj�cie, nazwa_systemu_operacyjnego, szeroko��, d�ugo��, wysoko��, przeznaczenie, kupnaIds, wypo�yczeniaIds, ustawienie, monta�_na_�cianie) {
            this.generacja = generacja;
            this.liczba_kontroler�w = liczba_kontroler�w;
		}

        public int Generacja
        {
            get
            {
                return generacja;
            }

            set
            {
                generacja = value;
            }
        }

        public int Liczba_kontroler�w
        {
            get
            {
                return liczba_kontroler�w;
            }

            set
            {
                liczba_kontroler�w = value;
            }
        }
    }

}
