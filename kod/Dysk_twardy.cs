using System;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie DyskTwardy
    public enum TypDysku { HDD, SSD };

	public class DyskTwardy {
		private TypDysku typ; // atrybut typ z klasy DyskTwardy o typie TypDysku
		private int pojemno��;
		private Urz�dzenie urz�dzenie;

		private DyskTwardy(Urz�dzenie urz�dzenie, TypDysku typ, int pojemno��) {
            this.urz�dzenie = urz�dzenie;
            this.typ = typ;
            this.pojemno�� = pojemno��;
		}
		public DyskTwardy Utw�rzDysk(Urz�dzenie urz�dzenie, TypDysku rodzaj, int szybko��) {
			if(urz�dzenie == null)
				throw new Exception("Urz�dzenie nie istnieje");
			DyskTwardy d = new Dysk_twardy(urz�dzenie, rodzaj, pojemno��);
			urz�dzenie.DodajDysk(d);
			return d;
		}

	}

}
