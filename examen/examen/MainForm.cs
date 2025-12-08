/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 29/10/2025
 * Time: 12:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace examen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int contador=0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		//usuario debe ser Admin y contra 123
		void TxtusuarioTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtcontraTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnentrarClick(object sender, EventArgs e)
		{
			
			
			if (txtusuario.Text == "Admin" && txtcontra.Text == "123")
		   {
		   	Form1 f = new Form1();
		   	f.Show();
		   	this.Hide();
		   }
			
			else 
				
			{
				contador = contador +1;
				MessageBox.Show("Usuario o contra incorrectos");
				if (contador>=3)
					
				{
					MessageBox.Show("Usuario o contra incorrectos");
					Application.Exit();
				
				}
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
