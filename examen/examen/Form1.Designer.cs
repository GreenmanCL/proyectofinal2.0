/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 29/10/2025
 * Time: 12:59 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace examen
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilometrosAMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilogramosALibrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.celciusAFarenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segundosAHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lblresultado = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.conversionesToolStripMenuItem,
									this.aplicacionesToolStripMenuItem,
									this.areaToolStripMenuItem,
									this.perimetroToolStripMenuItem,
									this.volumenToolStripMenuItem,
									this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// conversionesToolStripMenuItem
			// 
			this.conversionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.longitudToolStripMenuItem,
									this.masaToolStripMenuItem,
									this.temperaturaToolStripMenuItem,
									this.tiempoToolStripMenuItem});
			this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
			this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.conversionesToolStripMenuItem.Text = "&Conversiones";
			// 
			// longitudToolStripMenuItem
			// 
			this.longitudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilometrosAMillasToolStripMenuItem});
			this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
			this.longitudToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.longitudToolStripMenuItem.Text = "&Longitud";
			// 
			// kilometrosAMillasToolStripMenuItem
			// 
			this.kilometrosAMillasToolStripMenuItem.Name = "kilometrosAMillasToolStripMenuItem";
			this.kilometrosAMillasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.kilometrosAMillasToolStripMenuItem.Text = "Kilometros a Millas";
			this.kilometrosAMillasToolStripMenuItem.Click += new System.EventHandler(this.KilometrosAMillasToolStripMenuItemClick);
			// 
			// masaToolStripMenuItem
			// 
			this.masaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilogramosALibrasToolStripMenuItem});
			this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
			this.masaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.masaToolStripMenuItem.Text = "&Masa";
			// 
			// kilogramosALibrasToolStripMenuItem
			// 
			this.kilogramosALibrasToolStripMenuItem.Name = "kilogramosALibrasToolStripMenuItem";
			this.kilogramosALibrasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.kilogramosALibrasToolStripMenuItem.Text = "Kilogramos a Libras";
			this.kilogramosALibrasToolStripMenuItem.Click += new System.EventHandler(this.KilogramosALibrasToolStripMenuItemClick);
			// 
			// temperaturaToolStripMenuItem
			// 
			this.temperaturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.celciusAFarenheitToolStripMenuItem});
			this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
			this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.temperaturaToolStripMenuItem.Text = "&Temperatura";
			// 
			// celciusAFarenheitToolStripMenuItem
			// 
			this.celciusAFarenheitToolStripMenuItem.Name = "celciusAFarenheitToolStripMenuItem";
			this.celciusAFarenheitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.celciusAFarenheitToolStripMenuItem.Text = "Celcius a Farenheit";
			this.celciusAFarenheitToolStripMenuItem.Click += new System.EventHandler(this.CelsiusAFahrenheitToolStripMenuItemClick);
			// 
			// tiempoToolStripMenuItem
			// 
			this.tiempoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.segundosAHorasToolStripMenuItem});
			this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
			this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.tiempoToolStripMenuItem.Text = "&Tiempo";
			// 
			// segundosAHorasToolStripMenuItem
			// 
			this.segundosAHorasToolStripMenuItem.Name = "segundosAHorasToolStripMenuItem";
			this.segundosAHorasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.segundosAHorasToolStripMenuItem.Text = "Segundos a Horas";
			this.segundosAHorasToolStripMenuItem.Click += new System.EventHandler(this.SegundosAHorasToolStripMenuItemClick);
			// 
			// aplicacionesToolStripMenuItem
			// 
			this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.factorialToolStripMenuItem,
									this.fibonacciToolStripMenuItem});
			this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
			this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.aplicacionesToolStripMenuItem.Text = "&Aplicaciones";
			// 
			// factorialToolStripMenuItem
			// 
			this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
			this.factorialToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.factorialToolStripMenuItem.Text = "&Factorial";
			this.factorialToolStripMenuItem.Click += new System.EventHandler(this.FactorialToolStripMenuItemClick);
			// 
			// fibonacciToolStripMenuItem
			// 
			this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
			this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.fibonacciToolStripMenuItem.Text = "F&ibonacci";
			this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.FibonacciToolStripMenuItemClick);
			// 
			// areaToolStripMenuItem
			// 
			this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadradoToolStripMenuItem,
									this.rectanguloToolStripMenuItem,
									this.trianguloToolStripMenuItem});
			this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
			this.areaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.areaToolStripMenuItem.Text = "A&rea";
			// 
			// cuadradoToolStripMenuItem
			// 
			this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
			this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.cuadradoToolStripMenuItem.Text = "Cuadrado";
			this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.CuadradoToolStripMenuItemClick);
			// 
			// rectanguloToolStripMenuItem
			// 
			this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
			this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.rectanguloToolStripMenuItem.Text = "Rectangulo";
			this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.RectanguloToolStripMenuItemClick);
			// 
			// trianguloToolStripMenuItem
			// 
			this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
			this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.trianguloToolStripMenuItem.Text = "Triangulo";
			this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.TrianguloToolStripMenuItemClick);
			// 
			// perimetroToolStripMenuItem
			// 
			this.perimetroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circunferenciaToolStripMenuItem,
									this.trapecioToolStripMenuItem});
			this.perimetroToolStripMenuItem.Name = "perimetroToolStripMenuItem";
			this.perimetroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.perimetroToolStripMenuItem.Text = "&Perimetro";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
			this.circunferenciaToolStripMenuItem.Click += new System.EventHandler(this.CircunferenciaToolStripMenuItemClick);
			// 
			// trapecioToolStripMenuItem
			// 
			this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
			this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.trapecioToolStripMenuItem.Text = "Trapecio";
			this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.TrapecioToolStripMenuItemClick);
			// 
			// volumenToolStripMenuItem
			// 
			this.volumenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.esferaToolStripMenuItem,
									this.cuboToolStripMenuItem});
			this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
			this.volumenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.volumenToolStripMenuItem.Text = "&Volumen";
			// 
			// esferaToolStripMenuItem
			// 
			this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
			this.esferaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.esferaToolStripMenuItem.Text = "Esfera";
			this.esferaToolStripMenuItem.Click += new System.EventHandler(this.EsferaToolStripMenuItemClick);
			// 
			// cuboToolStripMenuItem
			// 
			this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
			this.cuboToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.cuboToolStripMenuItem.Text = "Cubo";
			this.cuboToolStripMenuItem.Click += new System.EventHandler(this.CuboToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.acercaDeToolStripMenuItem.Text = "Acerca de...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(199, 98);
			this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(100, 18);
			this.lbl1.TabIndex = 1;
			this.lbl1.Text = "lbl1";
			this.lbl1.Visible = false;
			// 
			// lbl2
			// 
			this.lbl2.Location = new System.Drawing.Point(199, 132);
			this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(100, 18);
			this.lbl2.TabIndex = 2;
			this.lbl2.Text = "lbl2";
			this.lbl2.Visible = false;
			// 
			// lblresultado
			// 
			this.lblresultado.Location = new System.Drawing.Point(199, 239);
			this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(450, 18);
			this.lblresultado.TabIndex = 5;
			this.lblresultado.Text = "Resultado:";
			this.lblresultado.Visible = false;
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(311, 92);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(150, 20);
			this.txt1.TabIndex = 6;
			this.txt1.Visible = false;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(311, 129);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(150, 20);
			this.txt2.TabIndex = 7;
			this.txt2.Visible = false;
			// 
			// btncalcular
			// 
			this.btncalcular.Location = new System.Drawing.Point(502, 92);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(155, 52);
			this.btncalcular.TabIndex = 10;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Visible = false;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Location = new System.Drawing.Point(502, 164);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(155, 52);
			this.btnlimpiar.TabIndex = 11;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Visible = false;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(783, 66);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(206, 191);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1023, 304);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Name = "Form1";
			this.Text = "Examenxd";
			this.Load += new System.EventHandler(this.Form1Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perimetroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem segundosAHorasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem celciusAFarenheitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilogramosALibrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilometrosAMillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem longitudToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}