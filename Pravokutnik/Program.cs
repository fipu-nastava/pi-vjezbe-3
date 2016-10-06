using System;

namespace PrimjerSintakse
{
	class Pravokutnik
	{
		// varijable
		double sirina;
		double visina;

		public void PostaviVrijednosti(double a, double b)
		{
			sirina = a;
			visina = b;
		}

		public double IzracunajPovrsinu()
		{
			return sirina * visina;
		}

		public void IspisiRezultate()
		{
			Console.WriteLine("Sirina: {0}", sirina);
			Console.WriteLine("Visina: {0}", visina);
			Console.WriteLine("Povrsina: {0}", IzracunajPovrsinu());
		}
	}

	class GlavniProgram
	{
		static void Main(string[] args)
		{
			Pravokutnik r = new Pravokutnik();
			r.PostaviVrijednosti(4, 5);
			r.IspisiRezultate();
		}
	}
}