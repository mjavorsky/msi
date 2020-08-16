using System;
namespace Package8 {
	public abstract class Urz�dzenieMobilne : Urz�dzenie  {
		private double waga;
		private double aparat_przedni;
		private double przek�tna_ekranu;
		private string typ_matrycy;
		private string rozdzielczo��_ekranu;

        public Urz�dzenieMobilne(int id, string nazwa, double cena_regularna, string opis, List<string> zdj�cie, string nazwa_systemu_operacyjnego, int szeroko��, int d�ugo��, int wysoko��, string przeznaczenie, int[] kupnaIds, int[] wypo�yczeniaIds, double waga, double aparat_przedni,
            double przek�tna_ekranu, string typ_matrycy, string rozdzielczo��_ekranu) : base(id, nazwa, cena_regularna, opis, zdj�cie, nazwa_systemu_operacyjnego, szeroko��, d�ugo��, wysoko��, przeznaczenie, kupnaIds, wypo�yczeniaIds)
        {
            this.waga = waga;
            this.aparat_przedni = aparat_przedni;
            this.przek�tna_ekranu = przek�tna_ekranu;
            this.typ_matrycy = typ_matrycy;
            this.rozdzielczo��_ekranu = rozdzielczo��_ekranu;
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

        public double Przek�tna_ekranu
        {
            get
            {
                return przek�tna_ekranu;
            }

            set
            {
                przek�tna_ekranu = value;
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

        public string Rozdzielczo��_ekranu
        {
            get
            {
                return rozdzielczo��_ekranu;
            }

            set
            {
                rozdzielczo��_ekranu = value;
            }
        }

        

	}

}
