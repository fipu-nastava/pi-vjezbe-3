using System;
namespace Imenik
{
	public class BrojTelefona
	{
		public Vrsta VrstaBroja { get; }
		public String Broj { get; }

		public enum Vrsta { Mobitel, Fiksni, Fax };

		public BrojTelefona()
		{
		}

		public BrojTelefona(Vrsta vrsta, string broj)
		{
			this.VrstaBroja = vrsta;
			this.Broj = broj;
		}
	}
}
