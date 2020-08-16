using System;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie Urz�dzenie_stacjonarne
    public enum Ustawienie { pionowo, poziomo };

	public abstract class Urz�dzenieStacjonarne : Urz�dzenie  {
		private Ustawienie ustawienie; // atrybut ustawienie z klasy Urz�dzenieStacjonarne o typie Ustawienie
		private bool monta�_na_�cianie; // atrybut monta�_na_�cianie z klasy Urz�dzenieStacjonarne o typie bool

        public Urz�dzenieStacjonarne(int id, string nazwa, double cena_regularna, string opis, List<string> zdj�cie, string nazwa_systemu_operacyjnego, int szeroko��, int d�ugo��, int wysoko��, string przeznaczenie, int[] kupnaIds, int[] wypo�yczeniaIds,
            Ustawienie ustawienie, bool monta�_na_�cianie) : base(id, nazwa, cena_regularna, opis, zdj�cie, nazwa_systemu_operacyjnego, szeroko��, d�ugo��, wysoko��, przeznaczenie, kupnaIds, wypo�yczeniaIds)
        {
            this.ustawienie = ustawienie;
            this.monta�_na_�cianie = monta�_na_�cianie;
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

        public bool Monta�_na_�cianie
        {
            get
            {
                return monta�_na_�cianie;
            }

            set
            {
                monta�_na_�cianie = value;
            }
        }
	}

}
