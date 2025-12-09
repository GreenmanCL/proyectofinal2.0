/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 08/12/2025
 * Time: 02:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EMPLEADOS
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtcodigo = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbpuesto = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.cbsexo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioinvisible = new System.Windows.Forms.RadioButton();
			this.radioButtonContrato = new System.Windows.Forms.RadioButton();
			this.radioButtonRegular = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnactualizarfoto = new System.Windows.Forms.Button();
			this.btnquitarfoto = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnsubirfoto = new System.Windows.Forms.Button();
			this.btnguardar = new System.Windows.Forms.Button();
			this.btneliminar = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(23, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código Del Empleado:";
			// 
			// txtcodigo
			// 
			this.txtcodigo.Location = new System.Drawing.Point(226, 36);
			this.txtcodigo.Name = "txtcodigo";
			this.txtcodigo.Size = new System.Drawing.Size(100, 29);
			this.txtcodigo.TabIndex = 1;
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(226, 81);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(100, 29);
			this.txtnombre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(23, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre del empleado:";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(23, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Puesto:";
			// 
			// cbpuesto
			// 
			this.cbpuesto.FormattingEnabled = true;
			this.cbpuesto.Items.AddRange(new object[] {
									"Senior",
									"CEO",
									"Beginner",
									"ElPrimo"});
			this.cbpuesto.Location = new System.Drawing.Point(133, 123);
			this.cbpuesto.Name = "cbpuesto";
			this.cbpuesto.Size = new System.Drawing.Size(193, 31);
			this.cbpuesto.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(23, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Fecha de nacimiento:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(209, 164);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(117, 29);
			this.dateTimePicker.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(23, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Sexo:";
			// 
			// cbsexo
			// 
			this.cbsexo.FormattingEnabled = true;
			this.cbsexo.Items.AddRange(new object[] {
									"Hombre",
									"Mujer",
									"Tralalero Tralala",
									"OTRO.. 🏳️‍🌈🤨🤨?????;"});
			this.cbsexo.Location = new System.Drawing.Point(99, 205);
			this.cbsexo.Name = "cbsexo";
			this.cbsexo.Size = new System.Drawing.Size(98, 31);
			this.cbsexo.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(23, 260);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Estado:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioinvisible);
			this.groupBox1.Controls.Add(this.radioButtonContrato);
			this.groupBox1.Controls.Add(this.radioButtonRegular);
			this.groupBox1.Location = new System.Drawing.Point(99, 242);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(337, 61);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// radioinvisible
			// 
			this.radioinvisible.Location = new System.Drawing.Point(6, 18);
			this.radioinvisible.Name = "radioinvisible";
			this.radioinvisible.Size = new System.Drawing.Size(1, 1);
			this.radioinvisible.TabIndex = 2;
			this.radioinvisible.TabStop = true;
			this.radioinvisible.Text = "radioButton3";
			this.radioinvisible.UseVisualStyleBackColor = true;
			// 
			// radioButtonContrato
			// 
			this.radioButtonContrato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButtonContrato.Location = new System.Drawing.Point(163, 29);
			this.radioButtonContrato.Name = "radioButtonContrato";
			this.radioButtonContrato.Size = new System.Drawing.Size(150, 24);
			this.radioButtonContrato.TabIndex = 1;
			this.radioButtonContrato.TabStop = true;
			this.radioButtonContrato.Text = "CONTRATO";
			this.radioButtonContrato.UseVisualStyleBackColor = true;
			// 
			// radioButtonRegular
			// 
			this.radioButtonRegular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButtonRegular.Location = new System.Drawing.Point(7, 28);
			this.radioButtonRegular.Name = "radioButtonRegular";
			this.radioButtonRegular.Size = new System.Drawing.Size(150, 24);
			this.radioButtonRegular.TabIndex = 0;
			this.radioButtonRegular.TabStop = true;
			this.radioButtonRegular.Text = "REGULAR";
			this.radioButtonRegular.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(481, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(294, 164);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// btnactualizarfoto
			// 
			this.btnactualizarfoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnactualizarfoto.Location = new System.Drawing.Point(501, 216);
			this.btnactualizarfoto.Name = "btnactualizarfoto";
			this.btnactualizarfoto.Size = new System.Drawing.Size(104, 45);
			this.btnactualizarfoto.TabIndex = 13;
			this.btnactualizarfoto.Text = "Actualizar";
			this.btnactualizarfoto.UseVisualStyleBackColor = true;
			this.btnactualizarfoto.Click += new System.EventHandler(this.BtnactualizarfotoClick);
			// 
			// btnquitarfoto
			// 
			this.btnquitarfoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnquitarfoto.Location = new System.Drawing.Point(641, 216);
			this.btnquitarfoto.Name = "btnquitarfoto";
			this.btnquitarfoto.Size = new System.Drawing.Size(104, 45);
			this.btnquitarfoto.TabIndex = 14;
			this.btnquitarfoto.Text = "Quitar";
			this.btnquitarfoto.UseVisualStyleBackColor = true;
			this.btnquitarfoto.Click += new System.EventHandler(this.BtnquitarfotoClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6,
									this.Column7});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(35, 333);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(752, 198);
			this.dataGridView1.TabIndex = 15;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Código Del Empleado";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre del Empleado";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Puesto";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Fecha de nacimiento";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Sexo";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Estado";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Foto";
			this.Column7.Name = "Column7";
			// 
			// btnsubirfoto
			// 
			this.btnsubirfoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnsubirfoto.Location = new System.Drawing.Point(568, 85);
			this.btnsubirfoto.Name = "btnsubirfoto";
			this.btnsubirfoto.Size = new System.Drawing.Size(118, 62);
			this.btnsubirfoto.TabIndex = 16;
			this.btnsubirfoto.Text = "SUBIR";
			this.btnsubirfoto.UseVisualStyleBackColor = true;
			this.btnsubirfoto.Click += new System.EventHandler(this.BtnsubirfotoClick);
			// 
			// btnguardar
			// 
			this.btnguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnguardar.Location = new System.Drawing.Point(106, 559);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(133, 34);
			this.btnguardar.TabIndex = 17;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// btneliminar
			// 
			this.btneliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btneliminar.Location = new System.Drawing.Point(309, 559);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(182, 34);
			this.btneliminar.TabIndex = 18;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.UseVisualStyleBackColor = true;
			this.btneliminar.Click += new System.EventHandler(this.BtneliminarClick);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnlimpiar.Location = new System.Drawing.Point(579, 559);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(133, 34);
			this.btnlimpiar.TabIndex = 19;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(825, 605);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btneliminar);
			this.Controls.Add(this.btnguardar);
			this.Controls.Add(this.btnsubirfoto);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnquitarfoto);
			this.Controls.Add(this.btnactualizarfoto);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbsexo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbpuesto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtcodigo);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.Text = "EMPLEADOS";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.Button btneliminar;
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.Button btnsubirfoto;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnquitarfoto;
		private System.Windows.Forms.Button btnactualizarfoto;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton radioButtonRegular;
		private System.Windows.Forms.RadioButton radioButtonContrato;
		private System.Windows.Forms.RadioButton radioinvisible;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbsexo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbpuesto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.TextBox txtcodigo;
		private System.Windows.Forms.Label label1;
	}
}
