using System;

namespace Pravokutnik
{
	public class Pravokutnik
	{
		// varijable
		double sirina;
		double visina;

		public double Sirina
		{
			get
			{
				return sirina;
			}

			set
			{
				sirina = value;
			}
		}

		// prvi "default" konstruktor
		public Pravokutnik()
		{
		}

		// drugi konstruktor koji prima parametre
		public Pravokutnik(double a, double b)
		{
			this.sirina = a;
			this.visina = b;
		}

		public void PostaviVrijednosti(double a, double b)
		{
			this.sirina = a;
			this.visina = b;
		}

		public double IzracunajPovrsinu()
		{
			return this.sirina * this.visina;
		}

		public void IspisiRezultate()
		{
			Console.WriteLine("Sirina: {0}", sirina);
			Console.WriteLine("Visina: {0}", visina);

			Console.WriteLine("Povrsina: {0}", IzracunajPovrsinu());
		}
	}
}
