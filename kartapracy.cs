using System;

namespace karta1
{
	class Producent 
	{
		public string nazwa;
		public string nip;
		public string getNazwa()
		{
			return nazwa;
		}
		public string getNip()
		{
			return nip;
		}
		public void setNazwa()
		{
			Console.WriteLine("Mateusz");
		}
	}

	class Material 
	{
		public string typ;
		public int id;
		public double cena;
		public void settyp()
		{
			Console.WriteLine("Swietny");
		}
		public string gettyp()
		{
			return typ;
		}
		public double getcena()
		{
			return cena;
		}
		public void setid()
		{
			Console.WriteLine("2137420");
		}
	}

	class Rower 
	{
		public Producent producent;
		public string color;
		public Material material;
		public void jedz()
		{
			Console.WriteLine("przod");
		}
		public void setcolor()
		{
			Console.WriteLine("Zielony");
		}
		public string getcolor()
		{
			return color;
		}
	}
}
