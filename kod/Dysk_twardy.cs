using System;
namespace Package8 {
    // typ enumeryczny wykorzystywany w klasie DyskTwardy
    public enum TypDysku { HDD, SSD };

	public class DyskTwardy {
		private TypDysku typ; // atrybut typ z klasy DyskTwardy o typie TypDysku
		private int pojemność;
		private Urządzenie urządzenie;

		private DyskTwardy(Urządzenie urządzenie, TypDysku typ, int pojemność) {
            this.urządzenie = urządzenie;
            this.typ = typ;
            this.pojemność = pojemność;
		}
		public DyskTwardy UtwórzDysk(Urządzenie urządzenie, TypDysku rodzaj, int szybkość) {
			if(urządzenie == null)
				throw new Exception("Urządzenie nie istnieje");
			DyskTwardy d = new Dysk_twardy(urządzenie, rodzaj, pojemność);
			urządzenie.DodajDysk(d);
			return d;
		}

	}

}
