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
    private Botella.Tipo tipo;

        public FrmCantina()
    {
      InitializeComponent();
    }

   
    private void button1_Click(object sender, EventArgs e)
    {
            string marca = Marca.Text;
            int capacidad = Convert.ToInt32(Capacidad.Value);
            int contenido = Convert.ToInt32(Contenido.Value);


            if (radioButtonAgua.Checked)
            {

                Agua a = new Agua(capacidad, marca, contenido);
                barra.AgregarBotella(a);
            }

            if (radioButtonCerveza.Checked)
            {

                Cerveza c = new Cerveza(capacidad, marca, tipo, contenido);
                barra.AgregarBotella(c);
            }
        }

    private void FrmCantina_Load_1(object sender, EventArgs e)
    {
      this.barra.SetCantina = Cantina.GetCantina(10);
      cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));

    }

    private void cmbBotellaTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            
    }

        private void Marca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
