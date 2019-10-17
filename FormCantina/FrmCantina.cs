using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FrmCantina
{
  public partial class FrmCantina : Form
  {
    private Barra barra = new Barra();
    public FrmCantina()
    {
      InitializeComponent();
    }

   
    private void button1_Click(object sender, EventArgs e)
    {
      
      barra.AgregarBotella(new Botella());
    }

    private void FrmCantina_Load_1(object sender, EventArgs e)
    {
      this.barra.SetCantina = Cantina.GetCantina(10);
      cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
    }

    private void cmbBotellaTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      Botella.Tipo tipo;
      Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
    }
  }
}
