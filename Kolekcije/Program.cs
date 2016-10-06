using System;
using System.Collections.Generic;

namespace Kolekcije
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			// Primjer koji pretrazuje polje, koristi se Linq
			var voce = new List<String>() { "jabuka", "jagoda", "marelica", "breskva", "banana" };

			// Iteriranje po rezultatima
			foreach (string s in voce)
			{
				Console.WriteLine(s);
			}
		}
	}
}
