using System;
using System.Collections.Generic;
namespace Package8 {
	public class Tablet : Urz¹dzenie_mobilne  {
		private bool funkcja_dzwonienia; // atrybut funkcja_dzwonienia z klasy Tablet o typie bool
        private double aparat_tylny;

        public Tablet(int id, string nazwa, double cena_regularna, string opis, List<string> zdjêcie, string nazwa_systemu_operacyjnego, int szerokoœæ, int d³ugoœæ, int wysokoœæ, string przeznaczenie, int[] kupnaIds, int[] wypo¿yczeniaIds, double waga,
            double aparat_przedni, double przek¹tna_ekranu, string typ_matrycy, string rozdzielczoœæ_ekranu, bool funkcja_dzwonienia, double aparat_tylny) : base(id, nazwa, cena_regularna, opis, zdjêcie, nazwa_systemu_operacyjnego, szerokoœæ, d³ugoœæ, wysokoœæ, przeznaczenie, kupnaIds, wypo¿yczeniaIds, waga, aparat_przedni, przek¹tna_ekranu, typ_matrycy, rozdzielczoœæ_ekranu)
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
