using System;
using System.Collections.Generic;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie KomputerStacjonarny
    public enum TypObudowy { mini, midi, big };

	public class KomputerStacjonarny : Urz¹dzenieStacjonarne  {
		private string obudowa;
		private TypObudowy typ_obudowy; // atrybut typ_obudowy z klasy KomputerStacjonarny o typie TypObudowy
		private int pamiêæ_RAM;
		private string karta_graficzna;
		private string procesor;
		private List<DyskTwardy> dyski = new List<DyskTwardy>();
		private List<Napêd> napêdy = new List<Napêd>();

        private static List<DyskTwardy> wszystkieDyski = new List<DyskTwardy>();
        private static List<Napêd> wszystkieNapêdy = new List<Napêd>();

        public KomputerStacjonarny(int id, string nazwa, double cena_regularna, string opis, List<string> zdjêcie, string nazwa_systemu_operacyjnego, int szerokoœæ, int d³ugoœæ, int wysokoœæ, string przeznaczenie, int[] kupnaIds, int[] wypo¿yczeniaIds, Ustawienie ustawienie, bool monta¿_na_œcianie,
            string obudowa, TypObudowy typ_obudowy, int pamiêæ_RAM, string karta_graficzna, string procesor) : base(id, nazwa, cena_regularna, opis, zdjêcie, nazwa_systemu_operacyjnego, szerokoœæ, d³ugoœæ, wysokoœæ, przeznaczenie, kupnaIds, wypo¿yczeniaIds, ustawienie, monta¿_na_œcianie)
        {
            this.obudowa = obudowa;
            this.typ_obudowy = typ_obudowy;
            this.pamiêæ_RAM = pamiêæ_RAM;
            this.karta_graficzna = karta_graficzna;
            this.procesor = procesor;
        }

        



        public string Obudowa
        {
            get
            {
                return obudowa;
            }

            set
            {
                obudowa = value;
            }
        }

        public TypObudowy Typ_obudowy
        {
            get
            {
                return typ_obudowy;
            }

            set
            {
                typ_obudowy = value;
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

        public static List<DyskTwardy> WszystkieDyski
        {
            get
            {
                return wszystkieDyski;
            }
        }

        public static List<Napêd> WszystkieNapêdy
        {
            get
            {
                return wszystkieNapêdy;
            }
        }

        public void DodajDysk(DyskTwardy dysk) {
            if (!dyski.Contains(dysk))
            {
                if (wszystkieDyski.Contains(dysk))
                    throw new Exception("Ten dysk jest ju¿ powi¹zany z innym urz¹dzeniem");
                dyski.Add(dysk);
                wszystkieDyski.Add(dysk);
            }	
		}
		public void DodajNapêd(Napêd napêd) {
            if (!napêdy.Contains(napêd))
            {
                if (wszystkieNapêdy.Contains(napêd))
                    throw new Exception("Ten napêd jest ju¿ powi¹zany z innym urz¹dzeniem");
                napêdy.Add(napêd);
                wszystkieNapêdy.Add(napêd);
            }
		}

	}

}
