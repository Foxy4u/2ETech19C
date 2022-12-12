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


using System;

namespace karta2
{
  class Produkt {
    public string nazwa;
    public double cena;
    public string opis;
    public void getnazwa() 
    {
      Console.WriteLine("NazwaWlasna");
    }
    public void getcena() 
    {
      Console.WriteLine("500");
    }
    public void getopis() 
    {
      Console.WriteLine("opisnull");
    }
    public void pprodukt(string nazwa, double cena, string opis)
    {
      Console.WriteLine("nain");
    }
  }

  class Profil {
    public string imie;
    public string drugieImie;
    public string nazwisko;
    public void getimie()
    {
      Console.WriteLine("Mateusz");
    }
    public void getnazwisko()
    {
      Console.WriteLine("Piotrowski");
    }
  }

  class Uzytkownik {
    public string login;
    public string haslo;
    public Profil profil;
    public void loguj()
    {
      Console.WriteLine("")
    }
  }

  class Koszyk 
  {
    public int id;
    public Produkt produkt;
    public Uzytkownik uzytkownik;
    public int getId()
    {
		return id;
    }
    public void operation() {
      Console.WriteLine("operacja plastyczna");
    }
  }
}
