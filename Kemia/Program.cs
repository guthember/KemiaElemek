
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kemia
{
  class Program
  {
    static List<Elem> elemek = new List<Elem>();

    static void Main(string[] args)
    {
      MasodikFeladat();

      Console.ReadKey();
    }

    private static void MasodikFeladat()
    {
      StreamReader be = new StreamReader("felfedezesek.csv");

      be.ReadLine();

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        elemek.Add(new Elem(a[0],a[1],a[2],Convert.ToInt32(a[3]),a[4]));
      }

      be.Close();
    }
  }
}
