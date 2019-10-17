using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Cantina
  {
    private List<Botella> botellas;
    private static int espaciosTotales;
    private static Cantina singleton;

    public List<Botella> Botellas { get { return botellas; } }

    private Cantina(int espacios)
    {
      botellas = new List<Botella>();
      espaciosTotales = espacios;
      
    }

    public static Cantina GetCantina(int espacios)
    {
      if (singleton == null) {
        singleton = new Cantina(espacios);
      }

      if (singleton != null)
      {
        espaciosTotales = espacios;
      }

      return singleton;
    }

    public static bool operator + (Cantina c, Botella b)
    {
     if (c.botellas.Count<c.botellas.Capacity)
      {
        c.botellas.Add(b);
        return true;
      }
     else
      {
        return false;
      }
    }

   
  }
}
