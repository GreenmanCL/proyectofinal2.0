/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 06/12/2025
 * Time: 11:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFina
{
	partial class MENU
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.examernAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.formulariosToolStripMenuItem,
									this.informacionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(467, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// formulariosToolStripMenuItem
			// 
			this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.empleadosToolStripMenuItem,
									this.pasteleriaToolStripMenuItem,
									this.examernAnteriorToolStripMenuItem});
			this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
			this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.formulariosToolStripMenuItem.Text = "Formularios";
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItemClick);
			// 
			// pasteleriaToolStripMenuItem
			// 
			this.pasteleriaToolStripMenuItem.Name = "pasteleriaToolStripMenuItem";
			this.pasteleriaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.pasteleriaToolStripMenuItem.Text = "Pasteleria";
			this.pasteleriaToolStripMenuItem.Click += new System.EventHandler(this.PasteleriaToolStripMenuItemClick);
			// 
			// examernAnteriorToolStripMenuItem
			// 
			this.examernAnteriorToolStripMenuItem.Name = "examernAnteriorToolStripMenuItem";
			this.examernAnteriorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.examernAnteriorToolStripMenuItem.Text = "Examern anterior";
			this.examernAnteriorToolStripMenuItem.Click += new System.EventHandler(this.ExamernAnteriorToolStripMenuItemClick);
			// 
			// informacionToolStripMenuItem
			// 
			this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.acercaDeToolStripMenuItem,
									this.salirToolStripMenuItem});
			this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
			this.informacionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.informacionToolStripMenuItem.Text = "informacion";
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// MENU
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(467, 263);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MENU";
			this.Text = "MENU";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem examernAnteriorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteleriaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
