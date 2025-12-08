/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 06/12/2025
 * Time: 11:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFina
{
	/// <summary>
	/// Description of LOGIN.
	/// </summary>
	public partial class LOGIN : Form
	{
		
		public LOGIN()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int intentos=3;
		
		void Button1Click(object sender, EventArgs e)
		{
			string Usuario, Contraseña;
			Usuario = txtUsuario.Text;
			Contraseña = txtContraseña.Text;
			if(Usuario == "ADMIN" & Contraseña == "123"){
				MENU opciones = new MENU();
				opciones.Show();
			}
			else if(Usuario != "ADMIN" & Contraseña !="123"){
				MessageBox.Show("Te quedan " + intentos.ToString() + " intentos");
				intentos=intentos-1;
			}
			if(intentos==0){
				txtUsuario.Text=" ";
				txtContraseña.Text=" ";
				txtUsuario.Enabled=false;
				txtContraseña.Enabled=false;
				button1.Enabled=false;
			}
					
			}
		}
	}

