using System;
using System.Collections.Generic;

namespace KolekcijeDictionary
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Definicija "Dictionary" objekta
			var voce = new Dictionary<String, String>();
			voce.Add("V1", "Banana");
			voce.Add("V2", "Jabuka");
			voce.Add("V3", "Breskva");

			// Dohvat
			Console.WriteLine("Pod kljucem V1 nalazi se {0}", voce["V1"]);
		}
	}
}
