using System;

namespace Vjezba03
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			// korištenje parametara u ispisu
			var ime = "Hrvoje";
			var prezime = "Horvat";
			Console.WriteLine("Hello {0} {1}!", ime, prezime);
		}
	}
}