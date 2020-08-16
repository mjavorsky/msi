using System;
namespace Package8 {
	public abstract class UrządzenieMobilne : Urządzenie  {
		private double waga;
		private double aparat_przedni;
		private double przekątna_ekranu;
		private string typ_matrycy;
		private string rozdzielczość_ekranu;

        public UrządzenieMobilne(int id, string nazwa, double cena_regularna, string opis, List<string> zdjęcie, string nazwa_systemu_operacyjnego, int szerokość, int długość, int wysokość, string przeznaczenie, int[] kupnaIds, int[] wypożyczeniaIds, double waga, double aparat_przedni,
            double przekątna_ekranu, string typ_matrycy, string rozdzielczość_ekranu) : base(id, nazwa, cena_regularna, opis, zdjęcie, nazwa_systemu_operacyjnego, szerokość, długość, wysokość, przeznaczenie, kupnaIds, wypożyczeniaIds)
        {
            this.waga = waga;
            this.aparat_przedni = aparat_przedni;
            this.przekątna_ekranu = przekątna_ekranu;
            this.typ_matrycy = typ_matrycy;
            this.rozdzielczość_ekranu = rozdzielczość_ekranu;
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

        public double Przekątna_ekranu
        {
            get
            {
                return przekątna_ekranu;
            }

            set
            {
                przekątna_ekranu = value;
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

        public string Rozdzielczość_ekranu
        {
            get
            {
                return rozdzielczość_ekranu;
            }

            set
            {
                rozdzielczość_ekranu = value;
            }
        }

        

	}

}
