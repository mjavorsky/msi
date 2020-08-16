using System;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie Napêd
    public enum RodzajNapêdu { DVD, bluray };

	public class Napêd {
		private RodzajNapêdu rodzaj; // atrybut rodzaj z klasy Napêd o typie RodzajNapêdu
		private int szybkoœæ;
		private Urz¹dzenie urz¹dzenie;

		private Napêd(Urz¹dzenie urz¹dzenie, RodzajNapêdu rodzaj, int szybkoœæ) {
			this.urz¹dzenie = urz¹dzenie;
			this.rodzaj = rodzaj;
			this.szybkoœæ = szybkoœæ;
		}
		public Napêd UtwórzNapêd(Urz¹dzenie urz¹dzenie, RodzajNapêdu rodzaj, int szybkoœæ) {
			if(urz¹dzenie == null)
				throw new Exception("Urz¹dzenie nie istnieje");
			Napêd n = new Napêd(urz¹dzenie, rodzaj, szybkoœæ);
			urz¹dzenie.DodajNapêd(n);
			return n;
		}

	}

}
