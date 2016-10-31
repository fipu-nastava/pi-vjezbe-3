using System;
using System.Collections.Generic;

namespace Imenik
{
	public class Kontakt
	{
		public String Ime { get; }
		public String Prezime { get; }

		private List<BrojTelefona> brojeviTelefona = new List<BrojTelefona>();
		public List<BrojTelefona> BrojeviTelefona
		{
			get
			{
				return brojeviTelefona;
			}
		}

		public Kontakt(String ime, String prezime)
		{
			this.Ime = ime;
			this.Prezime = prezime;
		}

		public void DodajBrojTelefona(BrojTelefona.Vrsta vrsta, String broj)
		{
			this.brojeviTelefona.Add(new BrojTelefona(vrsta, broj));
		}
	}
}
