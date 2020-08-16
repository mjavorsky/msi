using System;
using System.Collections.Generic;
namespace Package8 {
	public class Laptop : Urz¹dzenie_mobilne  {
		private bool klawiatura_numeryczna; // atrybuty klawiatura_numeryczna oraz podœwietlana_klawiatura z klasy Laptop o typie bool
		private bool podœwietlana_klawiatura;
		private int pamiêæ_RAM;
		private string karta_graficzna;
		private string procesor;
		private List<DyskTwardy> dyski = new List<DyskTwardy>();
		private List<Napêd> napêdy = new List<Napêd>();

        public Laptop(int id, string nazwa, double cena_regularna, string opis, List<string> zdjêcie, string nazwa_systemu_operacyjnego, int szerokoœæ, int d³ugoœæ, int wysokoœæ, string przeznaczenie, int[] kupnaIds, int[] wypo¿yczeniaIds, double waga,
            double aparat_przedni, double przek¹tna_ekranu, string typ_matrycy, string rozdzielczoœæ_ekranu, bool klawiatura_numeryczna, bool podœwietlana_klawiatura, int pamiêæ_RAM, string karta_graficzna, string procesor) : base(id, nazwa, cena_regularna, opis, zdjêcie, nazwa_systemu_operacyjnego, szerokoœæ, d³ugoœæ, wysokoœæ, przeznaczenie, kupnaIds, wypo¿yczeniaIds, waga, aparat_przedni, przek¹tna_ekranu, typ_matrycy, rozdzielczoœæ_ekranu)
        {
            this.klawiatura_numeryczna = klawiatura_numeryczna;
            this.podœwietlana_klawiatura = podœwietlana_klawiatura;
            this.pamiêæ_RAM = pamiêæ_RAM;
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

        public bool Podœwietlana_klawiatura
        {
            get
            {
                return podœwietlana_klawiatura;
            }

            set
            {
                podœwietlana_klawiatura = value;
            }
        }

        public int Pamiêæ_RAM
        {
            get
            {
                return pamiêæ_RAM;
            }

            set
            {
                pamiêæ_RAM = value;
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
                    throw new Exception("Ten dysk jest ju¿ powi¹zany z innym urz¹dzeniem");
                dyski.Add(dysk);
                KomputerStacjonarny.WszystkieDyski.Add(dysk);
            }
        }
        public void DodajNapêd(Napêd napêd)
        {
            if (!napêdy.Contains(napêd))
            {
                if (KomputerStacjonarny.WszystkieNapêdy.Contains(napêd))
                    throw new Exception("Ten napêd jest ju¿ powi¹zany z innym urz¹dzeniem");
                napêdy.Add(napêd);
                KomputerStacjonarny.WszystkieNapêdy.Add(napêd);
            }
        }

    }

}
