using System;
using System.Collections.Generic;

namespace Narudzba
{
	public class Narudzba : Dokument
	{
		private DateTime datumDostave;
		private List<NarudzbaStavka> stavke = new List<NarudzbaStavka>();

		public Narudzba(DateTime dostava) : base()
		{
			this.DatumDostave = dostava;
		}

		public DateTime DatumDostave
		{
			get
			{
				return datumDostave;
			}

			set
			{
				datumDostave = value;
			}
		}

		public List<NarudzbaStavka> Stavke
		{
			get
			{
				return stavke;
			}

			set
			{
				stavke = value;
			}
		}

		public void DodajStavku(Artikl a, int kom)
		{
			var s = new NarudzbaStavka();
			s.ArtiklStavke = a;
			s.Kolicina = kom;

			Stavke.Add(s);
		}

		public void Print()
		{
			Console.WriteLine("Narudzba br: {0}", this.BrojDokumenta);
			Console.WriteLine("Datum narudzbe: {0}", this.Datum);
			Console.WriteLine("Narudžba {0} zaključena", (this.Zakljucen) ? "je" : "nije");

			Console.WriteLine("Stavke:");
			foreach (var s in Stavke)
			{
				Console.WriteLine(" - Artikl: {0}, Cijena: {1},  Količina: {2}", s.ArtiklStavke.Naziv, s.ArtiklStavke.Cijena, s.Kolicina);
			}
		}
	}
}
