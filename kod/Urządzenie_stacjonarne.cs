using System;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie Urz¹dzenie_stacjonarne
    public enum Ustawienie { pionowo, poziomo };

	public abstract class Urz¹dzenieStacjonarne : Urz¹dzenie  {
		private Ustawienie ustawienie; // atrybut ustawienie z klasy Urz¹dzenieStacjonarne o typie Ustawienie
		private bool monta¿_na_œcianie; // atrybut monta¿_na_œcianie z klasy Urz¹dzenieStacjonarne o typie bool

        public Urz¹dzenieStacjonarne(int id, string nazwa, double cena_regularna, string opis, List<string> zdjêcie, string nazwa_systemu_operacyjnego, int szerokoœæ, int d³ugoœæ, int wysokoœæ, string przeznaczenie, int[] kupnaIds, int[] wypo¿yczeniaIds,
            Ustawienie ustawienie, bool monta¿_na_œcianie) : base(id, nazwa, cena_regularna, opis, zdjêcie, nazwa_systemu_operacyjnego, szerokoœæ, d³ugoœæ, wysokoœæ, przeznaczenie, kupnaIds, wypo¿yczeniaIds)
        {
            this.ustawienie = ustawienie;
            this.monta¿_na_œcianie = monta¿_na_œcianie;
        }

        public Ustawienie Ustawienie
        {
            get
            {
                return ustawienie;
            }

            set
            {
                ustawienie = value;
            }
        }

        public bool Monta¿_na_œcianie
        {
            get
            {
                return monta¿_na_œcianie;
            }

            set
            {
                monta¿_na_œcianie = value;
            }
        }
	}

}
