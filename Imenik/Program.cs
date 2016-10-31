using System;
using System.Collections.Generic;

namespace Imenik
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Imenik i = new Imenik();

			Kontakt k1 = new Kontakt("Hrvoje", "Perić");
			k1.DodajBrojTelefona(BrojTelefona.Vrsta.Fax, "+385522341234");
			k1.DodajBrojTelefona(BrojTelefona.Vrsta.Mobitel, "+38598123498");

			Kontakt k2 = new Kontakt("Ivica", "Marić");
			k2.DodajBrojTelefona(BrojTelefona.Vrsta.Fiksni, "+385522341234");
			k2.DodajBrojTelefona(BrojTelefona.Vrsta.Mobitel, "+38598123498");
			k2.DodajBrojTelefona(BrojTelefona.Vrsta.Mobitel, "+38591153498");

			Kontakt k3 = new Kontakt("Marko", "Nerić");
			k3.DodajBrojTelefona(BrojTelefona.Vrsta.Fiksni, "+38552502734");
			k3.DodajBrojTelefona(BrojTelefona.Vrsta.Mobitel, "+3859777230094");

			i.DodajKontakt(k1);
			i.DodajKontakt(k2);
			i.DodajKontakt(k3);

			String pojam = "mar";
			List<Kontakt> rezultati = i.Pretraga(pojam);

			Console.WriteLine("Pretraga za pojam: '{0}'", pojam);
			Console.WriteLine("Pronađeno {0} kandidata od ukupno {1} kandidata", rezultati.Count, i.Total);
			Console.WriteLine("-----------------------");

			foreach (var r in rezultati)
			{
				String ime = r.Ime;
				String prezime = r.Prezime;

				Console.WriteLine(" - {0} {1}:", ime, prezime);

				foreach (var t in r.BrojeviTelefona)
				{
					Console.WriteLine("      * {0} ({1})", t.Broj, t.VrstaBroja.ToString());
				}
			}
		}
	}
}
