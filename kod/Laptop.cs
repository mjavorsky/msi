using System;
using System.Collections.Generic;
namespace Package8 {
	public class Laptop : Urz�dzenie_mobilne  {
		private bool klawiatura_numeryczna; // atrybuty klawiatura_numeryczna oraz pod�wietlana_klawiatura z klasy Laptop o typie bool
		private bool pod�wietlana_klawiatura;
		private int pami��_RAM;
		private string karta_graficzna;
		private string procesor;
		private List<DyskTwardy> dyski = new List<DyskTwardy>();
		private List<Nap�d> nap�dy = new List<Nap�d>();

        public Laptop(int id, string nazwa, double cena_regularna, string opis, List<string> zdj�cie, string nazwa_systemu_operacyjnego, int szeroko��, int d�ugo��, int wysoko��, string przeznaczenie, int[] kupnaIds, int[] wypo�yczeniaIds, double waga,
            double aparat_przedni, double przek�tna_ekranu, string typ_matrycy, string rozdzielczo��_ekranu, bool klawiatura_numeryczna, bool pod�wietlana_klawiatura, int pami��_RAM, string karta_graficzna, string procesor) : base(id, nazwa, cena_regularna, opis, zdj�cie, nazwa_systemu_operacyjnego, szeroko��, d�ugo��, wysoko��, przeznaczenie, kupnaIds, wypo�yczeniaIds, waga, aparat_przedni, przek�tna_ekranu, typ_matrycy, rozdzielczo��_ekranu)
        {
            this.klawiatura_numeryczna = klawiatura_numeryczna;
            this.pod�wietlana_klawiatura = pod�wietlana_klawiatura;
            this.pami��_RAM = pami��_RAM;
            this.karta_graficzna = karta_graficzna;
            this.procesor = procesor;
        }

        public bool Klawiatura_numeryczna
        {
            get
            {
                return klawiatura_numeryczna;
            }

            set
            {
                klawiatura_numeryczna = value;
            }
        }

        public bool Pod�wietlana_klawiatura
        {
            get
            {
                return pod�wietlana_klawiatura;
            }

            set
            {
                pod�wietlana_klawiatura = value;
            }
        }

        public int Pami��_RAM
        {
            get
            {
                return pami��_RAM;
            }

            set
            {
                pami��_RAM = value;
            }
        }

        public string Karta_graficzna
        {
            get
            {
                return karta_graficzna;
            }

            set
            {
                karta_graficzna = value;
            }
        }

        public string Procesor
        {
            get
            {
                return procesor;
            }

            set
            {
                procesor = value;
            }
        }

        public void DodajDysk(DyskTwardy dysk)
        {
            if (!dyski.Contains(dysk))
            {
                if (KomputerStacjonarny.WszystkieDyski.Contains(dysk))
                    throw new Exception("Ten dysk jest ju� powi�zany z innym urz�dzeniem");
                dyski.Add(dysk);
                KomputerStacjonarny.WszystkieDyski.Add(dysk);
            }
        }
        public void DodajNap�d(Nap�d nap�d)
        {
            if (!nap�dy.Contains(nap�d))
            {
                if (KomputerStacjonarny.WszystkieNap�dy.Contains(nap�d))
                    throw new Exception("Ten nap�d jest ju� powi�zany z innym urz�dzeniem");
                nap�dy.Add(nap�d);
                KomputerStacjonarny.WszystkieNap�dy.Add(nap�d);
            }
        }

    }

}
