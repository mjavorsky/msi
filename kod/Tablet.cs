using System;
using System.Collections.Generic;
namespace Package8 {
	public class Tablet : Urz�dzenie_mobilne  {
		private bool funkcja_dzwonienia; // atrybut funkcja_dzwonienia z klasy Tablet o typie bool
        private double aparat_tylny;

        public Tablet(int id, string nazwa, double cena_regularna, string opis, List<string> zdj�cie, string nazwa_systemu_operacyjnego, int szeroko��, int d�ugo��, int wysoko��, string przeznaczenie, int[] kupnaIds, int[] wypo�yczeniaIds, double waga,
            double aparat_przedni, double przek�tna_ekranu, string typ_matrycy, string rozdzielczo��_ekranu, bool funkcja_dzwonienia, double aparat_tylny) : base(id, nazwa, cena_regularna, opis, zdj�cie, nazwa_systemu_operacyjnego, szeroko��, d�ugo��, wysoko��, przeznaczenie, kupnaIds, wypo�yczeniaIds, waga, aparat_przedni, przek�tna_ekranu, typ_matrycy, rozdzielczo��_ekranu)
        {
            this.funkcja_dzwonienia = funkcja_dzwonienia;
            this.aparat_tylny = aparat_tylny;
        }

        public bool Funkcja_dzwonienia
        {
            get
            {
                return funkcja_dzwonienia;
            }

            set
            {
                funkcja_dzwonienia = value;
            }
        }

        public double Aparat_tylny
        {
            get
            {
                return aparat_tylny;
            }

            set
            {
                aparat_tylny = value;
            }
        }

        

	}

}
