using System;
namespace Narucivanje
{
	public class Artikl
	{
		public Artikl(string naziv, double cijena)
		{
			this.Naziv = naziv;
			this.Cijena = cijena;
		}

		private String naziv;
		private double cijena;

		public double Cijena
		{
			get
			{
				return cijena;
			}

			set
			{
				cijena = value;
			}
		}

		public string Naziv
		{
			get
			{
				return naziv;
			}

			set
			{
				naziv = value;
			}
		}
	}
}
