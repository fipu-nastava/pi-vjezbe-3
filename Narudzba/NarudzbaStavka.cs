using System;
namespace Narudzba
{
	public class NarudzbaStavka : DokumentStavka
	{
		private Artikl artiklStavke;
		public NarudzbaStavka()
		{
		}

		public Artikl ArtiklStavke
		{
			get
			{
				return artiklStavke;
			}

			set
			{
				artiklStavke = value;
			}
		}
	}
}
