using System;
namespace Package8 {
	public abstract class Urz¹dzenieMobilne : Urz¹dzenie  {
		private double waga;
		private double aparat_przedni;
		private double przek¹tna_ekranu;
		private string typ_matrycy;
		private string rozdzielczoœæ_ekranu;

        public Urz¹dzenieMobilne(int id, string nazwa, double cena_regularna, string opis, List<string> zdjêcie, string nazwa_systemu_operacyjnego, int szerokoœæ, int d³ugoœæ, int wysokoœæ, string przeznaczenie, int[] kupnaIds, int[] wypo¿yczeniaIds, double waga, double aparat_przedni,
            double przek¹tna_ekranu, string typ_matrycy, string rozdzielczoœæ_ekranu) : base(id, nazwa, cena_regularna, opis, zdjêcie, nazwa_systemu_operacyjnego, szerokoœæ, d³ugoœæ, wysokoœæ, przeznaczenie, kupnaIds, wypo¿yczeniaIds)
        {
            this.waga = waga;
            this.aparat_przedni = aparat_przedni;
            this.przek¹tna_ekranu = przek¹tna_ekranu;
            this.typ_matrycy = typ_matrycy;
            this.rozdzielczoœæ_ekranu = rozdzielczoœæ_ekranu;
        }

        public double Waga
        {
            get
            {
                return waga;
            }

            set
            {
                waga = value;
            }
        }

        public double Aparat_przedni
        {
            get
            {
                return aparat_przedni;
            }

            set
            {
                aparat_przedni = value;
            }
        }

        public double Przek¹tna_ekranu
        {
            get
            {
                return przek¹tna_ekranu;
            }

            set
            {
                przek¹tna_ekranu = value;
            }
        }

        public string Typ_matrycy
        {
            get
            {
                return typ_matrycy;
            }

            set
            {
                typ_matrycy = value;
            }
        }

        public string Rozdzielczoœæ_ekranu
        {
            get
            {
                return rozdzielczoœæ_ekranu;
            }

            set
            {
                rozdzielczoœæ_ekranu = value;
            }
        }

        

	}

}
