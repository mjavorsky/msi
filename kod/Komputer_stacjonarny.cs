using System;
using System.Collections.Generic;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie KomputerStacjonarny
    public enum TypObudowy { mini, midi, big };

	public class KomputerStacjonarny : Urz�dzenieStacjonarne  {
		private string obudowa;
		private TypObudowy typ_obudowy; // atrybut typ_obudowy z klasy KomputerStacjonarny o typie TypObudowy
		private int pami��_RAM;
		private string karta_graficzna;
		private string procesor;
		private List<DyskTwardy> dyski = new List<DyskTwardy>();
		private List<Nap�d> nap�dy = new List<Nap�d>();

        private static List<DyskTwardy> wszystkieDyski = new List<DyskTwardy>();
        private static List<Nap�d> wszystkieNap�dy = new List<Nap�d>();

        public KomputerStacjonarny(int id, string nazwa, double cena_regularna, string opis, List<string> zdj�cie, string nazwa_systemu_operacyjnego, int szeroko��, int d�ugo��, int wysoko��, string przeznaczenie, int[] kupnaIds, int[] wypo�yczeniaIds, Ustawienie ustawienie, bool monta�_na_�cianie,
            string obudowa, TypObudowy typ_obudowy, int pami��_RAM, string karta_graficzna, string procesor) : base(id, nazwa, cena_regularna, opis, zdj�cie, nazwa_systemu_operacyjnego, szeroko��, d�ugo��, wysoko��, przeznaczenie, kupnaIds, wypo�yczeniaIds, ustawienie, monta�_na_�cianie)
        {
            this.obudowa = obudowa;
            this.typ_obudowy = typ_obudowy;
            this.pami��_RAM = pami��_RAM;
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

        public static List<DyskTwardy> WszystkieDyski
        {
            get
            {
                return wszystkieDyski;
            }
        }

        public static List<Nap�d> WszystkieNap�dy
        {
            get
            {
                return wszystkieNap�dy;
            }
        }

        public void DodajDysk(DyskTwardy dysk) {
            if (!dyski.Contains(dysk))
            {
                if (wszystkieDyski.Contains(dysk))
                    throw new Exception("Ten dysk jest ju� powi�zany z innym urz�dzeniem");
                dyski.Add(dysk);
                wszystkieDyski.Add(dysk);
            }	
		}
		public void DodajNap�d(Nap�d nap�d) {
            if (!nap�dy.Contains(nap�d))
            {
                if (wszystkieNap�dy.Contains(nap�d))
                    throw new Exception("Ten nap�d jest ju� powi�zany z innym urz�dzeniem");
                nap�dy.Add(nap�d);
                wszystkieNap�dy.Add(nap�d);
            }
		}

	}

}
