namespace FrmCantina
{
  partial class FrmCantina
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.label1 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.TextBox();
            this.Capacidad = new System.Windows.Forms.NumericUpDown();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.radioButtonCerveza = new System.Windows.Forms.RadioButton();
            this.radioButtonAgua = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Contenido = new System.Windows.Forms.NumericUpDown();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.Capacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contenido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // Marca
            // 
            this.Marca.Location = new System.Drawing.Point(150, 395);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(143, 20);
            this.Marca.TabIndex = 1;
            this.Marca.TextChanged += new System.EventHandler(this.Marca_TextChanged);
            // 
            // Capacidad
            // 
            this.Capacidad.Location = new System.Drawing.Point(150, 435);
            this.Capacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Capacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Size = new System.Drawing.Size(59, 20);
            this.Capacidad.TabIndex = 2;
            this.Capacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(362, 394);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 3;
            this.cmbBotellaTipo.SelectedIndexChanged += new System.EventHandler(this.cmbBotellaTipo_SelectedIndexChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(364, 421);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(119, 46);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonCerveza
            // 
            this.radioButtonCerveza.AutoSize = true;
            this.radioButtonCerveza.Location = new System.Drawing.Point(27, 399);
            this.radioButtonCerveza.Name = "radioButtonCerveza";
            this.radioButtonCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioButtonCerveza.TabIndex = 6;
            this.radioButtonCerveza.TabStop = true;
            this.radioButtonCerveza.Text = "Cerveza";
            this.radioButtonCerveza.UseVisualStyleBackColor = true;
            // 
            // radioButtonAgua
            // 
            this.radioButtonAgua.AutoSize = true;
            this.radioButtonAgua.Location = new System.Drawing.Point(27, 438);
            this.radioButtonAgua.Name = "radioButtonAgua";
            this.radioButtonAgua.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAgua.TabIndex = 7;
            this.radioButtonAgua.TabStop = true;
            this.radioButtonAgua.Text = "Agua";
            this.radioButtonAgua.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Botella Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Capacidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contenido";
            // 
            // Contenido
            // 
            this.Contenido.Location = new System.Drawing.Point(234, 435);
            this.Contenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Contenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(59, 20);
            this.Contenido.TabIndex = 11;
            this.Contenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 8);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 12;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 497);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonAgua);
            this.Controls.Add(this.radioButtonCerveza);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.Capacidad);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.label1);
            this.Name = "FrmCantina";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCantina_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Capacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox Marca;
    private System.Windows.Forms.NumericUpDown Capacidad;
    private System.Windows.Forms.ComboBox cmbBotellaTipo;
    private System.Windows.Forms.Button buttonAgregar;
    private System.Windows.Forms.RadioButton radioButtonCerveza;
    private System.Windows.Forms.RadioButton radioButtonAgua;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown Contenido;
    private ControlCantina.Barra barra1;
  }
}
