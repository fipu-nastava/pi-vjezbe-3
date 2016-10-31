using System;

namespace Narudzba
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Artikl a1 = new Artikl("Mlijeko 2.5%mm", 2.32);
			Artikl a2 = new Artikl("Kruh Brionka bijeli", 5.44);
			Artikl a3 = new Artikl("Maslac 500g", 10.44);

			Narudzba n1 = new Narudzba(DateTime.Today.AddDays(1));
			n1.DodajStavku(a1, 4);
			n1.DodajStavku(a2, 2);
			n1.DodajStavku(a3, 1);
			n1.Zakljuci();

			n1.Print();
		}
	}
}
