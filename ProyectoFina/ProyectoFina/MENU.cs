/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 06/12/2025
 * Time: 11:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFina
{
	/// <summary>
	/// Description of MENU.
	/// </summary>
	public partial class MENU : Form
	{
		public MENU()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			EMPLEADOS.MainForm emp = new EMPLEADOS.MainForm();
			emp.MdiParent = this;
			emp.Show();
		}
		
		void PasteleriaToolStripMenuItemClick(object sender, EventArgs e)
		{
			PASTELERIA.MainForm pas = new PASTELERIA.MainForm();
			pas.MdiParent = this;
			pas.Show();
		}
		
		void ExamernAnteriorToolStripMenuItemClick(object sender, EventArgs e)
		{
			examen.Form1 exa = new examen.Form1();
			exa.MdiParent = this;
			exa.Show();
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 acercade = new Form1();
			acercade.Show();
		}
	}
}
