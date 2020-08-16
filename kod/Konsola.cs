using System;
namespace Package8 {
	public class Konsola : Urz¹dzenie_stacjonarne  {
		private int generacja;
		private int liczba_kontrolerów;

		public Konsola(int id, string nazwa, double cena_regularna, string opis, List<string> zdjêcie, string nazwa_systemu_operacyjnego, int szerokoœæ, int d³ugoœæ, int wysokoœæ, string przeznaczenie, int[] kupnaIds, int[] wypo¿yczeniaIds, 
            Ustawienie ustawienie, bool monta¿_na_œcianie, int generacja, int liczba_kontrolerów) : base(id, nazwa, cena_regularna, opis, zdjêcie, nazwa_systemu_operacyjnego, szerokoœæ, d³ugoœæ, wysokoœæ, przeznaczenie, kupnaIds, wypo¿yczeniaIds, ustawienie, monta¿_na_œcianie) {
            this.generacja = generacja;
            this.liczba_kontrolerów = liczba_kontrolerów;
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

        public int Liczba_kontrolerów
        {
            get
            {
                return liczba_kontrolerów;
            }

            set
            {
                liczba_kontrolerów = value;
            }
        }
    }

}
