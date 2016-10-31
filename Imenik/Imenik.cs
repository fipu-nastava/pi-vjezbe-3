using System;
using System.Collections.Generic;

namespace Imenik
{
	public class Imenik
	{
		private List<Kontakt> podaciImenika = new List<Kontakt>();

		public long Total
		{
			get
			{
				return podaciImenika.Count;
			}
		}

		public void DodajKontakt(Kontakt k)
		{
			podaciImenika.Add(k);
		}

		public List<Kontakt> Pretraga(String naziv)
		{
			naziv = naziv.ToLower();

			var rezultatiPretrage = new List<Kontakt>();
			foreach (Kontakt k in podaciImenika)
			{
				if (k.Ime.ToLower().Contains(naziv) || k.Prezime.ToLower().Contains(naziv)) {
					rezultatiPretrage.Add(k);
				}
			}

			return rezultatiPretrage;
		}
	}
}
