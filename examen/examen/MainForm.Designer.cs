/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 29/10/2025
 * Time: 12:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace examen
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.txtcontra = new System.Windows.Forms.TextBox();
			this.btnentrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "USUARIO:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(77, 119);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "CONTRASEÑA:";
			// 
			// txtusuario
			// 
			this.txtusuario.Location = new System.Drawing.Point(285, 35);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(227, 25);
			this.txtusuario.TabIndex = 2;
			this.txtusuario.TextChanged += new System.EventHandler(this.TxtusuarioTextChanged);
			// 
			// txtcontra
			// 
			this.txtcontra.Location = new System.Drawing.Point(285, 117);
			this.txtcontra.Name = "txtcontra";
			this.txtcontra.Size = new System.Drawing.Size(227, 25);
			this.txtcontra.TabIndex = 3;
			this.txtcontra.TextChanged += new System.EventHandler(this.TxtcontraTextChanged);
			// 
			// btnentrar
			// 
			this.btnentrar.Location = new System.Drawing.Point(210, 214);
			this.btnentrar.Name = "btnentrar";
			this.btnentrar.Size = new System.Drawing.Size(282, 57);
			this.btnentrar.TabIndex = 4;
			this.btnentrar.Text = "Entrar";
			this.btnentrar.UseVisualStyleBackColor = true;
			this.btnentrar.Click += new System.EventHandler(this.BtnentrarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 302);
			this.Controls.Add(this.btnentrar);
			this.Controls.Add(this.txtcontra);
			this.Controls.Add(this.txtusuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Minecraft", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Name = "MainForm";
			this.Text = "examen";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnentrar;
		private System.Windows.Forms.TextBox txtcontra;
		private System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
