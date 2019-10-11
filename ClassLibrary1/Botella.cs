using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public abstract class Botella
  {
    protected int capacidadML;
    protected int contenidoML;
    protected string marca;

    public int CapacidadLitros { get { return capacidadML / 1000; } }
    public int Contenido { get { return contenidoML; } }
    public float PorcentajeContenido { get { return contenidoML * 100 / capacidadML; } }

    protected Botella (string marca, int capacidadML, int contenidoML)
    {
      if (contenidoML > capacidadML)
      {
        this.contenidoML = capacidadML;
      }

      else
      {
        this.contenidoML = contenidoML;
      }
    }

    protected string GenerarInforme()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("{0}, {1}, {2}, {3} } ", capacidadML, contenidoML, marca);

      return sb.ToString();
  
    }

    public abstract int ServirMedida();
   
    public override string ToString()
    {
      return GenerarInforme();
    }

     public enum Tipo{ Plastico,Vidrio}
  }
}
