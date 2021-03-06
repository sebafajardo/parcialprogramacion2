using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Cerveza : Botella
  {
    private const int MEDIDA = 330;
    private Tipo tipo;

    public Cerveza(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
    {

    }

    public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
    {
      this.tipo = tipo;
    }

    protected override string GenerarInforme()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("{0}, {1}, {2}, {3}, {4} } ", capacidadML, contenidoML, marca, tipo);

      return sb.ToString();
    }

    public static implicit operator Tipo(Cerveza cerveza)
    {
      return cerveza.tipo;

    }

    public override int ServirMedida()
    {
      return 80 * MEDIDA / 100;
    }


  }
}
