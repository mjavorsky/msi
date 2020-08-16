using System;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie Nap�d
    public enum RodzajNap�du { DVD, bluray };

	public class Nap�d {
		private RodzajNap�du rodzaj; // atrybut rodzaj z klasy Nap�d o typie RodzajNap�du
		private int szybko��;
		private Urz�dzenie urz�dzenie;

		private Nap�d(Urz�dzenie urz�dzenie, RodzajNap�du rodzaj, int szybko��) {
			this.urz�dzenie = urz�dzenie;
			this.rodzaj = rodzaj;
			this.szybko�� = szybko��;
		}
		public Nap�d Utw�rzNap�d(Urz�dzenie urz�dzenie, RodzajNap�du rodzaj, int szybko��) {
			if(urz�dzenie == null)
				throw new Exception("Urz�dzenie nie istnieje");
			Nap�d n = new Nap�d(urz�dzenie, rodzaj, szybko��);
			urz�dzenie.DodajNap�d(n);
			return n;
		}

	}

}
