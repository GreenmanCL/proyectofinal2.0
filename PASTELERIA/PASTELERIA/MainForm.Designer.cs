/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 08/12/2025
 * Time: 02:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PASTELERIA
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
			this.pblogo = new System.Windows.Forms.PictureBox();
			this.gpbeleccion = new System.Windows.Forms.GroupBox();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.rdbvacio = new System.Windows.Forms.RadioButton();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.cmbproductos = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lblprecio = new System.Windows.Forms.Label();
			this.lvregistro = new System.Windows.Forms.ListView();
			this.lvProducto = new System.Windows.Forms.ColumnHeader();
			this.lvPrecio = new System.Windows.Forms.ColumnHeader();
			this.lvCantidad = new System.Windows.Forms.ColumnHeader();
			this.lvTotal = new System.Windows.Forms.ColumnHeader();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.btnEliminarProducto = new System.Windows.Forms.Button();
			this.lbltotal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblsubtotal = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtdescuento = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtimportepagado = new System.Windows.Forms.TextBox();
			this.lblimporteneto = new System.Windows.Forms.Label();
			this.lblcambio = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
			this.gpbeleccion.SuspendLayout();
			this.SuspendLayout();
			// 
			// pblogo
			// 
			this.pblogo.Image = ((System.Drawing.Image)(resources.GetObject("pblogo.Image")));
			this.pblogo.Location = new System.Drawing.Point(-2, -3);
			this.pblogo.Name = "pblogo";
			this.pblogo.Size = new System.Drawing.Size(525, 76);
			this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pblogo.TabIndex = 0;
			this.pblogo.TabStop = false;
			// 
			// gpbeleccion
			// 
			this.gpbeleccion.Controls.Add(this.rdbDulce);
			this.gpbeleccion.Controls.Add(this.rdbvacio);
			this.gpbeleccion.Controls.Add(this.rdbSalado);
			this.gpbeleccion.Location = new System.Drawing.Point(149, 79);
			this.gpbeleccion.Name = "gpbeleccion";
			this.gpbeleccion.Size = new System.Drawing.Size(159, 45);
			this.gpbeleccion.TabIndex = 1;
			this.gpbeleccion.TabStop = false;
			// 
			// rdbDulce
			// 
			this.rdbDulce.Location = new System.Drawing.Point(81, 15);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(63, 24);
			this.rdbDulce.TabIndex = 2;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "Dulce";
			this.rdbDulce.UseVisualStyleBackColor = true;
			this.rdbDulce.Click += new System.EventHandler(this.RdbDulceClick);
			// 
			// rdbvacio
			// 
			this.rdbvacio.Location = new System.Drawing.Point(7, 14);
			this.rdbvacio.Name = "rdbvacio";
			this.rdbvacio.Size = new System.Drawing.Size(1, 1);
			this.rdbvacio.TabIndex = 2;
			this.rdbvacio.TabStop = true;
			this.rdbvacio.UseVisualStyleBackColor = true;
			// 
			// rdbSalado
			// 
			this.rdbSalado.Location = new System.Drawing.Point(13, 15);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(70, 24);
			this.rdbSalado.TabIndex = 3;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "Salado";
			this.rdbSalado.UseVisualStyleBackColor = true;
			this.rdbSalado.Click += new System.EventHandler(this.RdbSaladoClick);
			// 
			// cmbproductos
			// 
			this.cmbproductos.FormattingEnabled = true;
			this.cmbproductos.Location = new System.Drawing.Point(230, 138);
			this.cmbproductos.Name = "cmbproductos";
			this.cmbproductos.Size = new System.Drawing.Size(109, 24);
			this.cmbproductos.TabIndex = 3;
			this.cmbproductos.SelectedIndexChanged += new System.EventHandler(this.CmbproductosSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(78, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Seleccionar Producto:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(23, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Precio:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(113, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Cantidad:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(210, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Total:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(113, 214);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(82, 22);
			this.txtCantidad.TabIndex = 8;
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			// 
			// lblprecio
			// 
			this.lblprecio.BackColor = System.Drawing.Color.White;
			this.lblprecio.ForeColor = System.Drawing.Color.Black;
			this.lblprecio.Location = new System.Drawing.Point(24, 214);
			this.lblprecio.Name = "lblprecio";
			this.lblprecio.Size = new System.Drawing.Size(83, 22);
			this.lblprecio.TabIndex = 10;
			this.lblprecio.Text = "0";
			this.lblprecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lvregistro
			// 
			this.lvregistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.lvProducto,
									this.lvPrecio,
									this.lvCantidad,
									this.lvTotal});
			this.lvregistro.Location = new System.Drawing.Point(23, 252);
			this.lvregistro.Name = "lvregistro";
			this.lvregistro.Size = new System.Drawing.Size(417, 97);
			this.lvregistro.TabIndex = 11;
			this.lvregistro.UseCompatibleStateImageBehavior = false;
			this.lvregistro.View = System.Windows.Forms.View.Details;
			// 
			// lvProducto
			// 
			this.lvProducto.Text = "Producto";
			this.lvProducto.Width = 196;
			// 
			// lvPrecio
			// 
			this.lvPrecio.Text = "Precio";
			this.lvPrecio.Width = 67;
			// 
			// lvCantidad
			// 
			this.lvCantidad.Text = "Cantidad";
			this.lvCantidad.Width = 70;
			// 
			// lvTotal
			// 
			this.lvTotal.Text = "Total";
			this.lvTotal.Width = 102;
			// 
			// btnAgregarProducto
			// 
			this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
			this.btnAgregarProducto.Location = new System.Drawing.Point(353, 185);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(126, 23);
			this.btnAgregarProducto.TabIndex = 12;
			this.btnAgregarProducto.Text = "Agregar Producto";
			this.btnAgregarProducto.UseVisualStyleBackColor = true;
			this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProductoClick);
			// 
			// btnEliminarProducto
			// 
			this.btnEliminarProducto.ForeColor = System.Drawing.Color.Black;
			this.btnEliminarProducto.Location = new System.Drawing.Point(353, 223);
			this.btnEliminarProducto.Name = "btnEliminarProducto";
			this.btnEliminarProducto.Size = new System.Drawing.Size(126, 23);
			this.btnEliminarProducto.TabIndex = 13;
			this.btnEliminarProducto.Text = "Eliminar Producto";
			this.btnEliminarProducto.UseVisualStyleBackColor = true;
			this.btnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProductoClick);
			// 
			// lbltotal
			// 
			this.lbltotal.BackColor = System.Drawing.Color.White;
			this.lbltotal.ForeColor = System.Drawing.Color.Black;
			this.lbltotal.Location = new System.Drawing.Point(210, 214);
			this.lbltotal.Name = "lbltotal";
			this.lbltotal.Size = new System.Drawing.Size(100, 23);
			this.lbltotal.TabIndex = 14;
			this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 365);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Subtotal:";
			// 
			// lblsubtotal
			// 
			this.lblsubtotal.BackColor = System.Drawing.Color.White;
			this.lblsubtotal.ForeColor = System.Drawing.Color.Black;
			this.lblsubtotal.Location = new System.Drawing.Point(70, 364);
			this.lblsubtotal.Name = "lblsubtotal";
			this.lblsubtotal.Size = new System.Drawing.Size(79, 23);
			this.lblsubtotal.TabIndex = 16;
			this.lblsubtotal.Text = "0";
			this.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(158, 367);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Descuento:";
			// 
			// txtdescuento
			// 
			this.txtdescuento.Location = new System.Drawing.Point(230, 365);
			this.txtdescuento.Name = "txtdescuento";
			this.txtdescuento.Size = new System.Drawing.Size(87, 22);
			this.txtdescuento.TabIndex = 18;
			this.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtdescuento.TextChanged += new System.EventHandler(this.TxtdescuentoTextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(323, 365);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "Importe Neto:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(317, 388);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "Importe Pagado:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(351, 422);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Cambio:";
			// 
			// txtimportepagado
			// 
			this.txtimportepagado.Location = new System.Drawing.Point(417, 391);
			this.txtimportepagado.Name = "txtimportepagado";
			this.txtimportepagado.Size = new System.Drawing.Size(94, 22);
			this.txtimportepagado.TabIndex = 22;
			this.txtimportepagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtimportepagado.TextChanged += new System.EventHandler(this.TxtimportepagadoTextChanged);
			// 
			// lblimporteneto
			// 
			this.lblimporteneto.BackColor = System.Drawing.Color.White;
			this.lblimporteneto.ForeColor = System.Drawing.Color.Black;
			this.lblimporteneto.Location = new System.Drawing.Point(417, 362);
			this.lblimporteneto.Name = "lblimporteneto";
			this.lblimporteneto.Size = new System.Drawing.Size(94, 22);
			this.lblimporteneto.TabIndex = 23;
			this.lblimporteneto.Text = "0";
			this.lblimporteneto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblcambio
			// 
			this.lblcambio.BackColor = System.Drawing.Color.White;
			this.lblcambio.ForeColor = System.Drawing.Color.Black;
			this.lblcambio.Location = new System.Drawing.Point(417, 419);
			this.lblcambio.Name = "lblcambio";
			this.lblcambio.Size = new System.Drawing.Size(94, 23);
			this.lblcambio.TabIndex = 25;
			this.lblcambio.Text = "0";
			this.lblcambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGuardar
			// 
			this.btnGuardar.ForeColor = System.Drawing.Color.Black;
			this.btnGuardar.Location = new System.Drawing.Point(32, 419);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 27;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnBorrar
			// 
			this.btnBorrar.ForeColor = System.Drawing.Color.Black;
			this.btnBorrar.Location = new System.Drawing.Point(120, 419);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 29;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnImprimir
			// 
			this.btnImprimir.ForeColor = System.Drawing.Color.Black;
			this.btnImprimir.Location = new System.Drawing.Point(218, 419);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 30;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(523, 462);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblcambio);
			this.Controls.Add(this.lblimporteneto);
			this.Controls.Add(this.txtimportepagado);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtdescuento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblsubtotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbltotal);
			this.Controls.Add(this.btnEliminarProducto);
			this.Controls.Add(this.btnAgregarProducto);
			this.Controls.Add(this.lvregistro);
			this.Controls.Add(this.lblprecio);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbproductos);
			this.Controls.Add(this.gpbeleccion);
			this.Controls.Add(this.pblogo);
			this.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "PASTELERIA";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
			this.gpbeleccion.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblcambio;
		private System.Windows.Forms.Label lblimporteneto;
		private System.Windows.Forms.TextBox txtimportepagado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtdescuento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblsubtotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbltotal;
		private System.Windows.Forms.Button btnEliminarProducto;
		private System.Windows.Forms.Button btnAgregarProducto;
		private System.Windows.Forms.ColumnHeader lvTotal;
		private System.Windows.Forms.ColumnHeader lvCantidad;
		private System.Windows.Forms.ColumnHeader lvPrecio;
		private System.Windows.Forms.ColumnHeader lvProducto;
		private System.Windows.Forms.ListView lvregistro;
		private System.Windows.Forms.Label lblprecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbproductos;
		private System.Windows.Forms.RadioButton rdbvacio;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.GroupBox gpbeleccion;
		private System.Windows.Forms.PictureBox pblogo;
	}
}
