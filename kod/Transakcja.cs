using System;
namespace Package8 {
	public abstract class Transakcja {
        private int id;
		private DateTime data_transakcji;

		public abstract string ZwróæStatus(); // metoda abstrakcyjna ZwróæStatus() z klasy Transakcja
		public Transakcja(int id, DateTime data_transakcji) {
            this.id = id;
            this.data_transakcji = data_transakcji;
		}
	}
}
