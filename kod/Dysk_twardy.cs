using System;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie DyskTwardy
    public enum TypDysku { HDD, SSD };

	public class DyskTwardy {
		private TypDysku typ; // atrybut typ z klasy DyskTwardy o typie TypDysku
		private int pojemnoœæ;
		private Urz¹dzenie urz¹dzenie;

		private DyskTwardy(Urz¹dzenie urz¹dzenie, TypDysku typ, int pojemnoœæ) {
            this.urz¹dzenie = urz¹dzenie;
            this.typ = typ;
            this.pojemnoœæ = pojemnoœæ;
		}
		public DyskTwardy UtwórzDysk(Urz¹dzenie urz¹dzenie, TypDysku rodzaj, int szybkoœæ) {
			if(urz¹dzenie == null)
				throw new Exception("Urz¹dzenie nie istnieje");
			DyskTwardy d = new Dysk_twardy(urz¹dzenie, rodzaj, pojemnoœæ);
			urz¹dzenie.DodajDysk(d);
			return d;
		}

	}

}
