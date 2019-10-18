using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Agua : Botella
  {
    private const int MEDIDA = 400;

    public Agua(int capacidadML, string marca, int contenidoML) : base( marca,capacidadML, contenidoML)
    {

    }

    protected override string GenerarInforme() {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("{0}, {1}, {2} } ", capacidadML, contenidoML, marca);

      return sb.ToString();

    }

    public override int ServirMedida()
    {
      if (MEDIDA <= contenidoML)
      {
        return MEDIDA;
      }

      else
      {
        return contenidoML;
      }


    }
   
    public int ServirMedida(int medida)
    {
      return medida;
    }


  }
}
