using System;
using System.Collections.Generic;

namespace Kolekcije
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			// Prazna lista
			var prazna = new List<String>();

			// Inicijalizacija liste
			var voce = new List<String>() { "jabuka", "jagoda", "marelica" };

			voce.Add("kruska");

			// Iteriranje po rezultatima
			foreach (string s in voce)
			{
				Console.WriteLine(s);
			}

			Console.ReadKey();
		}
	}
}