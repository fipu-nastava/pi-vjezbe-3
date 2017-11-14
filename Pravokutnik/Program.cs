using System;

namespace Pravokutnik
{
	class GlavniProgram
	{
		static void Main(string[] args)
		{
			var r = new Pravokutnik();

			r.Sirina = 4;
			r.Visina = 5;

			r.PostaviVrijednosti(4, 5);
			r.IspisiRezultate();

			//moze i koristeci konstruktor

			Pravokutnik r1 = new Pravokutnik(4, 5);
			r1.IspisiRezultate();
		}
	}
}