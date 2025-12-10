/*
 * Created by SharpDevelop.
 * User: CC2_PC14
 * Date: 10/12/2025
 * Time: 05:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFina
{
	partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 142);
			this.label1.TabIndex = 0;
			this.label1.Text = "HECHO POR FABRY, DARWIN Y ERICK";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Kristen ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(146, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(472, 113);
			this.label2.TabIndex = 1;
			this.label2.Text = "❤";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(63, 307);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "REGRESAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 366);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
