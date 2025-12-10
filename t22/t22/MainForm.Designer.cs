/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 21/11/2025
 * Time: 02:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace t22
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxnombre = new System.Windows.Forms.TextBox();
			this.txtparcial1 = new System.Windows.Forms.TextBox();
			this.textBoxparcial2 = new System.Windows.Forms.TextBox();
			this.textBoxparcial3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxgrado = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxespecialidad = new System.Windows.Forms.ComboBox();
			this.listViewlista = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxasignatura = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtfechaactual = new System.Windows.Forms.TextBox();
			this.btnregistrar = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtpromediogeneral = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre del alumno:";
			// 
			// textBoxnombre
			// 
			this.textBoxnombre.Location = new System.Drawing.Point(44, 54);
			this.textBoxnombre.Name = "textBoxnombre";
			this.textBoxnombre.Size = new System.Drawing.Size(180, 25);
			this.textBoxnombre.TabIndex = 1;
			this.textBoxnombre.TextChanged += new System.EventHandler(this.TextBoxnombreTextChanged);
			// 
			// txtparcial1
			// 
			this.txtparcial1.Location = new System.Drawing.Point(578, 55);
			this.txtparcial1.Name = "txtparcial1";
			this.txtparcial1.Size = new System.Drawing.Size(30, 25);
			this.txtparcial1.TabIndex = 2;
			this.txtparcial1.TextChanged += new System.EventHandler(this.Txtparcial1TextChanged);
			// 
			// textBoxparcial2
			// 
			this.textBoxparcial2.Location = new System.Drawing.Point(665, 55);
			this.textBoxparcial2.Name = "textBoxparcial2";
			this.textBoxparcial2.Size = new System.Drawing.Size(30, 25);
			this.textBoxparcial2.TabIndex = 3;
			this.textBoxparcial2.TextChanged += new System.EventHandler(this.TextBoxparcial2TextChanged);
			// 
			// textBoxparcial3
			// 
			this.textBoxparcial3.Location = new System.Drawing.Point(747, 54);
			this.textBoxparcial3.Name = "textBoxparcial3";
			this.textBoxparcial3.Size = new System.Drawing.Size(30, 25);
			this.textBoxparcial3.TabIndex = 4;
			this.textBoxparcial3.TextChanged += new System.EventHandler(this.TextBoxparcial3TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(541, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Parcial 1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(638, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Parcial 2";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(735, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Parcial 3";
			// 
			// comboBoxgrado
			// 
			this.comboBoxgrado.FormattingEnabled = true;
			this.comboBoxgrado.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6"});
			this.comboBoxgrado.Location = new System.Drawing.Point(167, 108);
			this.comboBoxgrado.Name = "comboBoxgrado";
			this.comboBoxgrado.Size = new System.Drawing.Size(57, 24);
			this.comboBoxgrado.TabIndex = 8;
			this.comboBoxgrado.SelectedIndexChanged += new System.EventHandler(this.ComboBoxgradoSelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(44, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Grado:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(541, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Especialidad:";
			// 
			// comboBoxespecialidad
			// 
			this.comboBoxespecialidad.FormattingEnabled = true;
			this.comboBoxespecialidad.Items.AddRange(new object[] {
									"Programacion"});
			this.comboBoxespecialidad.Location = new System.Drawing.Point(681, 108);
			this.comboBoxespecialidad.Name = "comboBoxespecialidad";
			this.comboBoxespecialidad.Size = new System.Drawing.Size(145, 24);
			this.comboBoxespecialidad.TabIndex = 11;
			this.comboBoxespecialidad.SelectedIndexChanged += new System.EventHandler(this.ComboBoxespecialidadSelectedIndexChanged);
			// 
			// listViewlista
			// 
			this.listViewlista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listViewlista.Location = new System.Drawing.Point(44, 259);
			this.listViewlista.Name = "listViewlista";
			this.listViewlista.Size = new System.Drawing.Size(818, 172);
			this.listViewlista.TabIndex = 12;
			this.listViewlista.UseCompatibleStateImageBehavior = false;
			this.listViewlista.View = System.Windows.Forms.View.Details;
			this.listViewlista.SelectedIndexChanged += new System.EventHandler(this.ListViewlistaSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Asignatura o Submódulo";
			this.columnHeader1.Width = 233;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial 1";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 2";
			this.columnHeader3.Width = 98;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial 3";
			this.columnHeader4.Width = 111;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Promedio";
			this.columnHeader5.Width = 108;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aprob/Reprob";
			this.columnHeader6.Width = 186;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(44, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(229, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Asignatura o submodulo:";
			// 
			// comboBoxasignatura
			// 
			this.comboBoxasignatura.FormattingEnabled = true;
			this.comboBoxasignatura.Items.AddRange(new object[] {
									"Emplea Frameworks",
									"Metodologías Ágiles ",
									"Inglés ",
									"Lengua y comunicación",
									"Pensamiento Matemático",
									"Ecosistemas"});
			this.comboBoxasignatura.Location = new System.Drawing.Point(279, 149);
			this.comboBoxasignatura.Name = "comboBoxasignatura";
			this.comboBoxasignatura.Size = new System.Drawing.Size(85, 24);
			this.comboBoxasignatura.TabIndex = 14;
			this.comboBoxasignatura.SelectedIndexChanged += new System.EventHandler(this.ComboBoxasignaturaSelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(541, 149);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(188, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Fecha actual:";
			// 
			// txtfechaactual
			// 
			this.txtfechaactual.Location = new System.Drawing.Point(541, 175);
			this.txtfechaactual.Name = "txtfechaactual";
			this.txtfechaactual.Size = new System.Drawing.Size(188, 25);
			this.txtfechaactual.TabIndex = 16;
			this.txtfechaactual.TextChanged += new System.EventHandler(this.TxtfechaactualTextChanged);
			// 
			// btnregistrar
			// 
			this.btnregistrar.Location = new System.Drawing.Point(44, 199);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.Size = new System.Drawing.Size(414, 42);
			this.btnregistrar.TabIndex = 17;
			this.btnregistrar.Text = "Regsitrar";
			this.btnregistrar.UseVisualStyleBackColor = true;
			this.btnregistrar.Click += new System.EventHandler(this.BtnregistrarClick);
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(542, 218);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(153, 23);
			this.btncancelar.TabIndex = 18;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(720, 218);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(106, 23);
			this.btnsalir.TabIndex = 19;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.BtnsalirClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(531, 460);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(183, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "Promedio General:";
			// 
			// txtpromediogeneral
			// 
			this.txtpromediogeneral.Location = new System.Drawing.Point(757, 455);
			this.txtpromediogeneral.Name = "txtpromediogeneral";
			this.txtpromediogeneral.Size = new System.Drawing.Size(130, 25);
			this.txtpromediogeneral.TabIndex = 21;
			this.txtpromediogeneral.TextChanged += new System.EventHandler(this.TxtpromediogeneralTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 492);
			this.Controls.Add(this.txtpromediogeneral);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.txtfechaactual);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBoxasignatura);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.listViewlista);
			this.Controls.Add(this.comboBoxespecialidad);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxgrado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxparcial3);
			this.Controls.Add(this.textBoxparcial2);
			this.Controls.Add(this.txtparcial1);
			this.Controls.Add(this.textBoxnombre);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Minecraft", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Name = "MainForm";
			this.Text = "BOLETA DE CALIFICACIONES";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TextBox txtpromediogeneral;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Button btnregistrar;
		private System.Windows.Forms.TextBox txtfechaactual;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBoxasignatura;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListView listViewlista;
		private System.Windows.Forms.ComboBox comboBoxespecialidad;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxgrado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxparcial3;
		private System.Windows.Forms.TextBox textBoxparcial2;
		private System.Windows.Forms.TextBox txtparcial1;
		private System.Windows.Forms.TextBox textBoxnombre;
		private System.Windows.Forms.Label label1;
		
		
	}
}
